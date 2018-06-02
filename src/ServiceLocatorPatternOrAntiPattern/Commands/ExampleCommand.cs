using Sitecore.Data.Items;
using Sitecore.Tasks;

namespace ServiceLocatorPatternOrAntiPattern.Commands
{
    public class ExampleCommand : ICommand
    {
        private readonly ILogAdaptor _logAdaptor;

        public ExampleCommand(ILogAdaptor logAdaptor)
        {
            _logAdaptor = logAdaptor;
        }
        public void Execute(Item[] items, CommandItem commandItem, ScheduleItem schedule)
        {
            _logAdaptor.LogInfo($"Hello from ExampleCommand, called from {commandItem.Name}");
        }
    }
}