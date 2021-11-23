using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Enums
{
    public enum EOrderStatus
    {
        WaitingPayment = 1,
        WaitingDelivery = 2,
        Canceled = 3
    }
}