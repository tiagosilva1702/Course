using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
using System;
using System.Text;
using System.Collections.Generic;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Conversão para string
            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(orderStatus);

        }
    }
}
