namespace AMST4_heranca.Models
{
    public class BusinessPerson : Person
    {
        public BusinessPerson()
        {
            SpecialRate = 0.9;
            Number = "2222";
        }
        public double SpecialRate { get; set; }

        public override void ShowBalance()
        {
            Balance = (Deposit - Withdraw) * SpecialRate;
            Console.WriteLine($"Sua conta corporativa de titular: {Name}");
            Console.WriteLine($"E de número: {Number}");
            System.Console.WriteLine($"Tem o saldo de {Balance} após o saque e juros.");
        }

    }
}