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
        }

        public string GetSelectedItemText()
        {
            return toolStripComboBox.ComboBox.SelectedText;
        }

        public object GetSelectedItemValue()
        {
            throw new NotImplementedException();
        }

        public void SetItems(Dictionary<int, string> items)
        {
            bindingSource.DataSource = items;
        }

        public void SetSelectedItem(int value)
        {
            throw new NotImplementedException();
        }

        public void SetSelectedItem(string text)
        {
            throw new NotImplementedException();
        }
    }
}
