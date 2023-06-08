using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.ViewModels.Common;

namespace WpfApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        #region Variables

        private ListOfferViewModel _listOfferViewModel = null;

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public HomeViewModel()
        {
            _listOfferViewModel = new ListOfferViewModel();
        }

        #endregion

        #region Data Bindings

        /// <summary>
        /// Obtient ou définit le ListOfferViewModel
        /// </summary>
        public ListOfferViewModel ListOfferViewModel
        {
            get { return _listOfferViewModel; }
            set { _listOfferViewModel = value; }
        }

        #endregion
    }
}
