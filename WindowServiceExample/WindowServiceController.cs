using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowServiceExample
{
    public class WindowServiceController
    {
        System.Windows.Forms.Timer t = null;
 
        public void Start() { log.Info("WindowServiceExample started."); t.Start(); }
        public void Stop() { log.Info("WindowServiceExample stopped."); t.Stop(); }

        public WindowServiceController()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 15000; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
           
        }      

        private void timer_Tick(object sender, EventArgs e)
        {
            log.Info("WindowServiceExample timer running.");
        }


        //-----Here is the once-per-class call to initialize the log object
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    }
}
