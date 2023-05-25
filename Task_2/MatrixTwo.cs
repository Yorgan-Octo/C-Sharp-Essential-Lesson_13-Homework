using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    internal class MatrixTwo
    {
        public static object key = new object(); 
        string literals = "QWERTYUIOPASDFGHJKLZXCVBNM123456789";
        Random random = new Random();   
        string[] matrixOne;      
        string[] matrixTwo;       
        int numberColomn;     
        int upColomn = 0;      
        int upColomnTwo = 0;
        public MatrixTwo(int par)  
        {
            Console.CursorTop = upColomn;  
            numberColomn = par;  
        }
        public void MyMethod()   
        {
            int lengthOne = 0; 
            int lengthTwo = 0; 
            int indentThread = 0;  
            bool right = true;     

            while (true)    
            {
                Thread.Sleep(random.Next(1, 10000));   
                matrixOne = new string[random.Next(3, 6)];           
                matrixTwo = matrixOne;                               
                indentThread = random.Next(10, 15);

                for (int k = 0; k <= 57; k++)  
                {
                    lock (key) 
                    {
                        if (right != false)
                        {
                            for (int j = 0; j < (upColomn + 1) - matrixOne.Length; j++)  
                            {
                                if (upColomn != 0 && upColomn >= matrixOne.Length)
                                {
                                    Console.CursorLeft = numberColomn;
                                    Console.CursorTop = j;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine(" ");
                                }
                                if (j + 1 >= (upColomn + 1) - matrixOne.Length)
                                {
                                    upColomn = j + 1;
                                }
                            }
                        }

                        for (int j = 0; j < (upColomnTwo + 1) - matrixTwo.Length; j++)  
                        {
                            if (upColomnTwo != 0 && upColomnTwo >= matrixTwo.Length)
                            {
                                Console.CursorLeft = numberColomn;
                                Console.CursorTop = j;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine(" ");
                            }
                            if (j + 1 >= (upColomnTwo + 1) - matrixTwo.Length)
                            {
                                upColomnTwo = j + 1;
                            }
                        }
                        lengthOne = 0;
                        lengthTwo = 0;

                        if (right != false)
                        {
                            if (upColomn >= 39)    
                            {
                                if (matrixOne.Length - 1 == 0)
                                {
                                    upColomn = 0;
                                    right = false;  
                                    continue;
                                }
                                matrixOne = new string[matrixOne.Length - 1];
                                for (int h = 0; h < matrixOne.Length; h++)           
                                {
                                    matrixOne[h] = literals[random.Next(35)].ToString();
                                }
                            }
                        }

                        if (upColomnTwo >= 39)    
                        {
                            if (matrixTwo.Length - 1 == 0)
                            {
                                upColomnTwo = 0;
                                right = true;    
                                break;
                            }
                            matrixTwo = new string[matrixTwo.Length - 1];
                            for (int h = 0; h < matrixTwo.Length; h++)            
                            {
                                matrixTwo[h] = literals[random.Next(35)].ToString();
                            }
                        }


                        if (right != false)
                        {
                            for (int i = 0; i < matrixOne.Length; i++)
                            {
                                Console.CursorLeft = numberColomn;
                                Console.CursorTop = upColomn++;

                               
                                if (lengthOne == matrixOne.Length - 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (lengthOne == matrixOne.Length - 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                                matrixOne[i] = literals[random.Next(35)].ToString();
                                Console.Write(matrixOne[i]);
                                lengthOne++;
                            }
                        }


                       
                        if (Console.CursorTop >= indentThread)
                        {
                            for (int i = 0; i < matrixTwo.Length; i++)
                            {
                                Console.CursorLeft = numberColomn;
                                Console.CursorTop = upColomnTwo++;

                            
                                if (lengthTwo == matrixTwo.Length - 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else if (lengthTwo == matrixTwo.Length - 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                                }
                                matrixTwo[i] = literals[random.Next(35)].ToString();
                                Console.Write(matrixTwo[i]);
                                lengthTwo++;
                            }
                        }

                        Thread.Sleep(5);
                    }
                }
            }
        }
    }
}
