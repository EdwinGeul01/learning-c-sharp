

namespace  learning
{
    public class VaraiblesCh2
    {

        public static void Run()
        {
            int numb1 = 12;
            int numb2 = 5;
        
            int result = numb1 + numb2;
            System.Console.WriteLine("result of the sum (int) : "  +  result);



            double numb3 = (double) 12 / 5;
            System.Console.WriteLine("result of the div ( dobule ) : " + numb3);
        }


        public static void Run2()
        {
            const int myNum = 15;
            // myNum = 20; // error
        }
    }
}
