using System;

namespace my_project2
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 10;
          
        //    if(i == 6) {
        //         Console.WriteLine("inside if");
        //    }
           
        //    if(i >= 6){
        //         Console.WriteLine("inside else if");
        //    }

        //    if(!false){
        //         Console.WriteLine("always run");
        //    }

        //    if(!true){
        //         Console.WriteLine("never run");
        //    }

        //    if(true){
        //         Console.WriteLine("always run");
        //    }

        //'''''''''''''''''''''''
        //&& -> and
        //.......................
            //easy example
        //  if(true && false){
        //         Console.WriteLine("inside if");
        //    }

        //    int a = 2;
        //    int b = 7;
        //    if(a==2 && b>4){
        //        Console.WriteLine("inside if runing");
        //    }



        //'''''''''''''''''''''''
        //|| -> or
        //.......................
        //  int a = 0;
        //  int b = 7;
        //  if(a==2 || b == 14 || b ==10){
        //     Console.WriteLine("inside if runing");
        //  }

        /*
        95 - 100 -> canada
        90 - 100 -> scholarship
        80 - 100 -> A+
        70 - 80 -> A
        60 - 70 -> A -
        */

         Console.WriteLine("====== This is samir's software ========");

         Console.WriteLine("\nPlease enter your Name : ");
         string name = Console.ReadLine();

         Console.WriteLine($"\n Hi! {name} Please enter your mark : ");
         int mark = Convert.ToInt32(Console.ReadLine());
         
         if(mark >= 95){
            Console.WriteLine("kangaralesing you get game projects. game projects. Canada Besha!!");
         }

         else if(mark >= 90)
         {
             Console.WriteLine("you got schlarship");
         }
         else if(mark >= 80)
         {
             Console.WriteLine("you gat,A+");
         }

         else if (mark >= 70)
         {
             Console.WriteLine("um...you gat,A");
         }

         else if(mark >= 60)
         {
             Console.WriteLine("oh....um..you can try again,but it's not bad you gat,A-");
         }

         else
         {
             Console.WriteLine("we are sorre we can't find ane thinkg,FAILED try again");
         }
         

        }
    }
}
