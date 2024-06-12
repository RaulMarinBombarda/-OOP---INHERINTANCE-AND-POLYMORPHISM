using System;
using AMST4_heranca.Models;

string SelectedAccount = "";

Console.WriteLine("Bem-vindo ao menu de saque do banco AMS!");
Console.WriteLine("Digite '1' para sacar de sua conta poupança.");
Console.WriteLine("Digite '2' para sacar de sua conta corporativa.");

SelectedAccount = Console.ReadLine();

Person withd = new Person();

if (SelectedAccount == "1")
{
    AccountPerson accountPerson = new AccountPerson();
    accountPerson.ShowBalance();
}
else if (SelectedAccount == "2")
{
    BusinessPerson businessPerson = new BusinessPerson();
    businessPerson.ShowBalance();
}
