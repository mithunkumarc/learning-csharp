

          using System;
          class Program{
              static void Main(string[] args){
                  var numbers = new []{100,1,3,2,3,4,1,4};
                  Array.Sort(numbers);
                  foreach(var number in numbers){
                      Console.WriteLine(number);
                  }
              }
          }
