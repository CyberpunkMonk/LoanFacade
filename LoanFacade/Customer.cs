using System;

namespace LoanFacade {
    class Customer {
        private string _name;
        public string Name { get { return _name; } }
        //Constructor
        public Customer(string name) {
            this._name=name;
        }
    }
}