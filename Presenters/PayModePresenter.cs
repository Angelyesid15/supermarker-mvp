using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using System.Windows.Forms;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView View;
        private IPayModeRepository Repository;
        private BindingSource payModebindingSource;
        private IEnumerable<PayModeModel> payModeList;
        private BindingSource payModeBindingSource;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            View = view;
            Repository = repository;

            this.View.SearchEvent += SearchPayMode;
            this.View.AddNewEvent += AddNewPayMode;
            this.View.EditEvent += LoadSelectPayModeToEdit;
            this.View.DeleteEvent += DeletSelectedPayMode;
            this.View.SaveEvent += SavePayMode;
            this.View.CancelEvent += CancelAction;

            this.View.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.View.Show();
        }

        private void loadAllPayModeList()
        {
            payModeList = Repository.GetAll();
            payModeBindingSource.DataSource = payModeList;  
        }

        private void CancelAction(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePayMode(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeletSelectedPayMode(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPayMode(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchPayMode(object sender, EventArgs e)
        {
            bool emptyValue = String.IsNullOrWhiteSpace(this.View.SearchValue);
            if (emptyValue == false)
            {
                payModeList = Repository.GetByValue(this.View.SearchValue);
            }
            else
            {
                payModeList = Repository.GetAll();
            }
            payModeBindingSource.DataSource = payModeList;
        }
    }
}
