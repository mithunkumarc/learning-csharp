

          using System;

          class Program
          {
              static void Main()
              {
                  const string input = "key tool";
                  Console.WriteLine("::BEFORE::");
                  Console.WriteLine(input);

                  // Replace word (and following space) with a new word.
                  // ... We assign to the Replace method's result.
                  string output = input.Replace("key ", "keyword ");
                  Console.WriteLine("::AFTER::");
                  Console.WriteLine(output);
              }
          }
          
          ::BEFORE::
          key tool
          ::AFTER::
          keyword tool
