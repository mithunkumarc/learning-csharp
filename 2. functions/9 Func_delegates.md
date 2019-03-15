
            using System;

            class Program
            {
                public delegate TResult Func<in T, out TResult>(T arg);
                public delegate TResult Func<in T1, in T2,out TResult>(T1 arg1,T2 arg2);
                public delegate TResult Func<in T1, in T2, in T3 , out TResult>(T1 arg1,T2 arg2,T3 arg3);
                static void Main(String[] args){           

                    Func<int,String> square = number => $"the square of {number} is {number * number}";
                    Console.WriteLine(square(10));

                    Func<int,int,int> add = (x,y) => x + y;
                    Console.WriteLine(add(10,10));

                    Func<int,int,int,float> average = (x,y,z) => (float)(x+y+z)/3;
                    Console.WriteLine(average(4,6,9));

                }
            }
