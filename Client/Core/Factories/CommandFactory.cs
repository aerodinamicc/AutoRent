﻿using Client.Commands.Contracts;
using Ninject;

namespace Client.Core.Factories
{
    public class CommandFactory : ICommandFactory
    {
        private readonly IKernel kernel;

        public CommandFactory(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public ICommand GetCommand(string commandName)
        {
            ICommand command = this.kernel.Get<ICommand>(commandName);

            return command;
        }
    }
}
