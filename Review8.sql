
CREATE DATABASE BillingInv;

USE BillingInv;

CREATE TABLE Products
(
    product_id INT PRIMARY KEY,
    product_name VARCHAR(50),
    price DECIMAL(10,2),
    stock INT
);

CREATE TABLE Customers
(
    customer_id INT PRIMARY KEY,
    customer_name VARCHAR(50)
);

CREATE TABLE Bills
(
    bill_id INT PRIMARY KEY,
    customer_id INT,
    bill_date DATE,
    total_amount DECIMAL(10,2)
);

CREATE TABLE BillItems
(
    bill_item_id INT IDENTITY(1,1) PRIMARY KEY,
    bill_id INT,
    product_id INT,
    quantity INT,
    price DECIMAL(10,2)
);

INSERT INTO Products
VALUES
    (1, 'Coffee', 50, 10),
    (2, 'Tea', 20, 15),
    (3, 'Cake', 100, 5);

INSERT INTO Customers
VALUES
    (1, 'Ravi'),
    (2, 'Sita');

SELECT *
FROM Products;
SELECT *
FROM Customers;

CREATE TRIGGER trg_reduce_stock
ON BillItems
AFTER INSERT
AS
BEGIN
    UPDATE p         
SET p.stock = p.stock - i.quantity
FROM Products p
        JOIN inserted i
        ON p.product_id = i.product_id;
END;

CREATE FUNCTION fn_TotalBill(@billid INT)
RETURNS DECIMAL(10,2)
AS
BEGIN
    DECLARE @total DECIMAL(10,2);

    SELECT @total = SUM(quantity*price)
    FROM BillItems
    WHERE bill_id=@billid;

    RETURN @total;
END;

CREATE PROCEDURE CreateBill
    @billid INT,
    @custid INT,
    @productid INT,
    @qty INT
AS
BEGIN

    BEGIN TRANSACTION

    DECLARE @price DECIMAL(10,2)
    DECLARE @stock INT

    SELECT @price=price, @stock=stock
    FROM Products
    WHERE product_id=@productid

    IF @stock<@qty
BEGIN
        PRINT 'Stock not sufficient'
        ROLLBACK
        RETURN
    END

    INSERT INTO Bills
    VALUES(@billid, @custid, GETDATE(), 0)

    INSERT INTO BillItems
        (bill_id,product_id,quantity,price)
    VALUES(@billid, @productid, @qty, @price)

    UPDATE Bills
SET total_amount=dbo.fn_TotalBill(@billid)
WHERE bill_id=@billid

    COMMIT

END


CREATE VIEW DailySalesReport
AS
    SELECT bill_date, SUM(total_amount) AS TotalSales
    FROM Bills
    GROUP BY bill_date;

SELECT product_name
FROM Products
WHERE product_id =
(
    SELECT TOP 1
    product_id
FROM BillItems
GROUP BY product_id
ORDER BY SUM(quantity) DESC
);

EXEC CreateBill 1,1,1,2;
EXEC CreateBill 2,1,1,2;
EXEC CreateBill 3,2,2,1;
EXEC CreateBill 1,1,2,3;
EXEC CreateBill 4,1,2,3;



SELECT name, is_disabled
FROM sys.triggers
WHERE name = 'trg_reduce_stock';

SELECT *
FROM Bills;
SELECT *
FROM BillItems;
SELECT *
FROM Products;

