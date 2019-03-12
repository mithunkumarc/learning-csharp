named tuple :


                //named tuple
                var named_tuple = (first:1,second:2);
                Console.WriteLine(named_tuple.GetType());
                //System.ValueTuple`2[System.Int32,System.Int32]
                Console.WriteLine(named_tuple.Item1);//1
                Console.WriteLine(named_tuple.Item2);//2
                //or
                Console.WriteLine(named_tuple.first);//1
                Console.WriteLine(named_tuple.second);//2			
