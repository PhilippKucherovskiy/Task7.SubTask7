using System;

namespace Task7.SubTask7
{
    class Program
    {
        abstract class Delivery
        {
            public string Name;
            public string SurName;
            public string Address;
            public int DeliveryType;
        }

        class HomeDelivery : Delivery
        { }

}

        class PickPointDelivery : Delivery
        {
            /* ... */
        }

        class ShopDelivery : Delivery
        {
            /* ... */
        }
        //Класс товаров, имеющихся в наличии и доступных к продаже.
        //Равнозначен с классом товаров на складе, указывает на него ассоциацией
        class Itemsforsale
        {
            private Order order;

        }
    //Корзина покупок связана композицией с классом товаров, наличествующих к продаже.
    //Выбрана композиция,а не агрегация,  т.к. в моем представлении экземпляр класса корзины не должен существовать вне имеющихся товаров.

    protected class Cart
    {
            private Itemsforsale itemsforsale;
            public Cart()
            {
                itemsforsale = new Itemsforsale();
            }
        }
        {

        }

    internal class Order
    {
    }
} }
        
    
    class Order<TDelivery,
        TStruct> where TDelivery : Delivery
        {
            public TDelivery Delivery;

            public int Number;

            public string Description;

            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }

            
        }
    }
}
