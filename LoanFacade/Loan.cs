﻿using System;

namespace LoanFacade {
    class Loan {
        public bool HasNoBadLoans(Customer c) {
            Console.WriteLine("Check loans for "+c.Name);
            return true;
        }
    }
}