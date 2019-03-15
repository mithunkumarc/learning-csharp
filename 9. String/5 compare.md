####  The program shows three comparison methods on the string type. 
#### The Compare and CompareOrdinal methods are static, while CompareTo is an instance method.

            using System;

            class Program
            {
                static void Main()
                {
                    string a = "a";
                    string b = "b";

                    int c = string.Compare(a, b);
                    Console.WriteLine(c);

                    c = string.CompareOrdinal(b, a);
                    Console.WriteLine(c);

                    c = a.CompareTo(b);
                    Console.WriteLine(c);

                    c = b.CompareTo(a);
                    Console.WriteLine(c);
                }
            } 

            Output

            -1       (This means a is smaller than b)
            1        (This means b is smaller than a)
            -1
            1

