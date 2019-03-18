
          using System;
          class Program
          {
              static void Main()
              {
                  // This DateTime is constructed with an instance constructor.
                  // ... We write it to the console.
                  // ... If this is today, the second line will be True.
                  DateTime value = new DateTime(2019, 3, 18);
                  Console.WriteLine(value);
                  Console.WriteLine(value == DateTime.Today);
                  Console.WriteLine($"todays date {DateTime.Today}");
              }
          }
          
          
          
          
#### exploring time and date

                using System;

                class Program
                {
                    static void Main()
                    {
                        Console.WriteLine($"todays date {DateTime.Today}");
                        Console.WriteLine($"{DateTime.Today.Date}");
                        Console.WriteLine($"{DateTime.Today.Date.Day}");
                        Console.WriteLine($"{DateTime.Today.Date.Month}");//month number
                        Console.WriteLine($"{DateTime.Today.Year}");
                        Console.WriteLine($"{DateTime.Now}");//time
                        Console.WriteLine($"{DateTime.Now.TimeOfDay}");//time
                        Console.WriteLine("{0:HH:mm:ss}",DateTime.Now);//24 hours format, hour minute second
                        Console.WriteLine("{0:hh:mm:ss}",DateTime.Now);//12 hours format, hour minute second
                        //Console.WriteLine(DateTime.Now.ToString("hh:mm"));//12 hours format



                    }
                }
