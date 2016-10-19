﻿namespace _02_State_Order
{
    public class NewState : IOrderState
    {
        public bool CanShip(Order order)
        {
            return true;
        }

        public void Ship(Order order)
        {
            //actual shipping logic ignored, only changing the status
            order.Change(new ShippedState());
        }

        public bool CanCancel(Order order)
        {
            return true;
        }

        public void Cancel(Order order)
        {
            //actual cancellation logic ignored, only changing the status;
            order.Change(new CancelledState());
        }

        public OrderStatus Status => OrderStatus.New;
    }
}
