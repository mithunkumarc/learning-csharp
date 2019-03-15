reads character by character from string


              using System;

              class Program
              {
                  static void Main()
                  {
                      // Input string.
                      string val = "dotnet";
                      // Get enumerator.
                      CharEnumerator e = val.GetEnumerator();
                      // Use in loop.
                      while (e.MoveNext())
                      {
                          char c = e.Current;
                          Console.WriteLine(c);
                      }
                  }
              }
