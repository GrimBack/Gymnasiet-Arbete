using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gymme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<CharacterList> characterList = new List<CharacterList>();

        private void StartBt_Click(object sender, EventArgs e)
        {
            CharacterList MC = new CharacterList(NameTB.Text);
            MessageBox.Show("Your name is " + MC);

        }


    }
}
