using System;

class Program 
{
  public static void Main (string[] args) 
    {
    int number;
    do
    {
        Console.Write("Enter a Positive Number: ");
        string PosNum = Console.ReadLine();

        if(!int.TryParse(PosNum, out number) || number < 0)
        {
            Console.WriteLine("Invalid Input. Please enter a non-negative number.");
            continue;
        }
        else if (number == 0)
        {
            Console.WriteLine("Closing Program. Goodbye.");
            return;
        }
        Stariangle(number);
    }while(true);
    }
    static void Stariangle(int n)
    {
      for (int i=1; i<= n; i++)
      {
      for (int k=1; k<= n-i; k++)
      {
          Console.Write(" ");
      }
      for (int j=1; j<=2*i-1; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        }
    }
  }