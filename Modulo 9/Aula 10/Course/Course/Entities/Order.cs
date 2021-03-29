using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus orderStatus, Client client)
        {
            Moment = moment;
            OrderStatus = orderStatus;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            stringBuilder.AppendLine($"Order status: {OrderStatus}");
            stringBuilder.AppendLine($"Client: {Client}");
            stringBuilder.AppendLine("Order items:");
            double sum = 0;
            foreach (OrderItem orderItem in OrderItems)
            {
                stringBuilder.AppendLine(orderItem.ToString());
                sum += orderItem.SubTotal();
            }
            stringBuilder.AppendLine($"Total price: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");

            return stringBuilder.ToString();
        }
    }
}
