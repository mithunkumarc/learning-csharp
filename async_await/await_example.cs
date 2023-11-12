// See https://aka.ms/new-console-template for more information
using System;
namespace helloworld
{
    public class Program 
    {
        static void Main(string[] args) {
            callMethod();//B : no await here , next statement will be executed, it will not wait for callMethod() to finish
            Console.WriteLine("end mail method");  
        }

         public static async void callMethod()
        {
            await Method1();//A : once it gets control from Method1 , it returns control to caller of this function(B)
            // since control returned to caller of this function, below statement wait for method1() to finish
            Console.WriteLine("after call method");
        }

        /*
            await is not meant for blocking 
            it is meant for return control to caller since task will take time to complete.
        */
        public static async Task<int> Method1()
        {
            int count = 0;
            // await return control to caller of this function(A), but continue to execute remaining statement parallel
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    count += 1;
                }
            });
            return count;
        }
        }
}

/*
output : 
end mail method
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
 Method 1
after call method
*/
