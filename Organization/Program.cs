using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organization
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Organization.FmOrganization fmOrganization
                = new Organization.FmOrganization();
            Organization.Presenter.OrganizationPresenter presenter 
                = new Organization.Presenter.OrganizationPresenter(fmOrganization);
            Application.Run(fmOrganization);
        }
    }
}
