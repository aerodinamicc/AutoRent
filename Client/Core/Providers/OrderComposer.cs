﻿using Client.Core.Contracts;
using Models;
using System;

namespace Client.Core.Providers
{
    public class OrderComposer : IOrderComposer
    {
        public OrderComposer()
        {
        }

        public Car SelectedCar { get; set; }

        public User SelectedUser { get; set; }

        public Office DestinationOffice { get; set; }

        public DateTime DepartureDate { get; set; }

        public int Duration { get; set; }

        public void Finalize()
        {
            this.SelectedCar = null;
            this.SelectedUser = null;
            this.DestinationOffice = null;
            this.DepartureDate = new DateTime();
            this.Duration = 0;
        }
    }
}
