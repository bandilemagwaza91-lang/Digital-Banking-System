    static void Main(string[] args)
    {
        Console.WriteLine("Enter your Account Holder name ");
        string username =Console.ReadLine();

        Random rand = new Random();
        long accountNumber = (long)(rand.NextDouble() * 9000000000L) + 1000000000L;
       
        BankAccount accountdetails = new BankAccount(username, accountNumber, 0 );

        accountdetails.DisplayAccountHoldr();
        accountdetails.DisplayAccountNumber();
        accountdetails.DisplayBalance();

        

        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine("1.Deposit\n 2.Deposit with Bonus\n 3.Withdraw\n 4.Check Balance\n 5.Exit");

             string  userInput= Console.ReadLine();

            int number;
              int.TryParse(userInput, out number);

            if (number == 1)
            {
                Console.WriteLine("Please enter the Amount you want to deposit ");
                int amount = int.Parse(Console.ReadLine());
                BankAccount.
            }
            else if (number == 2)
            {
            }
            else if (number == 3)
            {

            }
            else if (number == 4)
            {

            }
            else if (number == 5)
            { 
            } 


          i++;
        }


        
        Console.ReadKey();
    }
}
class BankAccount
{
    public string accountholder;
    public long accountNumber;
    private int balance;

    public BankAccount(string accountholder, long accountNumber , int balance )
    {
    
     this.accountholder=accountholder;
     this.accountNumber =accountNumber;
     this.balance = balance;
        return;
    }
    public void Deposit()
    {
        Console.WriteLine(accountholder + " your Account was created successfully ");
    }
    public void Deposit()
    {
        Console.WriteLine("your account number is " + accountNumber);
    }
    public void withdraw()
    {
        Console.WriteLine("your Account Balance is " + balance);
        return;
    }
    public void checkBalance()
    { 
        return;
    }
