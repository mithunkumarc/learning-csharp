

        using System;
        public class TestLoop{
            public static void Main(String[] arguments){
                
                //casting : converting one type to another

                int i = 10;
                short s = (short)i;

                byte b = 1;
                int ib = b;
                long il = ib;
                //in the same way as long is base for all integers

                //object is base for all c# datatypes
                Object o = "hello world";
                String helloWorld = o as String;
                Console.WriteLine(helloWorld);


                BankEmployee bankEmployee = new BankEmployee();
                Employee e = bankEmployee as Employee;
                //BankEmployee bankEmployee1 = e as BankEmployee;

            }
        }
        class Employee{

        }
        class BankEmployee : Employee{

        }
