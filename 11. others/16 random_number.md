

          using System;
          namespace receptor{
              public class TestRandom{
                  static void Main(String[] args){
                      //generate random number between 1 and 30
                      Console.WriteLine(new Receptor().getRandomNumber(1,30));                
                  }
                  public int getRandomNumber(int start,int end){
                      return new Random().Next(start,end);
                  }
              }    
          }
