using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoHelper
{
    // Форма виходу.
    public partial class ExitForm : Form
    {
        // Посилання на головну форму.
        private MainForm Main { get; set; }
        public ExitForm(MainForm main)
        {
            InitializeComponent();
            Main = main;
        }

        private void ExitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
