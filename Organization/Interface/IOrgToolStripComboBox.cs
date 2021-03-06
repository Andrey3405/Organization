﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Interface
{
    public interface IOrgToolStripComboBox
    {
        event EventHandler<EventArgs> SelectedItemChanged;

        bool Active { get; set; }

        void SetItems(Dictionary<int, string> items);
        object GetSelectedItemValue();
    }
}
