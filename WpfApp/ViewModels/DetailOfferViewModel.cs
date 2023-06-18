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
        private ICollection<Candidacy> _candidacies;
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
            _candidacies = o.Candidacies;
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

        public ICollection<Candidacy> Candidacies
        {
            get { return _candidacies; }
            set
            {
                _candidacies = value;
                OnPropertyChanged("Candidacies");
            }
        }

        public string EmployeName
        {
            get
            {
                if (Candidacies != null && Candidacies.Count > 0)
                {
                    Candidacy firstCandidacy = Candidacies.First();
                    return $"{firstCandidacy.Employe.Firstname} {firstCandidacy.Employe.Lastname}";
                }

                return string.Empty;
            }
        }

        #endregion
    }
}
