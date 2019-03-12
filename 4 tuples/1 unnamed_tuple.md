#### unnamed tuple : no names for values
			
      
        var unnamed_tuple = (1,2);
        Console.WriteLine(unnamed_tuple.GetType());
        //System.ValueTuple`2[System.Int32,System.Int32]
        Console.WriteLine(unnamed_tuple.Item1);//1
        Console.WriteLine(unnamed_tuple.Item2);//1
