


namespace learning
{
    public class Casting {

        public static void Run()
        {
            
            Console.WriteLine("----- Chapter 03 -----");

            //implicit casting 
            // Implicit casting is done automatically when passing a smaller size type to a larger size type:

            int myInt = 123;
            double myDouble = myInt;
            
            
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            
            
            // explicit casting
            // must be done manually by placing the type in parentheses in front of the value 
            double myDouble2 = 9.78;
            int myInt2 = (int) myDouble2;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9




        }
        
        
        
    }    
    
}
