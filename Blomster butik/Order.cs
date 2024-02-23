using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blomster_butik
{
    internal class Order
    {

        int _id;
        DateTime _date;
        private static int idCounter = 0;


        //properties
        public int Id { get => _id; private set => _id = value; }
        public DateTime Date { get => _date; private set => _date = value; }


        //Constructer
        public Order()
        {
            Id = idCounter;
            Date = DateTime.Now;
            idCounter++;
        }

        //overrider ToString
        public override string ToString()
        {
            return "Order-id " + Id + " Date " + Date.ToString("dd-MM-yy : kl: HH:mm:ss:fff");
        }

    }
}
