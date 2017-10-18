﻿using Client.Commands.Adding;
using Client.Commands.Contracts;
using Client.Commands.Creating;
using Client.Commands.Listing;
using Client.Core;
using Client.Core.Contracts;
using Client.Core.Factories;
using Client.Core.Providers;
using Data.Context;
using Ninject.Modules;

namespace Client.Ninject
{
    public class AutoRentModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IAutoRentContext>().To<AutoRentContext>();

            this.Bind<IReader>().To<ConsoleReader>();
            this.Bind<IWriter>().To<ConsoleWriter>();
            this.Bind<ICommandParser>().To<CommandParser>();
            this.Bind<ICommandProcessor>().To<CommandProcessor>();

            this.Bind<IAutoRentFactory>().To<AutoRentFactory>().InSingletonScope();
            this.Bind<ICommandFactory>().To<CommandFactory>().InSingletonScope();

            //this.Bind<IDatabase>().To<Database>().InSingletonScope();
            this.Bind<IEngine>().To<Engine>().InSingletonScope().Named("Engine");
            //this.Bind<IEngine>().To<EngineLoggingDecorator>()
            //    .InSingletonScope()
            //    .Named("Engine")
            //    .WithConstructorArgument(this.Kernel.Get<IEngine>("EngineInternal"));

            this.Bind<ICommand>().To<CreateCarCommand>().Named("createcar");
            this.Bind<ICommand>().To<CreateOfficeCommand>().Named("createoffice");
            this.Bind<ICommand>().To<CreateOrderCommand>().Named("createorder");
            this.Bind<ICommand>().To<CreateUserCommand>().Named("createuser");

            this.Bind<ICommand>().To<AddCarToOfficeCommand>().Named("addcartooffice");

            this.Bind<ICommand>().To<ListCarsCommand>().Named("listcars");
        }
    }
}