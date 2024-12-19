using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Dynamic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
    }
    #region Level 1
    static int Factorial(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
    static int Combinations(int n, int k)
    {
        return Factorial(n) / (Factorial(k) * Factorial(n - k));
    }   

    public long Task_1_1(int n, int k)
    {
        long answer = 0;

        // code here
        
        answer = Combinations(n, k);
        // create and use Combinations(n, k);
        // create and use Factorial(n);

        // end

        return answer;
    }
  
    
    static double GeronArea(double a, double b, double c)
    {
        double p = (a + b + c)/2;
        double S = Math.Sqrt(p*(p - a)*(p-b)*(p-c));
        return S;
    }
    public int Task_1_2(double[] first, double[] second)
    {
        int answer = 0;
        double a = first[0];
        double b = first[1];
        double c = first[2];

        double a1 = second[0];
        double b1 = second[1];
        double c1 = second[2];
        // code here
        //answer = GeronArea(a,b,c);
        // create and use GeronArea(a, b, c);
        if (c + b <= a || a + c <= b || a + b <= c ||  b1 + c1 <= a1 || c1 + a1 <= b1 || a1 + b1 <= c1)
        {
            return -1;
        }

        if (GeronArea(a, b, c) > GeronArea(a1, b1, c1)) 
        {
            return 1;
        }
        else if (GeronArea(a, b, c) < GeronArea(a1, b1, c1)) 
        {
            return 2;
        }
        else if (GeronArea(a, b, c) == GeronArea(a1, b1, c1)) 
        {
            return 0;
        }

        // end

        // first = 1, second = 2, equal = 0, error = -1
        return answer;
    }
    

    static double GetDistance(double v, double a, int t) 
    {
        double S = v * t + a * t * t / 2;
        return S;
    }
    public int Task_1_3a(double v1, double a1, double v2, double a2, int time)
    {
        int answer = 0;

        // code here
        if (GetDistance(v1, a1, time) > GetDistance(v2, a2, time)) 
        {
            return 1;
        }

        if (GetDistance(v1, a1, time) < GetDistance(v2, a2, time)) 
        {
            return 2;
        }
        else 
        {
            return 0;
        }
        // create and use GetDistance(v, a, t); t - hours

        // end

        // first = 1, second = 2, equal = 0
        return answer;
    }

    public int Task_1_3b(double v1, double a1, double v2, double a2)
    {
        int answer = 0;

        // code here
        for (int t = 1;; t++) 
        {
            if (GetDistance(v1, a1, t) <= GetDistance(v2, a2, t)) 
            {
                return t;
            }
        }
        // use GetDistance(v, a, t); t - hours

        // end

        return answer;
    }
    #endregion

    #region Level 2
    public void Task_2_1(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxIndex(matrix, out row, out column);

        // end
    }

    static int FindMaxIndex(double[] array)
    {
        int count = 0;
        double max = -99999;
        for (int i = 0; i < array.Length; i++) 
        {
            if (max < array[i]) 
            {
                max = array[i];
                count = i;
            }
        }
        return count;
    }
    public void Task_2_2(double[] A, double[] B)
    {
        // code here
        double sum = 0;
        double count = 0;
        int maxA = FindMaxIndex(A);
        int maxB = FindMaxIndex(B);
        if (maxA < maxB) 
        {
            for (int i = maxA + 1; i < A.Length; i++) 
            {
                sum += A[i];
                count++;
            }
            double sr = sum / (count);
            A[maxA] = sr;
        }
        else 
        {
            for (int i = maxB + 1; i < B.Length; i++) 
            {
                sum += B[i];
                count++;
            }
            double sr = sum / (count);
            B[maxB] = sr;
        }

        // create and use FindMaxIndex(array);
        // only 1 array has to be changed!

        // end
    }

    public void Task_2_3(ref int[,] B, ref int[,] C)
    {
        // code here

        //  create and use method FindDiagonalMaxIndex(matrix);

        // end
    }

    static int FindDiagonalMaxIndex(int[,] matrix)
    {
        int max = 0;
        int maxval = matrix[0, 0];

        for (int i = 1; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, i] > maxval)
            {
                maxval = matrix[i, i];
                max = i;
            }
        }

        return max;
    }

    public void Task_2_4(int[,] A, int[,] B)
    {
        // code here
        int maxA = FindDiagonalMaxIndex(A);
        int maxB = FindDiagonalMaxIndex(B);

        for (int i = 0; i < A.GetLength(0); i++)
        {
            // Сохраняем значение из столбца B
            int temp = B[i, maxB];
            // Меняем строку A с элементом из столбца B
            B[i, maxB] = A[maxA, i];
            // Меняем элемент из столбца B на элемент из строки A
            A[maxA, i] = temp;
        }
        //  create and use method FindDiagonalMaxIndex(matrix); like in Task_2_3

        // end
    }


    public void Task_2_5(int[,] A, int[,] B)
    {
        // code here

        // create and use FindMaxInColumn(matrix, columnIndex, out rowIndex);

        // end
    }

    static int FindMax(int[] array)
    {
        
        int index = -1;
        int max = -99999;
        for(int i = 0; i < array.Length; i ++)
        {
            if (max < array[i]) 
            {
                max = array[i];
                index = i;
            }
        }
        return index;
    }
    static int[] DeleteElement(int[] array, int index)
    {
        int[] newarray = new int[array.Length-1];
        for(int i = 0, j = 0; i < array.Length; i ++)
        {
            if(i == index)
            {
                continue;
            }
            else
            {
                newarray[j] = array[i];
                j ++;
            }
        }
        return newarray;
    }
    public void Task_2_6(ref int[] A, int[] B)
    {
        // code here
        int maxA = FindMax(A);
        int maxB = FindMax(B);
        // create and use FindMax(matrix, out row, out column); like in Task_2_1
        // create and use DeleteElement(array, index);
        A = DeleteElement(A, maxA);
        B = DeleteElement(B, maxB);
        int[] newarr = new int[A.Length + B.Length];
        for(int i = 0; i < A.Length; i ++)
        {
            newarr[i] = A[i];
        }
        for(int i = 0; i < B.Length; i ++)
        {
            newarr[A.Length + i] = B[i];
        }
        A = newarr;
        // end
    }

    public void Task_2_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use CountRowPositive(matrix, rowIndex);
        // create and use CountColumnPositive(matrix, colIndex);

        // end
    }
    int[] SortArrayPart(int[] array, int startIndex)
    {
        for(int i = startIndex + 1; i < array.Length; i ++ )
        {
            for(int j = startIndex + 1; j < array.Length - 1; j ++)
            {
                if(array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
    public void Task_2_8(int[] A, int[] B)
    {
        // code here
        int maxIndexA = -1;
        int maxA = -99999;
        int maxB = -99999;
        for (int i = 1; i < A.Length; i++)
        {
            if (A[i] > maxA)
            {
                maxA = A[i];
                maxIndexA = i;
            }
        }
        A = SortArrayPart(A, maxIndexA);

        int maxIndexB = -1;
        for (int i = 1; i < B.Length; i++)
        {
            if (B[i] > maxB)
            {
                maxB = B[i];
                maxIndexB = i;
            }
        }
        B = SortArrayPart(B, maxIndexB);
        // create and use SortArrayPart(array, startIndex);
        Console.WriteLine(string.Join(", ", A));
        Console.WriteLine(string.Join(", ", B));
        // end
    }

    public int[] Task_2_9(int[,] A, int[,] C)
    {
        int[] answer = default(int[]);

        // code here

        // create and use SumPositiveElementsInColumns(matrix);

        // end

        return answer;
    }
    static int[,] RemoveColumn(int[,] matrix, int columnIndex)
    {
        int indexarr = 0;
        int[,] newarr = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            if(j == columnIndex)
            {
                continue;
            }
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                newarr[i, indexarr] = matrix[i, j];
            }
            indexarr++;
        }
        return newarr;
    }
    public void Task_2_10(ref int[,] matrix)
    {
        // code here
        int min = 9999;
        int max = -99999;
        int down = 0;
        int up = 0;
        for(int i = 0; i < matrix.GetLength(0); i ++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                if(min > matrix[i,j])
                {
                    min = matrix[i,j];
                    up = j;
                }
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = 0; j <= i; j++) 
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    down = j;
                }
            }
        }
        if (up > down) 
        {
            matrix = RemoveColumn(matrix, up);
            matrix = RemoveColumn(matrix, down);
        }
        else if (down > up) 
        {
            matrix = RemoveColumn(matrix, down);
            matrix = RemoveColumn(matrix, up);
        }
        else 
        {
            matrix = RemoveColumn(matrix, down);
        }
        // create and use RemoveColumn(matrix, columnIndex);

        // end
    }

    public void Task_2_11(int[,] A, int[,] B)
    {
        // code here

        // use FindMaxIndex(matrix, out row, out column); from Task_2_1

        // end
    }
    
    int FindMaxColumnIndex(int[,] matrix)
    {
        int max = -9999;
        int index = -1;
        for(int i = 0; i < matrix.GetLength(0); i ++)
        {
            for(int j = 0; j < matrix.GetLength(1); j ++)
            {
                if(max < matrix[i,j])
                {
                    max = matrix[i,j];
                    index = j;
                }
            }
        }
        return index;
    }
    public void Task_2_12(int[,] A, int[,] B)
    {
        // code here
        int indA = FindMaxColumnIndex(A);
        int indB = FindMaxColumnIndex(B);
        int[] temp = new int[A.GetLength(1)];
        for (int i = 0; i < A.GetLength(1); i++) 
        {
            temp[i] = A[i, indA];
        }
        for (int i = 0; i < A.GetLength(1); i++) 
        {
            A[i, indA] = B[i, indB];
        }
        for (int i = 0; i < B.GetLength(1); i++) 
        {
            B[i, indB] = temp[i];
        }
        // create and use FindMaxColumnIndex(matrix);

        // end
    }

    public void Task_2_13(ref int[,] matrix)
    {
        // code here

        // create and use RemoveRow(matrix, rowIndex);

        // end
    }
    static int[,] SortRow(int[,] matrix, int rowIndex)
    {  
        for (int i = 0; i<matrix.GetLength(1); i++) 
        {
            for (int j = 0; j<matrix.GetLength(1)- i- 1; j++)
            {
                if (matrix[rowIndex,j] > matrix[rowIndex,j + 1]) 
                {
                    int temp = matrix[rowIndex,j];
                    matrix[rowIndex,j] = matrix[rowIndex,j + 1];
                    matrix[rowIndex,j + 1] = temp;
                }
            }
        }
        return matrix;
    }
    public void Task_2_14(int[,] matrix)
    {
        // code here
        for(int i = 0; i < matrix.GetLength(0); i ++)
        {
            SortRow(matrix, i);
        }
        // create and use SortRow(matrix, rowIndex);

        // end
    }

    public int Task_2_15(int[,] A, int[,] B, int[,] C)
    {
        int answer = 0;

        // code here

        // create and use GetAverageWithoutMinMax(matrix);

        // end

        // 1 - increasing   0 - no sequence   -1 - decreasing
        return answer;
    }

    int[] SortNegative(int[] array)
    {
        int count = 0;
        int[] negatives = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                negatives[count] = array[i];
                count++;
            }
        }
        for (int i = 0; i < count; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (negatives[j] < negatives[j + 1])
                {
                    int temp = negatives[j];
                    negatives[j] = negatives[j + 1];
                    negatives[j + 1] = temp;
                }
            }
        }
        int negIndex = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = negatives[negIndex];
                negIndex++;
            }
        }
        // for(int i = 0; i < array.Length; i ++ )
        // {
        //     for(int j = 0; j < array.Length - i - 1; j ++)
        //     {
        //         if(array[j] < 0 && array[j+1] < 0)
        //         {
        //             if(array[j] < array[j + 1])
        //             {
        //                 int temp = array[j];
        //                 array[j] = array[j + 1];
        //                 array[j + 1] = temp;
        //             }
        //         }
        //     }
        // }
        return array;
    }
    public void Task_2_16(int[] A, int[] B)
    {
        // code here
        SortNegative(A);
        SortNegative(B);
        // create and use SortNegative(array);

        // end
    }

    public void Task_2_17(int[,] A, int[,] B)
    {
        // code here

        // create and use SortRowsByMaxElement(matrix);

        // end
    }

    int[,] SortDiagonal(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0) - 1; i ++)
        {
            for(int j = 0; j < matrix.GetLength(1) - i - 1; j ++)
            {
                if(matrix[j,j] > matrix[j + 1,j + 1])
                {
                    int temp = matrix[j,j];
                    matrix[j,j] = matrix[j + 1,j + 1];
                    matrix[j + 1,j + 1] = temp;
                }
            }
        }
        return matrix;
    }
    public void Task_2_18(int[,] A, int[,] B)
    {
        // code here
        A = SortDiagonal(A);
        B = SortDiagonal(B);
        // create and use SortDiagonal(matrix);

        // end
    }

    public void Task_2_19(ref int[,] matrix)
    {
        // code here

        // use RemoveRow(matrix, rowIndex); from 2_13

        // end
    }
    static int[,] RemoveColumn1(int[,] matrix, int columnIndex)
    {
        int indexarr = 0;
        int[,] newarr = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            if(j == columnIndex)
            {
                continue;
            }
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                newarr[i, indexarr] = matrix[i, j];
            }
            indexarr++;
        }
        return newarr;
    }
    public void Task_2_20(ref int[,] A, ref int[,] B)
    {
        // code here

        for(int j = A.GetLength(1) - 1; j >= 0; j--)//с конца в начало
        {
            int countA = 0;
            for(int i = 0; i < A.GetLength(0); i ++)
            {
                if(A[i,j] == 0)
                {
                    countA ++;
                }
            }
            if (countA == 0)
            {
                A = RemoveColumn1(A, j);
            }
        }
        

        for(int j = B.GetLength(1) - 1; j >= 0; j--)//с конца в начало
        {
            int countB = 0;
            for(int i = 0; i < B.GetLength(0); i ++)
            {
                if(B[i,j] == 0)
                {
                    countB ++;
                }
            }
            if (countB == 0)
            {
                B = RemoveColumn1(B, j);
            }

        }

        for(int i = 0; i < A.GetLength(0); i ++)
        {
            for(int j = 0; j < A.GetLength(1); j ++)
            {
                Console.Write(A[i,j] + " ");
            }
        }
        for(int i = 0; i < B.GetLength(0); i ++)
        {
            for(int j = 0; j < B.GetLength(1); j ++)
            {
                Console.Write(B[i,j] + " ");
            }
        }



        // use RemoveColumn(matrix, columnIndex); from 2_10

        // end
    }

    public void Task_2_21(int[,] A, int[,] B, out int[] answerA, out int[] answerB)
    {
        answerA = null;
        answerB = null;

        // code here

        // create and use CreateArrayFromMins(matrix);

        // end
    }
    static int CountNegativeInRow(int[,] matrix,int rowIndex)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (matrix[rowIndex,j] < 0) 
            {
                count++;
            }
        }
        return count;
    }
    static int FindMaxNegativePerColumn(int [,] matrix, int colIndex) 
    {
        int max = -99999999;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            if (matrix[i, colIndex] > max && matrix[i, colIndex] < 0) 
            {
                max = matrix[i, colIndex];
            }
        }
        return max;
    }
    public void Task_2_22(int[,] matrix, out int[] rows, out int[] cols)
    {
        rows = null;
        cols = null;

        // code here
        rows = new int[matrix.GetLength(0)];
        cols = new int[matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            rows[i] = CountNegativeInRow(matrix, i);
        }

        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            cols[j] = FindMaxNegativePerColumn(matrix, j);
        }

        // create and use CountNegativeInRow(matrix, rowIndex);
        // create and use FindMaxNegativePerColumn(matrix);

        // end
    }

    public void Task_2_23(double[,] A, double[,] B)
    {
        // code here

        // create and use MatrixValuesChange(matrix);

        // end
    }
    static int FindMaxIndex(int[,] matrix, out int row, out int column)
    {
        column = 0;
        row = 0;
        int max = -999999;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                if (matrix[i, j] > max) 
                {
                    max = matrix[i, j];
                    column = j;
                    row = i;
                }
            }
        }
        return column;
    }

    static int[,] SwapColumnDiagonal(int[,] matrix, int columnIndex)
    {

        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            int temp = matrix[i,i];
            matrix[i,i] = matrix[i, columnIndex];
            matrix[i, columnIndex] = temp;
        }
        return matrix;
        
    }
    public void Task_2_24(int[,] A, int[,] B)
    {
        // code here
        int i = 0;
        int j = 0;
        FindMaxIndex(A, out i, out j);
        A = SwapColumnDiagonal(A, j);

        FindMaxIndex(B, out i, out j);
        B = SwapColumnDiagonal(B, j);
        // use FindMaxIndex(matrix, out row, out column); like in 2_1
        // create and use SwapColumnDiagonal(matrix, columnIndex);

        // end
    }

    public void Task_2_25(int[,] A, int[,] B, out int maxA, out int maxB)
    {
        maxA = 0;
        maxB = 0;

        // code here

        // create and use FindRowWithMaxNegativeCount(matrix);
        // in FindRowWithMaxNegativeCount create and use CountNegativeInRow(matrix, rowIndex); like in 2_22

        // end
    }

    static int FindRowWithMaxNegativeCount(int[,] matrix)
    {
        int max = 0;
        int ind = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            if(max < CountNegativeInRow(matrix,i)) 
            {
                max = CountNegativeInRow(matrix, i);
                ind = i;
            }
        }
        return ind;
    }
    public void Task_2_26(int[,] A, int[,] B)
    {
        // code here
        int indA = FindRowWithMaxNegativeCount(A);
        int indB = FindRowWithMaxNegativeCount(B);
        //int[] temp = new int[A.GetLength(0)];
        for(int i = 0; i < A.GetLength(0); i ++)
        {
            for(int j = 0; j < A.GetLength(1); j ++)
            {
                int temp = A[indA, j];
                A[indA, j] = B[indB, j];
                B[indB, j] = temp;
            }
        }

        // create and use FindRowWithMaxNegativeCount(matrix); like in 2_25
        // in FindRowWithMaxNegativeCount use CountNegativeInRow(matrix, rowIndex); from 2_22

        // end
    }

    public void Task_2_27(int[,] A, int[,] B)
    {
        // code here

        // create and use FindRowMaxIndex(matrix, rowIndex, out columnIndex);
        // create and use ReplaceMaxElementOdd(matrix, row, column);
        // create and use ReplaceMaxElementEven(matrix, row, column);

        // end
    }

    // static int FindSequence(int[] array, int A, int B)
    // {
        
    //     int answer = 0;
    //     for (int i = A; i < B; i ++) 
    //     {
    //         if (array[i] < array[i + 1])
    //         {
    //             if(answer == 0)
    //             {
    //                 answer = 1;
                    
    //             } 
    //             // else if (answer == 1)
    //             // {
    //             //     answer = 1;
    //             // }
    //             else if (answer == -1)
    //             {
    //                 return 0; //монотонность не сохраняется
    //             }
    //         }
    //         else if(array[i] > array[i + 1])
    //         {
    //             if(answer == 0)
    //             {
    //                 answer = -1;
                    
    //             } 
    //             // else if (answer == -1)
    //             // {
    //             //     answer = -1;
    //             // }
    //             else if (answer == 1)
    //             {
    //                 return 0; //монотонность не сохраняется
    //             }
    //         }
    //     }
    //     return answer;
    // }
    // static bool FindIncreasingSequence1(int[] array, int A, int B)
    // {
    //     bool answer = false;
    //     for (int i = A; i < B; i ++) 
    //     {
    //         if(array[i] < array[i + 1])
    //         {
    //             answer = true;
    //         }
    //         else
    //         {
    //             answer = false;
    //             break;
    //         }
    //     }
    //     return answer;
    // }

    // static bool FindDecreasingSequence1(int[] array, int A, int B)
    // {
    //     bool answer = false;
    //     for (int i = A; i < B; i ++) 
    //     {
    //         if(array[i] > array[i + 1])
    //         {
    //             answer = true;
    //         }
    //         else
    //         {
    //             answer = false;
    //             break;
    //         }
    //     }
    //     return answer;
    // }

    // static int FindSequence(int[] array, int A, int B)
    // {
    //     if (FindIncreasingSequence1(array, A, B)) 
    //     {
    //         return 1;
    //     }
    //     if(FindDecreasingSequence1(array, A, B)) 
    //     {
    //         return -1;
    //     }
    //     else 
    //     {
    //         return 0;
    //     }
    // }
    static int FindSequence(int[] array, int A, int B)
    {
        bool isIncreasing = true;
        bool isDecreasing = true;

        for (int i = A; i < B; i++)
        {
            if (array[i] < array[i + 1])
            {
                isDecreasing = false; 
            }
            else if (array[i] > array[i + 1])
            {
                isIncreasing = false; 
            }
        }

        if(isIncreasing) 
        {
            return 1;
        }
        if(isDecreasing) 
        {
            return -1;
        } 
        else
        {
            return 0;
        }
    }

    public void Task_2_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here

        // create and use FindSequence(array, A, B); // 1 - increasing, 0 - no sequence,  -1 - decreasing
        // A and B - start and end indexes of elements from array for search
        answerFirst  = FindSequence(first, 0, first.Length - 1);
        answerSecond = FindSequence(second, 0, second.Length - 1);
        // end
    }

    static int[,] FindSequences1(int[] array, int A, int B)
    {
        int count = 0;
        for(int i = A; i < B; i ++)
        {
            for(int j = i + 1; j <= B; j ++)
            {
                if(FindSequence(array, i, j) != 0)
                {
                    count ++;
                }
            }
        }
        int[,] answer = new int[count,2];
        int index = 0;
        for(int i = A; i < B; i ++)
        {
            for(int j = i + 1; j <= B; j ++)
            {
                if(FindSequence(array, i, j) != 0)
                {
                    answer[index, 0] = i;
                    answer[index, 1] = j;
                    index ++;
                }
            }
        }
        return answer;
    }
    public void Task_2_28b(int[] first, int[] second, ref int[,] answerFirst, ref int[,] answerSecond)
    {
        // code here
        answerFirst = FindSequences1(first, 0, first.Length - 1);
        answerSecond = FindSequences1(second, 0, second.Length - 1);
        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a
        // A and B - start and end indexes of elements from array for search

        // end
    }

    static int[] FindMaxSequences2(int[,] array) 
    {
        //int maxi = -99999;
        int maxLength = -99999;
        int startIndex = -1;
        int endIndex = -1;

        for (int i = 0; i < array.GetLength(0); i++) 
        {
            // начальное знач и конечное
            int currentStart = array[i, 0];
            int currentEnd = array[i, 1];

            // текущая длина
            int currentLength = currentEnd - currentStart;

            if (currentLength > maxLength) 
            {
                maxLength = currentLength; //обновляем максимальную длину
                startIndex = currentStart;  // обновляем начальный индекс
                endIndex = currentEnd;      // обновляем конечный индекс
            }   
        }
        int[] max = new int[] {startIndex, endIndex};

        return max;
    }
    public void Task_2_28c(int[] first, int[] second, ref int[] answerFirst, ref int[] answerSecond)
    {
        // code here

        int[,] a = FindSequences1(first, 0, first.Length - 1);
        answerFirst = FindMaxSequences2(a);
        int[,] b = FindSequences1(second, 0, second.Length - 1);
        answerSecond = FindMaxSequences2(b);
        // use FindSequence(array, A, B); from Task_2_28a or entirely Task_2_28a or Task_2_28b
        // A and B - start and end indexes of elements from array for search

        // end
    }
    #endregion

    #region Level 3
    public void Task_3_1(ref double[,] firstSumAndY, ref double[,] secondSumAndY)
    {
        // code here

        // create and use public delegate SumFunction(x) and public delegate YFunction(x)
        // create and use method GetSumAndY(sFunction, yFunction, a, b, h);
        // create and use 2 methods for both functions calculating at specific x

        // end
    }

    public delegate void SortRowStyle(ref int[,] matrix,int rowIndex);

    static void SortAscending(ref int[,] matrix, int rowIndex) 
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
                if (matrix[rowIndex, j] > matrix[rowIndex, j + 1]) 
                {
                    int temp = matrix[rowIndex, j];
                    matrix[rowIndex, j] = matrix[rowIndex, j + 1];
                    matrix[rowIndex, j + 1] = temp;
                }
        }
    }

    static void SortDescending(ref int[,] matrix, int rowIndex) 
    {
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
            {
                if (matrix[rowIndex, j] < matrix[rowIndex, j + 1]) 
                {
                    int temp = matrix[rowIndex, j];
                    matrix[rowIndex, j] = matrix[rowIndex, j + 1];
                    matrix[rowIndex, j + 1] = temp;
                }
            }
        }
    }
    public void Task_3_2(int[,] matrix)
    {
        SortRowStyle sortStyle = default(SortRowStyle); 

        // code here
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            if (i % 2 == 0) 
            {
                sortStyle = SortAscending;
            }
            else 
            {
                sortStyle = SortDescending;
            }
            sortStyle(ref matrix,i);
        }
        // create and use public delegate SortRowStyle(matrix, rowIndex);
        // create and use methods SortAscending(matrix, rowIndex) and SortDescending(matrix, rowIndex)
        // change method in variable sortStyle in the loop here and use it for row sorting

        // end
    }

    public double Task_3_3(double[] array)
    {
        double answer = 0;
        // SwapDirection swapper = default(SwapDirection); - uncomment me

        // code here

        // create and use public delegate SwapDirection(array);
        // create and use methods SwapRight(array) and SwapLeft(array)
        // create and use method GetSum(array, start, h) that sum elements with a negative indexes
        // change method in variable swapper in the if/else and than use swapper(matrix)

        // end

        return answer;
    }

    public delegate int[] GetTriangle(int[,]matrix);

    static int[] GetUpperTriange(int[,] matrix)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                count ++;
            }
        }
        int[] array = new int[count];
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                array[index] = matrix[i,j]*matrix[i,j];
                index ++;
            }
        }
        return array;
    }

    static int[] GetLowerTriange(int[,] matrix)
    {
        int count = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = 0; j <= i; j++)
            {
                count ++;
            }
        }
        int[] array = new int[count];
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = 0; j <= i; j++)
            {
                array[index] = matrix[i,j]*matrix[i,j];
                index ++;
            }
        }
        return array;
    }

    static int GetSum(GetTriangle a, int[,] matrix)
    {
        int sum = 0;
        int[] array = a(matrix);
        for (int i = 0; i < array.Length; i++) {
            sum += array[i];
        }
        return sum;
    }
    public int Task_3_4(int[,] matrix, bool isUpperTriangle)
    {
        int answer = 0;

        // code here
        GetTriangle b;
        if (isUpperTriangle) 
        {
            b = GetUpperTriange;
        }
        else 
        {
            b = GetLowerTriange;
        }
        answer = GetSum(b, matrix);

        // create and use public delegate GetTriangle(matrix);
        // create and use methods GetUpperTriange(array) and GetLowerTriange(array)
        // create and use GetSum(GetTriangle, matrix)

        // end

        return answer;
    }

    public void Task_3_5(out int func1, out int func2)
    {
        func1 = 0;
        func2 = 0;

        // code here

        // use public delegate YFunction(x, a, b, h) from Task_3_1
        // create and use method CountSignFlips(YFunction, a, b, h);
        // create and use 2 methods for both functions

        // end
    }

    public delegate int FindElementDelegate(int[,] matrix);
    
    static int FindDiagonalMaxIndex1(int[,] matrix)
    {
        int max = -999999;
        int index = 0;
        for(int i = 0; i < matrix.GetLength(0); i ++)
        {
            if(matrix[i,i] > max)
            {
                max = matrix[i,i];
                index = i;
            }
        }
        return index;
    }

    static int FindFirstRowMaxIndex(int[,] matrix)
    {
        int max = -9999999;
        int indexrow = 0;
        for(int i = 0; i < matrix.GetLength(0); i ++)
        {
            for(int j = 0; j < matrix.GetLength(1); j ++)
            {
                if(matrix[i,j] > max)
                {
                    max = matrix[i,j];
                    indexrow = j;
                }
            }
        }
        return indexrow;
    }

    static void SwapColumns(ref int[,] matrix, FindElementDelegate first, FindElementDelegate second)
    {
        //int indexdiag = FindDiagonalMaxIndex1(matrix);
        //int indexrow = FindFirstRowMaxIndex(matrix);
        int indexdiag = first(matrix);
        int indexrow = second(matrix);
        for(int i = 0; i < matrix.GetLength(0); i ++)
        {
            int temp = matrix[i,indexdiag];
            matrix[i,indexdiag] = matrix[i,indexrow];
            matrix[i,indexrow] = temp; 
        }
    }
    public void Task_3_6(int[,] matrix)
    {
        // code here
        FindElementDelegate first;
        FindElementDelegate second;
        first = FindDiagonalMaxIndex1;
        second = FindFirstRowMaxIndex;
        SwapColumns(ref matrix,first,second);
        // create and use public delegate FindElementDelegate(matrix);
        // use method FindDiagonalMaxIndex(matrix) like in Task_2_3;
        // create and use method FindFirstRowMaxIndex(matrix);
        // create and use method SwapColumns(matrix, FindDiagonalMaxIndex, FindFirstRowMaxIndex);

        // end
    }

    public void Task_3_7(ref int[,] B, int[,] C)
    {
        // code here

        // create and use public delegate CountPositive(matrix, index);
        // use CountRowPositive(matrix, rowIndex) from Task_2_7
        // use CountColumnPositive(matrix, colIndex) from Task_2_7
        // create and use method InsertColumn(matrixB, CountRow, matrixC, CountColumn);

        // end
    }

    delegate int FindIndex(int[,] matrix);

    static int FindMaxBelowDiagonalIndex(int[,] matrix)
    {
        int max = -9999999;
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = 0; j <= i; j++)
            {
                if(matrix[i,j] > max)
                {
                    max = matrix[i,j];
                    index = j;
                }
            }
        }
        return index;
    }
    static int FindMinAboveDiagonalIndex(int [,] matrix)
    {
        int min = 9999999;
        int index = 0;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            for (int j = i; j < matrix.GetLength(1); j++)
            {
                if(matrix[i,j] < min)
                {
                    min = matrix[i,j];
                    index = j;
                }
            }
        }
        return index;
    }

    static int[,] RemoveColumn2(int[,] matrix, int columnIndex)
    {
        int indexarr = 0;
        int[,] newarr = new int[matrix.GetLength(0), matrix.GetLength(1) - 1];
        for(int j = 0; j < matrix.GetLength(1); j ++)
        {
            if(j == columnIndex)
            {
                continue;
            }
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                newarr[i, indexarr] = matrix[i, j];
            }
            indexarr++;
        }
        return newarr;
    }
    static int[,] RemoveColumns(int[,] matrix, FindIndex below, FindIndex above)
    {
        int down = below(matrix);
        int up = above(matrix);
        if (up > down) 
        {
            matrix = RemoveColumn2(matrix, up);
            matrix = RemoveColumn2(matrix, down);
        }
        else if (down > up) 
        {
            matrix = RemoveColumn2(matrix, down);
            matrix = RemoveColumn2(matrix, up);
        }
        else 
        {
            matrix = RemoveColumn2(matrix, down);
        }
        return matrix;
    }

    public void Task_3_10(ref int[,] matrix)
    {
        //FindIndex searchArea = default(FindIndex);
        FindIndex below = default(FindIndex);
        FindIndex above = default(FindIndex);
        below = FindMaxBelowDiagonalIndex;
        above = FindMinAboveDiagonalIndex;
        matrix = RemoveColumns(matrix, below, above);
        // code here

        // create and use public delegate FindIndex(matrix);
        // create and use method FindMaxBelowDiagonalIndex(matrix);
        // create and use method FindMinAboveDiagonalIndex(matrix);
        // use RemoveColumn(matrix, columnIndex) from Task_2_10
        // create and use method RemoveColumns(matrix, findMaxBelowDiagonalIndex, findMinAboveDiagonalIndex)

        // end
    }

    public void Task_3_13(ref int[,] matrix)
    {
        // code here

        // use public delegate FindElementDelegate(matrix) from Task_3_6
        // create and use method RemoveRows(matrix, findMax, findMin)

        // end
    }

    public delegate int GetNegativeArray(int[,] matrix, int index);
    
    static int GetNegativeCountPerRow(int[,] matrix,int rowIndex)
    {
        int count = 0;
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            if (matrix[rowIndex,j] < 0) 
            {
                count++;
            }
        }
        return count;
    }
    static int GetMaxNegativePerColumn(int [,] matrix, int colIndex) 
    {
        int max = -99999999;
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            if (matrix[i, colIndex] > max && matrix[i, colIndex] < 0) 
            {
                max = matrix[i, colIndex];
            }
        }
        return max;
    }

    static void FindNegatives(int[,] matrix, GetNegativeArray searcherRows, GetNegativeArray searcherCols, out int[] rows, out int[] cols)
    {
        rows = new int[matrix.GetLength(0)];
        cols = new int[matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            rows[i] = searcherRows(matrix, i);
        }

        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            cols[j] = searcherCols(matrix, j);
        }
    }

    public void Task_3_22(int[,] matrix, out int[] rows, out int[] cols)
    {

        rows = null;
        cols = null;

        // code here
        GetNegativeArray searcherRows;
        GetNegativeArray searcherCols;
        searcherRows = GetNegativeCountPerRow;
        searcherCols = GetMaxNegativePerColumn;
        FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);
        // create and use public delegate GetNegativeArray(matrix);
        // use GetNegativeCountPerRow(matrix) from Task_2_22
        // use GetMaxNegativePerColumn(matrix) from Task_2_22
        // create and use method FindNegatives(matrix, searcherRows, searcherCols, out rows, out cols);

        // end
    }

    public void Task_3_27(int[,] A, int[,] B)
    {
        // code here

        // create and use public delegate ReplaceMaxElement(matrix, rowIndex, max);
        // use ReplaceMaxElementOdd(matrix) from Task_2_27
        // use ReplaceMaxElementEven(matrix) from Task_2_27
        // create and use method EvenOddRowsTransform(matrix, replaceMaxElementOdd, replaceMaxElementEven);

        // end
    }

    public delegate bool IsSequence(int[] array, int left, int right);

    static bool FindIncreasingSequence(int[] array, int A, int B)
    {
        bool answer = false;
        for (int i = A; i < B; i ++) 
        {
            if(array[i] < array[i + 1])
            {
                answer = true;
            }
            else
            {
                answer = false;
                break;
            }
        }
        return answer;
    }

    static bool FindDecreasingSequence(int[] array, int A, int B)
    {
        bool answer = false;
        for (int i = A; i < B; i ++) 
        {
            if(array[i] > array[i + 1])
            {
                answer = true;
            }
            else
            {
                answer = false;
                break;
            }
        }
        return answer;
    }

    static int DefineSequence(int[] array, IsSequence findIncreasingSequence, IsSequence findDecreasingSequence)
    {
        if (findIncreasingSequence(array, 0, array.Length -1)) 
        {
            return 1;
        }
        if(findDecreasingSequence(array, 0, array.Length - 1)) 
        {
            return -1;
        }
        else 
        {
            return 0;
        }
    }
    public void Task_3_28a(int[] first, int[] second, ref int answerFirst, ref int answerSecond)
    {
        // code here
        IsSequence findIncreasingSequence;
        IsSequence findDecreasingSequence;

        findIncreasingSequence = FindIncreasingSequence;
        findDecreasingSequence = FindDecreasingSequence;
        answerFirst = DefineSequence(first, findIncreasingSequence, findDecreasingSequence);
        answerSecond = DefineSequence(second, findIncreasingSequence, findDecreasingSequence);
        // create public delegate IsSequence(array, left, right);
        // create and use method FindIncreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method FindDecreasingSequence(array, A, B); similar to FindSequence(array, A, B) in Task_2_28a
        // create and use method DefineSequence(array, findIncreasingSequence, findDecreasingSequence);

        // end
    }

    static int[] FindLongestSequence(int[] array, IsSequence sequence) 
    {
        int[] longest = new int[2];
        int maxLength = -1; 

        for (int startIndex = 0; startIndex < array.Length - 1; startIndex++) 
        {
            for (int endIndex = startIndex + 1; endIndex < array.Length; endIndex++) 
            {
                //образует ли текущая пара индексов последовательность
                if (sequence(array, startIndex, endIndex)) 
                {
                    // текущая длина
                    int currentLength = endIndex - startIndex;
                    if (currentLength > maxLength) 
                    {
                        maxLength = currentLength; // обнов макс длина
                        longest[0] = startIndex; //обнов нач инд
                        longest[1] = endIndex;   //обнов кон инд
                    }
                }
            }
        }

        return longest;
    }

    // static int[] FindMaxSequences2(int[,] array) 
    // {
    //     //int maxi = -99999;
    //     int maxLength = -99999;
    //     int startIndex = -1;
    //     int endIndex = -1;

    //     for (int i = 0; i < array.GetLength(0); i++) 
    //     {
    //         // начальное знач и конечное
    //         int currentStart = array[i, 0];
    //         int currentEnd = array[i, 1];

    //         // текущая длина
    //         int currentLength = currentEnd - currentStart;

    //         if (currentLength > maxLength) 
    //         {
    //             maxLength = currentLength; //обновляем максимальную длину
    //             startIndex = currentStart;  // обновляем начальный индекс
    //             endIndex = currentEnd;      // обновляем конечный индекс
    //         }   
    //     }
    //     int[] max = new int[] {startIndex, endIndex};

    //     return max;
    // }

    public void Task_3_28c(int[] first, int[] second, ref int[] answerFirstIncrease, ref int[] answerFirstDecrease, ref int[] answerSecondIncrease, ref int[] answerSecondDecrease)
    {
        // code here
        IsSequence findIncreasingSequence;
        IsSequence findDecreasingSequence;

        findIncreasingSequence = FindIncreasingSequence;
        findDecreasingSequence = FindDecreasingSequence;
        answerFirstIncrease = FindLongestSequence(first, findIncreasingSequence);
        answerFirstDecrease = FindLongestSequence(first, findDecreasingSequence);

        answerSecondIncrease = FindLongestSequence(second, findIncreasingSequence);
        answerSecondDecrease = FindLongestSequence(second, findDecreasingSequence);
        // end
        // create public delegate IsSequence(array, left, right);
        // use method FindIncreasingSequence(array, A, B); from Task_3_28a
        // use method FindDecreasingSequence(array, A, B); from Task_3_28a
        // create and use method FindLongestSequence(array, sequence);

        // end
    }
    #endregion
    #region bonus part

    public delegate double[,] MatrixConverter(double[,] matrix);

    static double[,] ToUpperTriangular(double[,] matrix) 
    {
        for(int i = 0; i <= matrix.GetLength(0) - 1; i ++)
        {
            //проходим по элементам ниже строки
            for(int j = i + 1; j <= matrix.GetLength(1) - 1; j ++)
            {
                //коэфф при умножении на которые обнуляются элементы
                //matrix[1,0](1) / matrix[0,0](2)
                double p = matrix[j, i] / matrix[i,i];
                //обновляю элементы j начиная с начала
                for(int k = 0; k <= matrix.GetLength(0) - 1; k ++)
                {   
                    //обнуляем нижние
                    //matrix[1,0](1) - (matrix[0,0](2) * 0.5) = 0
                    //matrix[1,1](-1) - (matrix[0,1](1) * 0.5) = -1.5
                    matrix[j,k] -= matrix[i,k] * p;
                }

            }
        }
        return matrix;
    }
    static double[,] ToLowerTriangular(double[,] matrix) 
    {
        for (int i = matrix.GetLength(0) - 1; i >= 0; i--) 
        {
            for (int j = i - 1; j >= 0; j--) 
            {
                double p = matrix[j, i] / matrix[i, i];
                for (int k = 0; k <= matrix.GetLength(0) - 1; k++) 
                {
                    //обнуляем верхние
                    matrix[j, k] -= matrix[i, k] * p;
                }
            }
        }
        return matrix;
    }

    static double[,] ToLeftDiagonal(double[,] matrix)
    {
        matrix = ToUpperTriangular(matrix);
        matrix = ToLowerTriangular(matrix);
        return matrix;
    }

    static double[,] ToRightDiagonal(double[,] matrix)
    {
        matrix = ToLowerTriangular(matrix);
        matrix = ToUpperTriangular(matrix);
        return matrix;
    }

    public double[,] Task_4(double[,] matrix, int index)
    {
        MatrixConverter[] mc = new MatrixConverter[4]; 

        mc[0] = new MatrixConverter(ToUpperTriangular);
        mc[1] = new MatrixConverter(ToLowerTriangular);
        mc[2] = new MatrixConverter(ToLeftDiagonal);
        mc[3] = new MatrixConverter(ToRightDiagonal);
        
        matrix = mc[index](matrix); 

        // code here

        // create public delegate MatrixConverter(matrix);
        // create and use method ToUpperTriangular(matrix);
        // create and use method ToLowerTriangular(matrix);
        // create and use method ToLeftDiagonal(matrix); - start from the left top angle
        // create and use method ToRightDiagonal(matrix); - start from the right bottom angle

        // end

        return matrix;
    }
    #endregion
}
