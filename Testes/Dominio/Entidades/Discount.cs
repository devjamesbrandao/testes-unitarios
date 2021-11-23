using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Discount : Entity
    {
        public Discount(decimal amount, DateTime expireDate)
        {
            Amount = amount;
            ExpireDate = expireDate;
        }

        public decimal Amount { get; private set; }
        public DateTime ExpireDate { get; private set; }

        // Verifica se o disconto ainda é valido
        public bool IsValid()
        {
            return DateTime.Compare(DateTime.Now, ExpireDate) < 0;
        }

        // Calcula o valor do desconto
        public decimal Value()
        {
            if(IsValid())
                return Amount;
            else
                return 0;
        }

    }
}