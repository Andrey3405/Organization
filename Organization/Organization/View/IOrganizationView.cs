using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Organization.View
{
    public interface IOrganizationView
    {
        Interface.IOrgToolStripComboBox CBEmployeeStatus { get; }
        Interface.IOrgDataGridView DGVRelation { get; }
        Interface.IOrgToolButton BtnTableMode { get; }
        event EventHandler Load;
    }
}
