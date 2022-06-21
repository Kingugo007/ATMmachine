using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CardHolder
{
    public string cardNumber { get; set;}
    public string firstName { get; set; }
    public string lastName { get; set; }
    public double balance { get; set; }
    public int pin { get; set; }    
    
    public CardHolder(string cardNumber, string firstName, string lastName, double balance, int pin)
    {
        this.cardNumber = cardNumber;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
        this.pin = pin;
    }


    }
