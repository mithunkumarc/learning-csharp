similar to getType

getType called on object but typeof takes type/class name as parameter

        var i = 10;              
        Console.WriteLine(i.GetType());//System.Int32
        //same as        
        Console.WriteLine(typeof(int));//System.Int32        

#### typeof on primitives

        Console.WriteLine(typeof(byte));//System.Byte
        
        Console.WriteLine(typeof(bool));//Sytstem.Boolean
        
        Console.WriteLine(typeof(short));//System.Int16
        Console.WriteLine(typeof(int));//System.Int32
        Console.WriteLine(typeof(long));//System.Int64
        
        Console.WriteLine(typeof(float));//System.Single
        Console.WriteLine(typeof(double));//System.Double
       
        Console.WriteLine(typeof(char));//System.Char
        
        
        
