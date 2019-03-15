
        string st = "  This is an example string. ";

        // Call Trim instance method.
        // This returns a new string copy.
        st = st.Trim();
        
        
#### TrimEnd and TrimStart

            using System;
            class Program
            {
                static void Main()
                {
                    String word = "hello world....";
                    Console.WriteLine(word.TrimEnd('.'));
                    //output : hello world
                    word = "###hello world";
                    Console.WriteLine(word.TrimStart('#'));
                    //output : hello world
                }
            }
