#### by default each cs file is compiled to single .exe file

#### creating single exe file from multiple .cs files

      1. all api classes covert to dll (may be use *.cs to .dll)
      2. combine compiled class of main method with dll files to get new .exe file
      3. execute .exe file


#### example

#### lib.cs : as api class

        using System;
        namespace first{
            public class Provider{
                public void dostuff(){
                    Console.WriteLine("hello world");
                }
            }
        }

        command to convert to dll : csc /t:library /out:lib.dll lib.cs



#### client.cs : class with Main method

        using System;
        using first;
        namespace receptor{

            public class Receptor{
                static void Main(String[] args){
                    Provider p = new Provider();
                    p.dostuff();
                }
            }
        }
 
 

        command to create exe of main class with dll file : 
        csc /reference:lib.dll /t:exe /out:MyProgram.exe client.cs


#### finally execute : MyProgram

        mono MyProgram.exe



#### source : 

        https://stackoverflow.com/questions/14728422/c-sharp-importing-class-into-another-class-doesnt-work
        csc /t:library /out:lib.dll lib.cs
        csc /reference:lib.dll /t:exe /out:MyProgram.exe client.cs
