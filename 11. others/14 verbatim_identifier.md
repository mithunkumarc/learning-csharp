@ : verbatim identifier used to treat escape sequences in string as normal string.
neutralize escape sequences , doesnt treats escape sequences in special way.

          using System;

          class Test{

              static void Main(String[] args){
                  String path = "c:\newfolder\newfile";
                  Console.WriteLine(path);
                  //output : 
                  //            c:
                  //            ewfolder
                  //            ewfile


                  String path_verbatim = @"c:\newfolder\newfile";
                  Console.WriteLine(path_verbatim);       
                  // ouput  :
                  //          c:\newfolder\newfile

              }
          }
