using System;

namespace MyNamespace
{
   // class Car
   // {
   //    public string carName;
   //    public int speed;
   //
   //    public Car(string carName, int speed)
   //    {
   //       this.carName = carName;
   //       this.speed = speed;
   //    }
   //
   //    public void Display()
   //    {
   //       Console.WriteLine("carName: "+ carName+", Speed: "+speed);
   //    }
   //
   //    public static void Main(string[] args)
   //    {
   //       Car c1 = new Car("BMW", 100);
   //       c1.Display();
   //    }
   // }
   
   
   //Food Delivery App
   class foodDelivery
   {
      public string Name;
      public string Location;
      public string Item;

      public foodDelivery(string name, string location, string item)
      {
         this.Name = name;
         this.Location = location;
         this.Item = item;
      }

      public void Display()
      {
         Console.WriteLine($"name = {Name} location = {Location} item = {Item}");
      }
      // This is Fixed data
      // public static void Main(string[] args)
      // {
      //    foodDelivery dev1 = new foodDelivery("Murugan", "Chennai", "Chicken");
      //    dev1.Display();
      // }
      public static void Main(string[] Args)
      {
         foodDelivery[] dev1 = new foodDelivery[2];
         dev1[0] = new foodDelivery("Murugan", "Chennai", "Chicken");
         dev1[1] = new foodDelivery("Pathayam", "Tambaram", "Fish Grill");
         

         for (int i = 0; i < dev1.Length; i++)
         {
            dev1[i].Display();
         }
      }
   }
   
}