namespace ServiceLocatorPatternOrAntiPattern
{
    public class SitecoreLogAdaptor:ILogAdaptor
    {
        public void LogInfo(string message)
        {
            Sitecore.Diagnostics.Log.Info(message, this);
        }
    }
}