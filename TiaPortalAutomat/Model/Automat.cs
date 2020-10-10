using System;
using System.Threading;

namespace TiaPortalAutomatV14SP1.Model
{
    public class Automat
    {
        public Automat()
        {
            System.Threading.Tasks.Task.Run(AutomatTask);
        }

        private void AutomatTask()
        {
            while (true)
            {
                Thread.Sleep(10);
            }
            // ReSharper disable once FunctionNeverReturns
        }

        internal void TasterStart()
        {
            throw new NotImplementedException();
        }

        internal void TasterStop()
        {
            throw new NotImplementedException();
        }
    }
}