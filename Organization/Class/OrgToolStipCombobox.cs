using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Class
{
    internal class OrgToolStipCombobox : Interface.IOrgToolStripComboBox
    {
        public event EventHandler<EventArgs> SelectedItemChanged;

        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.BindingSource bindingSource;
        private Organization.Model.OrganizationModel model;

        public bool Active { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DataTable DataSource { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public OrgToolStipCombobox(System.Windows.Forms.ToolStripComboBox _toolStripComboBox)
        {
            toolStripComboBox = _toolStripComboBox;
            model = new Organization.Model.OrganizationModel();
            bindingSource = new System.Windows.Forms.BindingSource();
            bindingSource.DataSource = new Dictionary<int, string>() { { 0, Organization.Model.OrganizationModel.RecordAll} };
            toolStripComboBox.ComboBox.DataSource = bindingSource;            
            toolStripComboBox.ComboBox.DisplayMember = "Value";
            toolStripComboBox.ComboBox.ValueMember = "Key";

            toolStripComboBox.SelectedIndexChanged += OnSelectedIndexChanged;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItemChanged?.Invoke(sender, e);
        }

        public object GetSelectedItemValue()
        {
            return (((KeyValuePair<int, string>)toolStripComboBox.ComboBox.SelectedItem).Key);
        }

        public void SetItems(Dictionary<int, string> items)
        {
            bindingSource.DataSource = items;
        }
    }
}
