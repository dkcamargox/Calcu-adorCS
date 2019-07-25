using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculador
{
    public partial class FormInicial : Form
    {
        private MenuPrincipal mp;
        public FormInicial()
        {
            mp = new MenuPrincipal();
            InitializeComponent();
            mp.Show();

        }
        public static void fechar()
        {
           
        }
        
        private void FormInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
