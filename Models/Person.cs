namespace AMST4_heranca.Models
{
   public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid();
            Number = "0000";
            Name = "João Silva";
            Deposit = 1000;
            Withdraw = 100;
        }

        public virtual void ShowBalance()
        {
            Balance = Deposit - Withdraw;
            Console.WriteLine($"O saldo desta conta é: {Balance}");
        }
        public Guid Id { get; set; }

        public string Number { get; set; }
        public string Name { get; set; }
        public double CPForCNPJ { get; set; }
        public string Agency { get; set; }
        public int Account { get; set; }
        public double Balance { get; set; }
        public double Withdraw { get; set; }
        public double Deposit { get; set; }
    }
}