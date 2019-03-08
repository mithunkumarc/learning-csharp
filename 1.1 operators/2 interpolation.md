#### formatiing and interpolation

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


#### limiting number of decimals

                    using System;
                    class Test{    
                        static void Main(String[] args){        
                            Console.WriteLine(Math.PI);
                            Console.WriteLine($"{Math.PI:F3}");
                        }
                    }
                    3.14159265358979
                    3.142
                    
#### spaces 

                    using System;
                    class Test{    
                        static void Main(String[] args){      
                            //syntax : ${value,spaces}
                            //spaces takes numbers which includes data too
                            //+number indicate spaces on left
                            //-number indicate spaces on right
                            Console.WriteLine($"{"hello",-7}{"world",-8}program");//negetive , spaces on right        
                            Console.WriteLine($"rupees{12345,+10}");//positive, spaces on left
                        }
                    }

                    output : 
                    
                    hello  world   program
                    
                    rupees     12345
