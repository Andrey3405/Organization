using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization.Interface
{
    public interface IOrgToolButton
    {
        event EventHandler<EventArgs> Click;
        event EventHandler<EventArgs> CheckedChanged;

        bool Checked { get; }
    }
}
