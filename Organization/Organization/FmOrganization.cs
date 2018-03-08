using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organization.Organization
{
    public partial class FmOrganization : Form, View.IOrganizationView
    {
        public Interface.IOrgToolStripComboBox CBEmployeeStatus { get; private set; }
        public Interface.IOrgDataGridView DGVOrgDataGridView { get; private set; }

        public FmOrganization()
        {
            InitializeComponent();
            CBEmployeeStatus = new Class.OrgToolStipCombobox(this.tscbEmployeeStatus);
            DGVOrgDataGridView = new Class.OrgDataGridView(this.dgvEmployeeInfo);
        }
    }
}
