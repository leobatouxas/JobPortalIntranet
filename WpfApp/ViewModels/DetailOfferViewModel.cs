using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp.ViewModels.Common;

namespace WpfApp.ViewModels
{
    public  class DetailOfferViewModel: BaseViewModel
    {
        #region Variables

        private string _title;
        private string _description;
        private Statut _status;
        private RelayCommand _addOperation;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// <param name="p">Produit à transformer en DetailProduitViewModel</param>
        /// </summary>
        public DetailOfferViewModel(Offer o)
        {
            _title = o.Title; 
            _description = o.Description;
            _status = o.Statut;
        }
        #endregion

        #region Data Bindings

        /// <summary>
        /// Titre de l'offre
        /// </summary>
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        
        /// <summary>
        /// Description de l'offre
        /// </summary>
        public string Description
        { get { return _description; }
        set { _description = value; }
        }

        public Statut Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }
        #endregion

        //#region Commandes

        ///// <summary>
        ///// Commande pour ouvrir la fenêtre pour ajouter une opération
        ///// </summary>
        //public ICommand AddOperation
        //{
        //    get
        //    {
        //        if (_addOperation == null)
        //            _addOperation = new RelayCommand(() => this.ShowWindowOperation());
        //        return _addOperation;
        //    }
        //}

        ///// <summary>
        ///// Permet l'ouverture de la fenêtre
        ///// </summary>
        //private void ShowWindowOperation()
        //{
        //    Views.Operation operationWindow = new Views.Operation();
        //    operationWindow.DataContext = this;
        //    operationWindow.ShowDialog();
        //}

        //#endregion
    }
}
