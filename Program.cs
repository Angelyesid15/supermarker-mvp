using System.Windows.Forms;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Presenters;
using Supermarket_mvp.Properties;
using Supermarket_mvp.Views;


namespace Supermarket_mvp
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view = new PayModeView();
            ///IPayModeRepository reposity = new PayModeRepository(sqlConnectionString);
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form) view);
            ///Application.Run(new PayModeView()); 
        }
    }
}
