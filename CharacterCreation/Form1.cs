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
        bool choiceRand; //This will be to see if the random choice is made for each time generate button is pressed a new race needs to be generated.
        Functions cCreatorInst = new Functions();
        public Form1()
        {
            InitializeComponent();
        }

        // Generate Button for Warhammer
        private void bGenerateWH_Click(object sender, EventArgs e)
        {
            string tuloste;
            if (choiceRand) //New race every time you press the Generate button instead of changing race once.
            {
                race = cCreatorInst.RandRace("WH");
            }
            tuloste = "Generoidaan hahmo rodulla " + race + " \r" + cCreatorInst.MainProfileCreatorWH(race);

            MessageBox.Show(tuloste);
            cCreatorInst.PrintToFile(tuloste);
        }

        private void rbHumanWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbHumanWH.Text;
            choiceRand = false;
        }

        private void rbDwarfWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbDwarfWH.Text;
            choiceRand = false;
        }

        private void rbElfWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbElfWH.Text;
            choiceRand = false;
        }

        private void rbHalflingWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbHalflingWH.Text;
            choiceRand = false;
        }

        private void rbRandomWH_CheckedChanged(object sender, EventArgs e)
        {
            race = rbRandomWH.Text;
            choiceRand = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
