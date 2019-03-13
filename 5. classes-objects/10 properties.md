#### replacing getters and setters

            using System;
            namespace myspace{
                        
                  class Person{
                      private String name;
                      private int age;
                      
                      //constructor
                      // public Person(String name,int age){            
                      //     this.name = name;
                      //     this.age = age;        
                      // }
                      
                      //property for name
                      public String Name{
                          get{return this.name;}
                          set{this.name = value;}
                      }

                      //property for age
                      public int Age{
                          get{return this.age;}
                          set{this.age = value;}
                      }
                  }
                        
                public class TestControlStat{
                      static void Main(String[] args){        
                          Person person = new Person();
                          person.Name = "rajat";
                          person.Age = 25;
                          Console.WriteLine(person.Name);
                          Console.WriteLine(person.Age);
                      }
                }

            }
            
            output : 
            rajat
            25
