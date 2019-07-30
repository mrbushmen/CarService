using System;

namespace CarServiceDB
{
    //Класс для представления информации о заказах в заданной форме
    class OrderProjection
    {
        public int Id { get; set; }

        //CarId
        public int Car { get; set; }

        //ServiceId
        public int Service { get; set; }

        //WorkerId
        public int Worker { get; set; }

        public DateTime Date { get; set; }

        public bool Paid { get; set; }

        public string CarModel { get; set; }

        public string ServiceType { get; set; }

        public string WorkerName { get; set; }
    }
}
