decides wheter var can have null value or not

        using System;
        class Test{
            static void Main(String[] args){
                Person canbenull = null;//no error
                Person? cantbenull = null;//error cant be null
            }
        }
        class Person{

        }
