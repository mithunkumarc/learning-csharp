#### example :  creating instance from dll file

#### lib.cs : converted to dll

        using System;
        namespace first{
            public class Provider{
                public void dostuff(){
                    Console.WriteLine("hello world");
                }
                static void Main(String[] args){

                }
            }
        }
        
         command >> csc /t:library /out:lib.dll lib.cs          //lib : source file name
         
#### client.cs : Main method

        using System;
        using System.Reflection;
        namespace receptor{

            public class Receptor{
                static void Main(String[] args){
                    //reading file
                    Assembly testAssembly = Assembly.LoadFile(@"/home/mitun/Documents/cs/lib.dll");
                    Type providerType = testAssembly.GetType("first.Provider");            
                    object providerInstance = Activator.CreateInstance(providerType);
                    MethodInfo methodInfo = providerType.GetMethod("dostuff");//picking method name
                    object[] s = {};//no parameters for method dostuff;
                    var result = methodInfo.Invoke(providerInstance, s); //result : void : output : helloworld from dostuff
          
                }
            }
        }
        
        
         csc client.cs
         mono client.exe
         hello world
         
         
