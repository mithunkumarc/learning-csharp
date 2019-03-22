          
          using System;
          using System.Collections.Generic;
          class Test{
              static void Main(String[] args){
                  //creating captcha : it consists of two random uppercase , lowercase and digits


                  //creating random object
                  Random random = new Random();

                  //uppercase letters
                  char[] uppercase_letters = {'A','B','C','D','E','F','G','H','I','J','K','L'
                  ,'M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

                  //lowercase letters
                  char[] lowercase_letters = {'a','b','c','d','e',
                  'f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

                  //digits
                  char[] digits = {'0','1','2','3','4','5','6','7','8','9'};

                  //temp_captcha array contains : first two random uppercase, next two randoer lowercase then two random
                  char[] temp_captcha = new char[6];
                  temp_captcha[0] = uppercase_letters[random.Next(0,uppercase_letters.Length-1)];
                  temp_captcha[1] = uppercase_letters[random.Next(0,uppercase_letters.Length-1)];
                  temp_captcha[2] = lowercase_letters[random.Next(0,lowercase_letters.Length-1)];
                  temp_captcha[3] = lowercase_letters[random.Next(0,lowercase_letters.Length-1)];
                  temp_captcha[4] = digits[random.Next(0,digits.Length-1)];
                  temp_captcha[5] = digits[random.Next(0,digits.Length-1)];

                  //Console.WriteLine(new String(temp_captcha));        


                  //using hashset to store unique elements 
                  HashSet<char> charsSet = new HashSet<char>();
                  bool flag = true;
                  while(flag){
                      charsSet.Add(temp_captcha[random.Next(0,temp_captcha.Length)]);
                      if(charsSet.Count >= temp_captcha.Length){
                          flag = false;
                      }            
                  }

                  // reading characters from hashset and 
                  String final_captcha = null;
                  var enumerator = charsSet.GetEnumerator();
                  while(enumerator.MoveNext()){
                      final_captcha = final_captcha + enumerator.Current;
                  }
                  Console.WriteLine(final_captcha);


                  } 

              }


