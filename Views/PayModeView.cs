using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PayModeView : Form, IPayModeView
    {
        private bool isEdit;

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set  { TxtPayModeId.Text = value; } 
        }
        public string PayModeName 
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; } 
        }
        public string PayModeObservation 
        {
            get { return TxtPayModeObservation.Text; }
            set { TxtPayModeObservation.Text = value; } 
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; } 
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; } 
        }
        public bool IsSuccessfull 
        {
            get { return IsSuccessfull;}
            set { IsSuccessfull = value;}
        }
        public string Message 
        {
            get { return Message; } 
            set { Message = value; } 
        }

        public PayModeView()
        {
            InitializeComponent();
            AssociativeAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPagePayModeDetail);
        }

        private void AssociativeAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void PayModeView_Load(object sender, EventArgs e)
        {

        }

        private void tabPagePayModeDetail_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }
    }
}
