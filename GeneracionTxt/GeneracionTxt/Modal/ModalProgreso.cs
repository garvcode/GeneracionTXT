using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeneracionTxt.Modal
{
    public partial class ModalProgreso : Form
    {
        public ModalProgreso()
        {
            InitializeComponent();
        }

        public void ActualizarValorMaximoProgreso(int valor)
        {
            progressBar.Maximum = valor;
        }


        public void ActualizarProgreso(int valor)
        { 
            progressBar.Value = valor;
        }
    }
}
