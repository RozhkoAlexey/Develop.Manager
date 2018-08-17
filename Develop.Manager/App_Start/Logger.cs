namespace Develop.Manager.App_Start
{
    using log4net;
    using log4net.Config;

    public class Logger
    {
        public static ILog Log { get; } = LogManager.GetLogger("LOGGER");

        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}