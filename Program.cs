using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO8_
{
     class Program
    {
     static void Main(string[] args)
        {
            Bank_Account CompteLaManu = new Bank_Account(); // Déclaration & instanciation de l'objet CompteLaManu avec la classe Bank_Account
            Console.WriteLine("Titulaire du compte ?"); // Nom titulaire
            CompteLaManu.owner = Console.ReadLine(); // L'attribut owner de l'objet CompteLaManu reçoit la valeur entrée par l'utilisateur 
            Console.WriteLine("Solde Tout compte ?"); // Solde bancaire
            CompteLaManu.final_settlement = double.Parse(Console.ReadLine());
            Console.WriteLine("Devise?"); // Devise
            CompteLaManu.currency = Console.ReadLine();
            Console.WriteLine("Montant du crédit ?"); // Montant du crédit
            double amount = double.Parse(Console.ReadLine());
            /*obj.owner = "La Manu";*/
            /* obj.currency = "Euros";*/
            /*obj.final_settlement = 2000;*/
            /*obj.credit = 19;*/
            //CompteLaManu.debit = 0;
            CompteLaManu.Tocredit(amount); // Appel de la méthode Tocredit
            //obj.Todebit(obj.debit);
        }
    }
    //déclaration de la classe la manu 
    public class Bank_Account
    {
        public string owner;
        public string currency;
        public double final_settlement;
        public void Tocredit(double amount) //déclaration de la méthode Tocredit type void qui ne retourne rien
            {
            final_settlement = final_settlement + amount;
            Console.WriteLine("Le solde de " + owner + " est de " + final_settlement +" "+ currency);
            }
        public void Todebit(double amount)
            {
            final_settlement = final_settlement - amount;
            Console.WriteLine("Le solde de " + owner + " est de " + final_settlement +" "+ currency);
            }
    }
}
