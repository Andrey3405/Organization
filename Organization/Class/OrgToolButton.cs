using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Organization.Class
{
    internal class OrgToolButton:Interface.IOrgToolButton
    {
        private ToolStripButton toolStripButton;

        public event EventHandler<EventArgs> Click;
        public event EventHandler<EventArgs> CheckedChanged;

        public bool Checked
        {
            get => toolStripButton.Checked;
        }

        public OrgToolButton(ToolStripButton _toolStripButton)
        {
            toolStripButton = _toolStripButton;
            toolStripButton.Click += OnClick;
            toolStripButton.CheckedChanged += OnCheckedChanged;
        }

        private void OnClick(object sender, EventArgs e)
        {
            Click?.Invoke(sender,e);
        }

        private void OnCheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged?.Invoke(sender,e);
        }
    }
}
