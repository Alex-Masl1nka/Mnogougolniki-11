using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace многоугольники
{
    public delegate void Save(object sender, SaveEventArgs e);
    public partial class SaveOrNot : Form
    {
        bool save;
        public Save sv;
        public SaveOrNot()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save = true;
            if (this.sv != null)
            {
                this.sv(this, new SaveEventArgs(save));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            save = false;
            if (this.sv != null)
            {
                this.sv(this, new SaveEventArgs(save));
            }
        }

    }
    public class SaveEventArgs : EventArgs
    { 
        public bool save{ get; set;}
        public SaveEventArgs(bool Save)
        {
            save = Save;
        }
    }

}
