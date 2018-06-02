using System;
using Chips.DependencyInjection.SimpleInjector;
using Sitecore.Data.Items;
using Sitecore.Tasks;

namespace ServiceLocatorPatternOrAntiPattern.Commands
{
    public class CommandTaskContainerAdapter<TCommand>
    where TCommand : ICommand
    {
        public void Execute(Item[] items, CommandItem commandItem, ScheduleItem schedule)
        {
            var scheduleTask = (ICommand)SimpleInjectorBootstrapper.Container.GetInstance(typeof(TCommand));
            scheduleTask.Execute(items, commandItem, schedule);
        }
    }

    public class CommandTaskContainerAdapter
    {
        public void Execute(Item[] items, CommandItem commandItem, ScheduleItem schedule)
        {
            var commandTypecommand = commandItem["Command Type"];
            var commandType = Type.GetType(commandTypecommand);
            var command = (ICommand)SimpleInjectorBootstrapper.Container.GetInstance(commandType);
            command.Execute(items, commandItem, schedule);
        }
    }
}