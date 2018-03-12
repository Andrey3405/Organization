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
        public Interface.IOrgDataGridView DGVRelation { get; private set; }
        public Interface.IOrgToolButton BtnTableMode { get; private set; }

        public FmOrganization()
        {
            InitializeComponent();
            CBEmployeeStatus = new Class.OrgToolStipCombobox(this.tscbEmployeeStatus);
            DGVRelation = new Class.OrgDataGridView(this.dgvEmployeeInfo);
            BtnTableMode = new Class.OrgToolButton(this.tlBtnTableMode);
        }
    }
}
