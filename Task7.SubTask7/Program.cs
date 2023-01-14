
using System;

abstract class Delivery
{
    public string Address;
    public virtual void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }
}
public class Warehouse 
{
    public string Name { get; set; }

    public string Comment { get; set; }

    public int GoodsId { get; set; }
}
class Order<TDelivery,
TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public class ShipmentItem : Warehouse
{
    public int ShipmentId { get; set; }

    public int OrderItemId { get; set; }

    public int Quantity { get; set; }

    public int WarehouseId { get; set; }
}
 class Shipment : Delivery
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
    public class ShipmentCreatedEvent
    {
        public ShipmentCreatedEvent(Shipment shipment)
        {
            Shipment = shipment;
        }

        public Shipment Shipment { get; }
    }
    public class PickupPoint
    {

        public string Id { get; set; }


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
        public ShipmentDeliveredEvent(Shipment shipment)
        {
            Shipment = shipment;
        }
        public Shipment Shipment { get; }
    }
}




