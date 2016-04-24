using System;

namespace LoanFacade {
    class Credit {
        public bool HasGoodCredit(Customer c) {
            Console.WriteLine("Check credit for "+c.Name);
            return true;
        }
    }
}