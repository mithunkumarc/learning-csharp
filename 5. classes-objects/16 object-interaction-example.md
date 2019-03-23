
            using System;
            using bank;
            namespace bank{

            class ATM{
                public int dispenseMoney(ATMCard aTMCard){
                    var balance = 25000.00;
                    Console.WriteLine("reading atm card....");
                    if(aTMCard.cardNumber == "sbi123" && aTMCard.pin == "1234"){
                        Console.WriteLine("transaction started");
                        Console.WriteLine("enter amount to withdraw");
                        String temp_amount = Console.ReadLine();
                        int amount = int.Parse(temp_amount);
                        if(amount <= balance){
                            balance = balance - amount;
                            Console.WriteLine("transaction successfull, remaining balance is {0}",balance);
                            return 1;
                        }else{
                            Console.WriteLine("transaction failed, insufficient amount");
                            return -1;
                        }
                    }
                    return -1;
                }
            }

            class ATMCard{
                public String cardNumber;
                public String pin;
            }

            class Program{

                static void Main(String[] args){
                    ATMCard atmcard = new ATMCard();
                    atmcard.cardNumber = "sbi123";
                    atmcard.pin = "1234";
                    new ATM().dispenseMoney(atmcard);
                }



                }

            }

            reading atm card....
            transaction started
            enter amount to withdraw
            20000
            transaction successfull, remaining balance is 5000
