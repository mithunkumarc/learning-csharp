default arguments takes as string

        using System;
        class test{

            public static void Main(String[] args){
                Console.WriteLine($"number of arguments {args.Length}");
                Console.WriteLine("*********");
                foreach(var arg in args){
                    Console.WriteLine(arg);
                }

            }
        }

        output : 
          csc type.cs
          mono type.exe 1 2 3
          
          number of arguments 3
          *********
          1
          2
          3
          
          
#### parseInt
  
          using System;
          class test{

              public static void Main(String[] args){

                  var i  = Int32.Parse(args[0]);
                  Console.WriteLine(i * i);
              }
          }


          csc type.cs
          mono type.exe 5
          
          25
