
using System;
public class Warehouse 
{
    public string Name { get; set; }

    public string Comment { get; set; }

    public string GoodsId { get; set; }
}
public class Cart
{
    private Warehouse warehouse;

    public string SystemUnit(Warehouse warehouse)
    {
        this.warehouse=warehouse;  // агрегация от склада
    }
}

class Order<TDelivery,
TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description; }


    public class ShipmentItem : Warehouse
    {
        public int ShipmentId { get; set; }

        public int OrderItemId { get; set; }

        public int Quantity { get; set; }

        public int WarehouseId { get; set; }

    }
    class ShipmentCreatedEvent : Delivery                                                              //наследование
    {
        public int OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public decimal? TotalWeight { get; set; }
        public string Comment { get; set; }
        public class ShippingMethod : Delivery
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public int DisplayOrder { get; set; }
        }
    class ShipmentCreatedEvent
    {
        string s = "Создана новая доставка"
            char c = 'и';
        private readonly int i = s.CharCount(c);

        public ShipmentCreatedEvent(int i)
        {
            this.i = i;
        }

        Console.WriteLine(i); }



    public ShipmentCreatedEvent(string s, char c, int i, global::ShipmentCreatedEvent shipment) // конструктор с проверкой значений
            {
                this.s = s ?? throw new ArgumentNullException(nameof(s));
                this.c = c;
                this.i = i;
                Shipment = shipment ?? throw new ArgumentNullException(nameof(shipment));
            }

            public void ShipmentCreatedEvent() => Console.WriteLine("Создание объекта ShipmentCreatedEvent"); // конструктор с 1 методом

            ShipmentCreatedEvent = new ShipmentCreatedEvent();   //вызов конструктора 

            public ShipmentCreatedEvent(global::ShipmentCreatedEvent shipment)
            {
                Shipment = shipment;
            }

            public global::ShipmentCreatedEvent Shipment { get; }
        }    
    } 
}
public static class ShipmentExtension
{
    public static int CharCount(this string str, char c)
    {
        int counter = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == c)
                counter++;
        }
        return counter;
    }

    public class PickupPoint

    {
        public static PickupPoint operator +(PickupPoint counter1, PickupPoint counter2) // перегрузка оператора
        {
            return new PickupPoint { Value = counter1.Value + counter2.Value };
        }
        public static bool operator >(PickupPoint counter1, PickupPoint counter2)
        {
            return counter1.Value > counter2.Value;
        }
        public static bool operator <(PickupPoint counter1, PickupPoint counter2)
        {
            return counter1.Value < counter2.Value;
        }

        public string Id { get; set; }//свойства


        public string Name { get; set; }


        public string Description { get; set; }


        public string Address { get; set; }

        public string City { get; set; }

        public string County { get; set; }

        public string ZipPostalCode { get; set; }

        //координаты 
        public decimal? Latitude { get; set; }

        public decimal? Longitude { get; set; }

        // дни в пути
        public int? TransitDays { get; set; }
        public int Value { get; private set; }
    }

    public class DeliveryDate : Delivery
    {
        public string Name { get; set; }
        public object Delivery { get; private set; }

        public override void DisplayAddress()         //переопределение метода
        {
            Console.WriteLine(Delivery.Address);

        }
    }
    public enum ShippingStatus
    {

        //Доставка не предусмотрена
        ShippingNotRequired = 10,

        // Еще не доставлен товар

        NotYetShipped = 20,

        // частично доставлено

        PartiallyShipped = 25,

        //Отправлено
        Shipped = 30,
        //Доставлено 
        Delivered = 40
    }
    public class ShippingOption
    {

        public string ShippingRateMethodName { get; set; }

        public decimal Rate { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int? TransitDays { get; set; }

        public bool IsPickupInStore { get; set; }

        public int? DisplayOrder { get; set; }
    }
    public class ShipmentDeliveredEvent
    {
        public ShipmentDeliveredEvent(ShipmentCreatedEvent shipment)
        {
            Shipment = shipment;
        }
        public ShipmentCreatedEvent Shipment { get; }
    } 
}
    




