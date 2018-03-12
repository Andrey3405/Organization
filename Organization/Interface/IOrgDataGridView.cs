using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Interface
{
    public interface IOrgDataGridView
    {
        DataTable DataSource { get; set; }
        void SetColumnVisibility(string columnName, bool visibility);
    }
}
