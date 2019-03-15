join : many strings to one

Join. The string.Join method combines many strings into one. 


              using System;

              class Program
              {
                  static void Main(String[] args)
                  {   
                      String w1 = "c";
                      String w2 = "c++";
                      String w3 = "java";
                      String w4 = "csharp";
                      String result = String.Join(',',w1,w2,w3,w4);//join(seperator, params array)
                      Console.WriteLine(result);
                  }
              }
      
              output : 
              c,c++,java,csharp
