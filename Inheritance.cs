using System;
// Single level Inheritance
 namespace Inheritance;

 class animal
 {
     public void Eat()
     {
         Console.WriteLine("Animal is Eating");
     }
 }

 class Dog : animal
 {
     public void Bark()
     {
         Console.WriteLine("Dog is Barking");
     }
 }

 class Inheritance
 {
     public static void Main()
     {
         Dog d = new Dog();
         d.Eat();
         d.Bark();
     }
 }

//Multilevel Inheritance
 class Animal
 {
     public void Eat()
     {
         Console.WriteLine("Eating");
     }
 }

 class Dog : Animal
 {
     public void Bark()
     {
         Console.WriteLine("Barking");
     }
 }

 class puppy : Dog
 {
     public void Weep()
     {
         Console.WriteLine(("Weeping"));
     }
 }

 class Multilevel
 {
     static void Main()
     {
         puppy p1 = new puppy();
         p1.Eat();
         p1.Bark();
     }
 }

//Hierarchical Inheritance
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating");
    }
}

class dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is Barking");
    }
}

class cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat is Meowing");
    }

}

class Hierarchical
{
    public static void Main()
    {
        dog d = new dog();
        cat c = new cat();
        d.Eat();
        c.Eat();
        d.Bark();
        c.Meow();
    }
}
