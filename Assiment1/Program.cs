using System.Drawing;

internal class Program
{
   
    static void Main(string[] args)
    {
        #region print number
        Console.WriteLine("please enter the number");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the number is" + number);
        #endregion

        #region Assigning one value type 
        int x;
        x = 4;
        int y;
        y = x;
        Console.WriteLine(x);
        Console.WriteLine(y);
        y = 6;
        Console.WriteLine(y);
        //y will change from 4 to 6 because i change this value
        #endregion
        #region Referance Type
        Point P01;
        P01 = new Point();
        Point P02 = new Point();
        P02 = P01;
        P01.X = 10;
        Console.WriteLine(P02.X);
        // P02 references the same object as P01
       // Modifies the object referenced by both P01 and P02 and we will have Unreachable object
        #endregion
       
    }
}