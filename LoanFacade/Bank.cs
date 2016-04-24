using System;
/// <summary>
/// The "subsystem ClassA" class
/// </summary>
namespace LoanFacade {
    class Bank {
        public bool HasSufficientSavings(Customer c,int amount) {
            Console.WriteLine("Check bank for "+c.Name);
            return true;
        }
    }
}