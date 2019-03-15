#### initializing without invoking constructor

> a new way to initialize an object of a class or collection. 
> Object initializers allow you to assign values to the fields or properties at the time of 
> creating an object without invoking a constructor. 

            using System;
            class Person{
                public String Name{set; get;}
                public int ID{ set; get;}
            }
            class Program
            {
                static void Main(String[] args){           
                    Person p = new Person(){
                        Name = "ranjit",
                        ID = 12
                    };
                    Console.WriteLine(p.Name);
                    Console.WriteLine(p.ID);
                }
            }
            //output :  
            //ranjit
            //12
