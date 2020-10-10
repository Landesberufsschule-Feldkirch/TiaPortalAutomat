using System.Windows.Input;
using TiaPortalAutomatV14SP1.Commands;
using TiaPortalAutomatV14SP1.Model;

namespace TiaPortalAutomatV14SP1.ViewModel
{
    public class ViewModel
    {
        public Automat Automat { get; }

        public VisuAnzeigen ViAnzeige { get; set; }
        public ViewModel(MainWindow mainWindow)
        {
            Automat = new Automat();
            ViAnzeige = new VisuAnzeigen(mainWindow, Automat);
        }

        private ICommand _btnStart;
        // ReSharper disable once UnusedMember.Global
        public ICommand BtnStart => _btnStart ??= new RelayCommand(p => Automat.TasterStart(), p => true);

        private ICommand _btnStop;
        // ReSharper disable once UnusedMember.Global
        public ICommand BtnStop => _btnStop ??= new RelayCommand(p => Automat.TasterStop(), p => true);
    }
}