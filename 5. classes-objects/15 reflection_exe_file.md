#### example : creating instance of class from anther assembly(exe) file : usefull to test accessmodifiers

#### also : example for reading class from another assembly

#### lib.cs

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
              
              csc lib.cs 
              lib.exe generated
              
              
#### client.cs

            using System;
            using System.Reflection;
            //using System.Activator;
            namespace receptor{

                public class Receptor{
                    static void Main(String[] args){
                        //reading exe file
                        Assembly testAssembly = Assembly.LoadFile(@"/home/mitun/Documents/cs/lib.exe");
                        Type providerType = testAssembly.GetType("first.Provider");            
                        object providerInstance = Activator.CreateInstance(providerType);
                        MethodInfo methodInfo = providerType.GetMethod("dostuff");//method name : dostuff
                        object[] s = {};//no parameters for method dostuff;
                        var result = methodInfo.Invoke(providerInstance, s);

                    }
                }
            }
            
            csc client.cs
            mono client.exe
            output : helloworld
