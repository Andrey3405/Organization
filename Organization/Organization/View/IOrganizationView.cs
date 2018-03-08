using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Organization.View
{
    interface IOrganizationView
    {
        Interface.IOrgToolStripComboBox CBEmployeeStatus { get; }
        Interface.IOrgDataGridView DGVOrgDataGridView { get; }

        event EventHandler Load;
    }
}
