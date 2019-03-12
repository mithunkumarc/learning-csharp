#### only position 

  
        Decimal pricePerOunce = 17.36m;
        String s = String.Format("The current price is {0} per ounce.",
                                 pricePerOunce);
        Console.WriteLine(s);
        // Result: The current price is 17.36 per ounce.


#### currency 

            Decimal pricePerOunce = 17.36m;
			      CultureInfo.CurrentCulture = new CultureInfo("en-IN", false);
            String s = String.Format("The current price is {0:C3} per ounce.",pricePerOunce);
            Console.WriteLine(s);

            output : The current price is ₹ 17.360 per ounce.
            
            
            
#### incomplete            
