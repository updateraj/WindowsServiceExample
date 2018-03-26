using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowServiceExample
{
    public class WindowServiceExample : System.ServiceProcess.ServiceBase
    {

        public WindowServiceExample()
        {
            this.ServiceName = "WindowServiceExample";
            this.CanStop = true;
            this.CanPauseAndContinue = true;
            this.AutoLog = true;
        }
        public static void Main()
        {
            System.ServiceProcess.ServiceBase.Run(new WindowServiceExample());
        }

        WindowServiceController controller = new WindowServiceController();

        protected override void OnStart(string[] args)
        {
            controller.Start();
        }
        protected override void OnStop()
        {
            controller.Stop();
        }

        //-----Here is the once-per-class call to initialize the log object
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private void InitializeComponent()
        {
            // 
            // WindowServiceExample
            // 
            this.ServiceName = "WindowServiceExample";

        }
    }
}
