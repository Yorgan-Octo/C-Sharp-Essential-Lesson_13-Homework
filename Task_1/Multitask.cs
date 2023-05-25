using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_1
{
    class Matrix
    {
        public static object key = new object(); 
        string literals = "QWERTYUIOPASDFGHJKLZXCVBNM123456789";
        Random random = new Random();   
        string[] matrix;     
        int numberColomn;    
        int upColomn = 0;    

        public Matrix(int par)  
        {
            Console.CursorTop = upColomn; 
            numberColomn = par;
        }
        public void MyMethod()   
        {
            int length = 0; 
            while (true)    
            {
                Thread.Sleep(random.Next(1, 10000));  
                matrix = new string[random.Next(3, 6)];         

                for (int k = 0; k <= 42; k++) 
                {
                    lock (key) 
                    {
                        for (int j = 0; j < (upColomn + 1) - matrix.Length; j++)
                        {
                            if (upColomn != 0 && upColomn >= matrix.Length)
                            {
                                Console.CursorLeft = numberColomn;
                                Console.CursorTop = j;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine(" ");
                            }
                            if (j + 1 >= (upColomn + 1) - matrix.Length)
                            {
                                upColomn = j + 1;
                            }
                        }
                        length = 0;
                        if (upColomn >= 39)   
                        {
                            if (matrix.Length - 1 == 0)
                            {
                                upColomn = 0;
                                break;
                            }
                            matrix = new string[matrix.Length - 1];
                            for (int h = 0; h < matrix.Length; h++)          
                            {
                                matrix[h] = literals[random.Next(35)].ToString();
                            }
                        }
                      
                        for (int i = 0; i < matrix.Length; i++)
                        {
                            Console.CursorLeft = numberColomn;
                            Console.CursorTop = upColomn++;

                     
                            if (length == matrix.Length - 1)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else if (length == matrix.Length - 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            matrix[i] = literals[random.Next(35)].ToString();
                            Console.Write(matrix[i]);
                            length++;

                        }
                        Thread.Sleep(5);
                    }
                }
            }
        }
    }
}
