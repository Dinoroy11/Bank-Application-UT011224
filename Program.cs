using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Bankapplication
{
    internal class Program
    {
        class Bankaccount() 
        { 
            public string accountholder { get; set; }
            public int accountnumber { get; set; }
            private decimal accountbalance { get; set; }

        }


        public void deposit(decimal amount)
        {

            if (amount > 0)
            {
                balance = balance + amount;

                Console.WriteLine("deposit successfully");
                Console.writeline("updated balance : " + balance);
            }
            else
            {
                Console.WriteLine("invaild deposit amount");
            }
            break;
        }

        public void withrowal(decimal amount)
        {

            if (amount > 0)
            {
                if (amount <= balance)
                {
                    balance = balance - amount;

                    Console.WriteLine("withdrawal successfully");
                    Console.WriteLine("remaining balance : " + balance);
                }
                else
                {
                    Console.WriteLine("insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("invaild withrowal amount");
            }
            break;
        }
        }


        static void Main(string[] args)
        { 
            
            
            Bankaccount bankaccount = new Bankaccount();
            bankaccount.accountholder = "Pp";
            bankaccount.accountnumber = 112250;
            bankaccount.accountbalance = 1000;

            Console.WriteLine(bankaccount.accountholder);
            Console.WriteLine(bankaccount.accountnumber;
            Console.WriteLine(bankaccount.accountbalance);


            //part1
            //    Console.WriteLine("ABC bank");
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine("welcome to ABC bank");
            //    part2
            //    string bankname = "ABC bank";
            //   Console.WriteLine(bankname);

            //    string accountholdername = "den";
            //    Console.WriteLine(accountholdername);

            //    int accountnumber = 11223344;
            //    Console.WriteLine(accountnumber);

            //    int accountbalance = 100000;
            //    Console.WriteLine(accountbalance);

            //part3
            //string accountholdername = "den";
            //Console.WriteLine($"account holder name is {accountholdername}");


            //int accountnumber = 1122233;
            //Console.WriteLine($"account number is {accountnumber}");

            //int accountbalance = 100000;
            //Console.WriteLine($"account balance is {accountbalance}");

            //Console.WriteLine("enter your opening balance");
            // double openingbalance = double.Parse (Console.ReadLine());
            // Console.WriteLine($"your opening balance is {openingbalance}" );

            //part4
            // string name = "Pp";
            //int accountnumber = 1234567890;
            //int accountbalance = 500;
            //Console.Write($"name is {name}   ");
            //Console.Write($"account number {accountnumber}  ");
            //decimal accountbalance = 484848.566444m;
            //Console.Write($"balance : {accountbalance:f2}");

            //part5
            //Console.WriteLine("====Bank menu====");
            //Console.WriteLine("1.view account");
            //Console.WriteLine("2.check balance");
            //Console.WriteLine("3.deposit");
            //Console.WriteLine("4.withdraw");
            //Console.WriteLine("5.exit");

            //Console.Write("enter your choice:");
            //int choice = int.Parse(Console.ReadLine());

            //if (choice == 1)
            //{
            //    Console.WriteLine("view account");
            //}
            //else if (choice == 2)
            //{
            //    Console.WriteLine("check balance");
            //}
            //else if (choice == 3)
            //{
            //    Console.WriteLine("deposit");
            //}
            //else if (choice == 4)
            //{
            //    Console.WriteLine("withdraw");
            //}
            //else if
            //{
            //    Console.WriteLine("exit");
            //}
            //else
            //{
            //    Console.WriteLine("invaild choice");
            //}

            //part6
            //    switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("viewing account");
            //        break;
            //    case 2:
            //        Console.WriteLine("check balance");
            //        break;
            //    case 3:
            //        Console.WriteLine("deposit");
            //        break;
            //    case 4:
            //        Console.WriteLine("withdraw");
            //        break;
            //    case 5:
            //        Console.WriteLine("exit");
            //        break;
            //    default:
            //        Console.WriteLine("invaild choice");
            //        break;
            //}

            //part7 and part8
            //int choice;
            //double balance = 500;
            //bool running = true;

            //while (running)
            //{

                switch (choice)
               {
                    case 1:
                       Console.WriteLine("viewing account");
                        break;
                   case 2:
                       Console.WriteLine("check balance");
                        Console.WriteLine("current balance:" + balance);
                        break;
                    case 3:
                       
                        Console.WriteLine("enter your deposit amount");
                    decimal dep = Convert.ToDecimal(Console.ReadLine());

                    deposit(dep);
                      break;
                   case 4:
                        
                       Console.WriteLine("enter your withdrawal amount");
                    decimal wid = Convert.ToDecimal(Console.ReadLine());
                    bool success = withrowal(wid);

                    if (success)
                    {
                        Console.WriteLine("remaining balance : " + balance);

                    }
                    break;
                    case 5:
                        Console.WriteLine("exit");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("invaild choice");
                       break;
                }
            //}

            // part 9
            /*
                        int choice;

                        do
                        {
                            Console.Clear();
                            switch (choice)
                            {
                                case 1:
                                    Console.WriteLine("viewing account");
                                    break;
                                case 2:
                                    Console.WriteLine("check balance");
                                    break;
                                case 3:
                                    Console.WriteLine("deposit");
                                    break;
                                case 4:
                                    Console.WriteLine("withdraw");
                                    break;
                                case 5:
                                    Console.WriteLine("exit");
                                    break;
                                default:
                                    Console.WriteLine("invaild choice");
                                    break;
                            }
                            if (choice != 5) 
                            {
                                Console.ReadKey();
                            }
                        }
                        while (choice != 5);


                        */

            //part10
            //welcomemessage();

            //accountdetails();

            //menudispaly();

            //double balance = 500;
            //bool running = true;

            //while (running)
            //{

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("viewing account");
            //            break;
            //        case 2:
            //            Console.WriteLine("check balance");
            //            Console.WriteLine("current balance:" + balance);
            //            break;
            //        case 3:
            //            deposit();
            //        case 4:
            //            withdrawal();
            //        case 5:
            //            Console.WriteLine("exit");
            //            running = false;
            //            break;
            //        default:
            //            Console.WriteLine("invaild choice");
            //            break;

            //            Console.ReadKey();




            //    }
            //}

            //static void welcomemessage()
            //{
            //    Console.WriteLine("welcome to ABC bank");
            //}

            //static void menudispaly()
            //{
            //    Console.WriteLine("====Bank menu====");
            //    Console.WriteLine("1.view account");
            //    Console.WriteLine("2.check balance");
            //    Console.WriteLine("3.deposit");
            //    Console.WriteLine("4.withdraw");
            //    Console.WriteLine("5.exit");
            //}

            //static void accountdetails()
            //{
            //    string name = "Pp";
            //    int accountnumber = 1234567890;
            //    int accountbalance = 500;
            //    Console.Write($"name is {name}   ");
            //    Console.Write($"account number {accountnumber}  ");
            //    decimal accountbalance = 484848.566444m;
            //    Console.Write($"balance : {accountbalance:f2}");
            //}

            //static void deposit()
            //{
            //    Console.WriteLine("deposit");
            //    Console.WriteLine("enter your deposit amount");

            //    double amount = double.Parse(Console.ReadLine());

            //    if (amount > 0)
            //    {
            //        balance = balance + amount;

            //        Console.WriteLine("deposit successfully");
            //        Console.writeline("updated balance : " + balance);
            //    }
            //    else
            //    {
            //        Console.WriteLine("invaild deposit amount");
            //    }
            //    break;
            //}

            //static void withdrawal()
            //{
            //    Console.WriteLine("withdraw");
            //    Console.WriteLine("enter your withdrawal amount");

            //    if (amount > 0)
            //    {
            //        if (amount <= balance)
            //        {
            //            balance = balance - amount;

            //            Console.WriteLine("withdrawal successfully");
            //            Console.WriteLine("remaining balance : " + balance);
            //        }
            //        else
            //        {
            //            Console.WriteLine("insufficient balance");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("invaild withrowal amount");
            //    }
            //    break;
            //}

            double balance = 1000;

            List<string> transactions = new List<string>();


            double deposit = 500;
            balance += deposit;
            transactions.Add("deposited" + deposit);


            double withdraw = 500;
            balance -= withdraw;
            transactions.Add("withdrawal" + withdraw);

            Console.WriteLine("current balance:" + balance);

            Console.WriteLine("transaction history:");

            if (transactions.Count == 0)
            {
                Console.WriteLine(" no transactions yet");
            }
            else
            {
                foreach (string item in transactions)
                {
                    Console.WriteLine(item);
                }
            }
            

            












        }
    }
