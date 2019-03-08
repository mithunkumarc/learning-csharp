

          class Test{    
              static void Main(String[] args){        
                  //composite formatting
                  //index of placeholder is important, starts with zero    
                  Console.WriteLine("current time is {0}",DateTime.Now.TimeOfDay);
                  //string interpolation : use $ before string
                  Console.WriteLine($"current time is {DateTime.Now.TimeOfDay}");   
              }
          }
          
          output : 
          
          current time is 21:39:18.2386740
          current time is 21:39:18.2641460
