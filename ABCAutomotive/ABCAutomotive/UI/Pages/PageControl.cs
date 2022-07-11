using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCAutomotive.UI.Pages
{
    /// <summary>
    /// Represents a page that will be loaded and used in the Main Form
    /// <parent name="UserControl"></parent>
    /// </summary>
    public partial class PageControl : UserControl
    {
        public PageControl()
        {
            InitializeComponent();
        }

        public void Close()
        {
            this.Dispose();
        }
    }
}
