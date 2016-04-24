using System;

namespace LoanFacade {
    class Mortgage {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Customer c,int a) {
            Console.WriteLine($"{c.Name} applies for {a:c} loan.\n");

            bool eligible = true;
            //Check creditworthyness of applicant
            if(!_bank.HasSufficientSavings(c,a)) { eligible=false; }
            if(!_loan.HasNoBadLoans(c)) { eligible=false; }
            if(!_credit.HasGoodCredit(c)) { eligible=false; }

            return eligible;
        }
    }
}