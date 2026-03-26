using System;
using System.Data;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Dapper;

class Program
{
    static async Task Main()
    {
        // connection
        var connectionString = "Server=127.0.0.1,1433;Database=DapperDemoDB;User Id=sa;Password=StrongPass@123;TrustServerCertificate=True;";
        using var connection = new SqlConnection(connectionString);
        connection.Open();

        // insert
        var product = new Product
        {
            Name = "iPhone 15",
            Category = "Electronics",
            Price = 80000,
            Stock = 10
        };

        connection.Execute(
            "INSERT INTO Products (Name, Category, Price, Stock) VALUES (@Name, @Category, @Price, @Stock)",
            product);

        // query all
        var products = connection.Query<Product>("SELECT * FROM Products");
        foreach (var p in products)
            Console.WriteLine(p.Name);

        // query first
        var first = connection.QueryFirst<Product>("SELECT * FROM Products");
        Console.WriteLine(first.Name);

        // query first or default
        var firstOrDefault = connection.QueryFirstOrDefault<Product>(
            "SELECT * FROM Products WHERE Id = @Id", new { Id = -1 });

        // query single
        var single = connection.QuerySingle<Product>(
            "SELECT * FROM Products WHERE Id = @Id", new { Id = 1 });

        // query single or default
        var singleOrDefault = connection.QuerySingleOrDefault<Product>(
            "SELECT * FROM Products WHERE Id = @Id", new { Id = -1 });

        // query multiple
        using (var multi = connection.QueryMultiple(@"
            SELECT * FROM Products;
            SELECT COUNT(*) FROM Products;"))
        {
            var list = multi.Read<Product>();
            var count = multi.ReadFirst<int>();
            Console.WriteLine(count);
        }

        // execute scalar
        var total = connection.ExecuteScalar<int>("SELECT COUNT(*) FROM Products");

        // execute reader
        using (var reader = connection.ExecuteReader("SELECT * FROM Products"))
        {
            while (reader.Read())
                Console.WriteLine(reader["Name"]);
        }

        // anonymous parameter
        connection.Query<Product>(
            "SELECT * FROM Products WHERE Id = @Id",
            new { Id = 1 });

        // dynamic parameter
        var dp = new DynamicParameters();
        dp.Add("Id", 1);
        connection.Query<Product>(
            "SELECT * FROM Products WHERE Id = @Id", dp);

        // list parameter
        var ids = new[] { 1, 2 };
        connection.Query<Product>(
            "SELECT * FROM Products WHERE Id IN @Ids",
            new { Ids = ids });

        // string parameter
        connection.Query<Product>(
            "SELECT * FROM Products WHERE Name = @Name",
            new { Name = "iPhone 15" });

        // update
        connection.Execute(
            "UPDATE Products SET Price = @Price WHERE Id = @Id",
            new { Price = 75000, Id = 1 });

        // delete
        connection.Execute(
            "DELETE FROM Products WHERE Id = @Id",
            new { Id = 2 });

        // transaction
        using (var transaction = connection.BeginTransaction())
        {
            try
            {
                connection.Execute(
                    "INSERT INTO Products (Name, Category, Price, Stock) VALUES ('T1','Test',100,1)",
                    transaction: transaction);

                connection.Execute(
                    "INSERT INTO Products (Name, Category, Price, Stock) VALUES ('T2','Test',200,2)",
                    transaction: transaction);

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
        }

        // async
        var asyncProducts = await connection.QueryAsync<Product>("SELECT * FROM Products");

        // unbuffered async
        await foreach (var item in connection.QueryUnbufferedAsync<Product>("SELECT * FROM Products"))
        {
            Console.WriteLine(item.Name);
        }

        Console.WriteLine("done");
    }
}

// model
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}