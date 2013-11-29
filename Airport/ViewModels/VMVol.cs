using Airport.Entities;
using Airport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace Airport.ViewModels
{
    public class VMVol: INotifyPropertyChanged
    {
        public static RoutedCommand RechercherVolCommand;


        public static void CanExecuteRechercherVol(object sender, CanExecuteRoutedEventArgs e)
        {
            VMVol vol = sender as VMVol;
            if (string.IsNullOrEmpty(vol.Cie))
            {
                e.CanExecute=true;
            }
            else
                e.CanExecute=false;
        }


        
        private void RechercherVolCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.ResSearch = Model.GetVols();
        }
        

        Airport.Models.AbstractModel Model;
        public string Cie;

        /// <summary>
        /// liste des vols résultant de la recherche
        /// </summary>
        private List<Vol> resSearch;
        /// <summary>
        /// Vol séléctionné
        /// </summary>
        private Vol currentVol;

        public Vol CurrentVol
        {
            get { return this.currentVol; }
            set
            {
                this.currentVol = value;
                OnNotifyPropertyChange("CurrentVol");
            }                
        }

        public List<Vol> ResSearch
        {
            get { return this.resSearch; }
            set
            {
                this.resSearch = value;
                OnNotifyPropertyChange("ResSearch");
            }
        }


        public void Search()
        {
            this.ResSearch = Model.GetVols();
        }

        public VMVol()
        {
            //Initialisation du model 
            Model = Airport.ModelsFactory.Model;
        }

        

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void OnNotifyPropertyChange(PropertyChangedEventArgs args)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, args);
        }

        protected void OnNotifyPropertyChange(string propertyName)
        {
            this.OnNotifyPropertyChange(new PropertyChangedEventArgs(propertyName));
        }
    }
}
