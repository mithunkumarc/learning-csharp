> define Deconstruct() method

> get data from object and assign to local variables

        using System;
        namespace myfirstprogram{
            class Point{
                public int x;
                public int y;

                public void Deconstruct(out int x, out int y){
                    x = this.x;
                    y = this.y;
                }
            }
            public class MyProgram{
                public static void Main(String[] args){
                    Point p = new Point();
                    p.x = 10;
                    p.y = 20;
                    (int xvalue,int yvalue) = p;
                    Console.WriteLine(xvalue);
                    Console.WriteLine(yvalue); 
                }
            }
        }


        output : 
        10
        20
