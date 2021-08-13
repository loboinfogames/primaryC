using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_projeto {

    class ContaBancaria {
        public string Titular { get; set; }
        private double _saldo;

        public void Deposito(double quantia) {
            _saldo += quantia;
        }
        public double GetSaldo() {
            return _saldo;
        }
    }
}


