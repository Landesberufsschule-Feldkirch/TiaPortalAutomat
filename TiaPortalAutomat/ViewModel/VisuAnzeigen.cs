using System.ComponentModel;
using System.Threading;
using TiaPortalAutomatV14SP1.Model;

namespace TiaPortalAutomatV14SP1.ViewModel
{
    public class VisuAnzeigen : INotifyPropertyChanged
    {
        private readonly Automat _transportwagen;
        private readonly MainWindow _mainWindow;

        public VisuAnzeigen(MainWindow mw, Automat tw)
        {
            _mainWindow = mw;
            _transportwagen = tw;



            System.Threading.Tasks.Task.Run(VisuAnzeigenTask);
        }

        private void VisuAnzeigenTask()
        {

            while (true)
            {

                Thread.Sleep(10);
            }
            // ReSharper disable once FunctionNeverReturns
        }

        #region iNotifyPeropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion iNotifyPeropertyChanged Members
    }
}