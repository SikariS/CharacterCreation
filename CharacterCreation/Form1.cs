using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreation
{
    public partial class Form1 : Form
    {
        String race;
        Functions characterCreatorInstance = new Functions();
        public Form1()
        {
            InitializeComponent();
        }

        private void bGenerateWH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Generoidaan hahmo rodulla " + race + characterCreatorInstance.CharacterCreatorWH(race));
            //characterCreatorInstance.CharacterCreatorWH(race);
        }

        private void rbHumanWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbHumanWH.Text;
        }

        private void rbDwarfWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbDwarfWH.Text;
        }

        private void rbElfWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbElfWH.Text;
        }

        private void rbHalflingWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbHalflingWH.Text;
        }

        private void rbRandomWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbRandomWH.Text;
        }
    }
}
