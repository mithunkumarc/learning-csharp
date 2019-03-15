#### Func : has return value , whereas Action has no return value

          using System;

          class Program
          {
              //action has no return value
              static void Main(String[] args){           

                      Action<int> printNumber = i => Console.WriteLine(i);
                      printNumber(10);

                      int result = 0;
                      Action<int,int> add = (x,y) => result = x + y;
                      add(10,30);
                      Console.WriteLine(result);

              }
          } 
