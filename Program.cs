using System;
class Program{
    static void Main (string[] args){
        
        string calOperator;

        do{
            calOperator = Console.ReadLine();

            if (calOperator == "+" || calOperator == "-"){

                int m = int.Parse(Console.ReadLine());
                int n = int.Parse(Console.ReadLine());

                float[,] numMatrix_1 = new float[m, n];
                float[,] numMatrix_2 = new float[m, n];
                float[,] numMatrix_Ans = new float[m, n];

                InputMatrix(ref numMatrix_1);
                InputMatrix(ref numMatrix_2);

                MatrixCalculation(ref numMatrix_Ans, numMatrix_1, numMatrix_2, calOperator);

                Print2DMatrix(numMatrix_Ans);

            }

        } while (calOperator == "+" || calOperator == "-");

    }
    static void InputMatrix(ref float[,] matrix)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        matrix[i, j] = float.Parse(Console.ReadLine());
      }
    }
  }

  static void MatrixCalculation(ref float[,] ans, float[,] num1, float[,] num2, string calOperator)
  {
    for (int i = 0; i < ans.GetLength(0); i++)
    {
      for (int j = 0; j < ans.GetLength(1); j++)
      {
        switch (calOperator)
        {
          case "+":
            ans[i, j] = num1[i, j] + num2[i, j];
            break;
          case "-":
            ans[i, j] = num1[i, j] - num2[i, j];
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