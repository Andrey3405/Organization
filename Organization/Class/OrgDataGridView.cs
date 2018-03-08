using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organization.Class
{
    class OrgDataGridView : Interface.IOrgDataGridView
    {
        private DataGridView dataGridView;

        public DataTable DataSource
        {
            get => (DataTable)dataGridView.DataSource ;
            set
            {
                dataGridView.DataSource = value;
                for(int i=0;i<dataGridView.Columns.Count;i++)
                {
                    dataGridView.Columns[i].HeaderText
                        = value.Columns[i].Caption;
                    if (dataGridView.Columns[i].GetType()
                         == typeof(DataGridViewImageColumn))
                    {
                        ((DataGridViewImageColumn)dataGridView.Columns[i]).ImageLayout
                            = DataGridViewImageCellLayout.Stretch;
                    }
                    else if(dataGridView.Columns[i].GetType()
                         == typeof(DataGridViewTextBoxColumn))
                    {
                        dataGridView.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
        }

        public OrgDataGridView(DataGridView _dataGridView)
        {
            dataGridView = _dataGridView;
        }
    }
}
