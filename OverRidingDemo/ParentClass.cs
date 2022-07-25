/* We can re-implement a parent classes method under child class by using 2 approaches:
   1. Method OverRiding  -  with permission
   2. Method Hiding/Shadowing - without permission*/

/* After re-implementing parent classes methods under child classes, 
   the child class instance will start calling the local methods only that is the re-implemented methods,
   but if required in any case we can also call the parent classes methods from child classes by using 2 approaches:
    1. By creating the instance of parent class under child class we can call parents method from child class.
    2. By using the base keyword also we can call parent's method from child class but keywords like
       this and base can't be used from static blocks.*/

using System;

namespace OverRidingDemo
{
    class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Method Test1 from parent class is called.");
        }
        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class is called.");
        }
    }
    class ChildClass : ParentClass
    {
        public override void Test1()     //method overriding
        {
            Console.WriteLine("Method Test1 from child class is called.");
        }
        public new void Test2()          //method hiding/shadowing
        {
            Console.WriteLine("Method Test2 from child class is called.");
        }
       /* public void ParentTest1()      // this is the 2nd approach.
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        } */
        
        static void Main()
        {
           /* ParentClass p = new ParentClass();    //this is the 1st approach.
            p.Test1();
            p.Test2(); */
        ChildClass c = new ChildClass();
            /*c.ParentTest1();        // calling parent's class using 2nd approach.
            c.ParentTest2();*/
        c.Test1();
        c.Test2();
        }
    }
}
