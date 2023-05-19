using System;

class Program
{
  static void Main(string[] args)
  {
    string numOperator;
    do
    {
      numOperator = Console.ReadLine();
      if (numOperator == "+" || numOperator == "-")
      {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        float[,] numMatrix = new float[m, n];

        MatrixInput(ref numMatrix);
        MatrixOperation(ref numMatrix, numOperator);
        Print2DMatrix(numMatrix);
      }
    } while (numOperator == "+" || numOperator == "-");
  }
  static void MatrixInput(ref float[,] matrix)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i, j] = float.Parse(Console.ReadLine());
      }
    }
  }
  static void MatrixOperation(ref float[,] ans, string numOperator)
  {
    for (int i = 0; i < ans.GetLength(0); i++)
    {
      for (int j = 0; j < ans.GetLength(1); j++)
      {
        float num = float.Parse(Console.ReadLine());
        switch (numOperator)
        {
          case "+":
            ans[i, j] += num;
            break;
          case "-":
            ans[i, j] -= num;
            break;
        }
      }
    }
  }
  static void Print2DMatrix(float[,] matrix)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        Console.Write("{0:0.0} ", matrix[i, j]);
      }
      Console.WriteLine("");
    }
  }

}