using BusinessLayer;
using JobPortalIntranetLibraryClass.modeleFluent;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.ViewModels.Common;

namespace WpfApp.ViewModels
{
    public class ListOfferViewModel : BaseViewModel
    {
        #region Variables

        private ObservableCollection<DetailOfferViewModel> _offers = null;
        private DetailOfferViewModel _selectedOffer;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ListOfferViewModel()
        {
            // on appelle le mock pour initialiser une liste de produits
            _offers = new ObservableCollection<DetailOfferViewModel>();
            Manager bm = Manager.Instance;

            foreach (Offer o in bm.GetAllOffer())
            {
                _offers.Add(new DetailOfferViewModel(o));
            }

            if (_offers != null && _offers.Count > 0)
            {
                _selectedOffer = _offers.ElementAt(0);

            }
            Console.WriteLine("construct");
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit une collection de DetailProduitViewModel (Observable)
        /// </summary>
        public ObservableCollection<DetailOfferViewModel> Offers
        {
            get { return _offers; }
            set
            {
                _offers = value;
                OnPropertyChanged("Offers");
            }
        }

        /// <summary>
        /// Obtient ou défini le produit en cours de sélection dans la liste de DetailProduitViewModel
        /// </summary>
        public DetailOfferViewModel SelectedOffer
        {
            get { return _selectedOffer; }
            set
            {
                _selectedOffer = value;
                OnPropertyChanged("SelectedOffer");
            }
        }

        #endregion

    }
}
