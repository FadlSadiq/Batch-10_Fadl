// https://github.com/NLog/NLog/wiki/Tutorial
using NLog;
using NLog.Config;

class Program
{
    public static Logger logger = LogManager.GetCurrentClassLogger();
    static void Main()
    {
        LogManager.Configuration = new XmlLoggingConfiguration("NLog.Config");
        logger.Debug("Starting Robot");
        Robot robot = new();
        logger.Info("Starting Walk");
        robot.Walk();
        logger.Info("Program Finished");
    }
}

class Robot
{
    public static Logger logger = LogManager.GetCurrentClassLogger();

    public void Walk()
    {
        LeftLegMove();
        RightLegMove();
        logger.Info("walk one step");
    }

    void LeftLegMove()
    {
        //process
        logger.Info("left leg move");
    }
    void RightLegMove()
    {
        //process
        logger.Info("right leg move");
    }
}