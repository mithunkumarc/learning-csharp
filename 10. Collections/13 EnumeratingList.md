before using IEnumerable as type , check whether class implements IEnumerable or not

        IEnumerable<int> numbers = new List<int>(){13,46,78,95,21,45};        
        Test test = new Test();
        foreach(var number in numbers){
            Console.WriteLine(number);
        }         
        
