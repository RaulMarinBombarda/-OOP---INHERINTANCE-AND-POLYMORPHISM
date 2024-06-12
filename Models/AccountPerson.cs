namespace AMST4_heranca.Models

{
    public class AccountPerson : Person
    {
        public AccountPerson()
        {
            Number = "1111";
            InterestRate = 1.02;
        }

        public double InterestRate { get; set; }
        public override void ShowBalance()
        {
            Balance = (Deposit - Withdraw) * InterestRate;
            Console.WriteLine($"Sua conta poupança de titular: {Name}");
            Console.WriteLine($"E de número: {Number}");
            System.Console.WriteLine($"Tem o saldo de {Balance} após o saque e rendimentos.");
        }
    }
}