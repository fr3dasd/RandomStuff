using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using Prism.Mvvm;
using DOTAapp.Model;


namespace DOTAapp.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        private DispatcherTimer timer = new DispatcherTimer();
    
        public MainWindowViewModel()
        {

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

        }

        void Timer_Tick(object sender, EventArgs e)
        {
            clock.Update();
        }

        //private void OnNav(string destination)
        //{

        //    switch (destination)
        //    {
        //        case "orders":
        //            CurrentViewModel = orderViewModelModel;
        //            break;
        //        case "customers":
        //        default:
        //            CurrentViewModel = custListViewModel;
        //            break;
        //    }
        //}


        #region Properties
        Clock clock = new Clock();
        public Clock Clock { get => clock; set => clock = value; }

        //ViewModel Properties
        private


        #endregion

        #region Commands


        #endregion
    }
}
