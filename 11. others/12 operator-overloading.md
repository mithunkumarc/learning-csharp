#### customising operator oveloading
#### example : using + operator to add scores of two player objects


          using System;
          public class Player{
              public int score;
              
              //defining + operator
              public static int operator +(Player p1, Player p2){
                  //must be static and public        
                  return p1.score + p2.score;
              }
          }
          public class Test{
              static void Main(){
                  Player p1 = new Player();
                  p1.score = 100;
                  Player p2 = new Player();
                  p2.score = 100;
                  int totalScore = p1 + p2;
                  Console.WriteLine($"the total score is {totalScore}");   
              }    
          }
          
          output : the total score is 200
