﻿using Client.Commands.Contracts;
using Client.Core.Contracts;
using Data.Context;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Client.Commands.Creating
{
    public class CreateOfficeCommand : ICommand
    {
        private readonly IAutoRentFactory factory;
        private readonly IAutoRentContext context;

        public CreateOfficeCommand(IAutoRentFactory factory, IAutoRentContext context)
        {
            this.factory = factory;
            this.context = context;
        }

        public string Execute(IList<string> parameters)
        {
            var city = parameters[0];
            var address = parameters[1];
            var cars = this.context.Cars.Where(c => c.OfficeId == int.Parse(parameters[2])); //?????????????????????????????????????????????????????????????????????????????????????????????????????????????????????

            var office = this.factory.CreateOffice(city, address);
            context.Offices.Add((Office)office);

            return $"Office with ID {this.context.Offices.Count() - 1} was created.";
        }
    }
}