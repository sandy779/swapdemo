using System;

namespace swapdemo
{
    class swap {
        
        public void swapping(ref int x,ref int y)
        {
           int temp = x;
            x = y;
            y = temp;
        }
       
    
    }

       
    class Program
    {
        static void Main(string[] args)
        {
            swap obj = new swap();
            Console.WriteLine("Enter value of X:");
           int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers before swapping: x={0},y={1}:", x, y);
            
            obj.swapping(ref x,ref y);
            Console.WriteLine("Numbers After swapping: x={0},y={1}:", x, y);
        }
    }
}
