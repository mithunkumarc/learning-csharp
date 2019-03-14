#### Determines whether an object is of a certain type.

            using System;
            public class TestLoop{
                public static void Main(String[] arguments){
                    var i = 10;
                    //check whether i is int 
                    Console.WriteLine(i is int);  //true

                    var e = new Employee();
                    Console.WriteLine(e is Customer); //false

                }
            }
            class Employee{

            }
            class Customer{

            }
