using System.Reflection;
using log4net;
using MasterMindLibrary;

namespace MasterMind
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Logger.Setup();
            WordGetter.SetUp();
            var log = LogManager.GetLogger(Assembly.GetAssembly(typeof(Program)), typeof(Program));
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new MasterMindForm(log));
            }
            catch (Exception e)
            {
                log.Error(e);
                MessageBoxCreator.ShowError();
            }
        }
    }
}