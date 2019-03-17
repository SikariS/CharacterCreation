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
        string race;
        string comboWHgenerateAmount;
        int generateAmount;
        bool choiceRand; //This will be to see if the random choice is made for each time generate button is pressed a new race needs to be generated.
        Functions cCreatorInst = new Functions();
        public Form1()
        {
            InitializeComponent();
        }

        // Generate Button for Warhammer
        private void bGenerateWH_Click(object sender, EventArgs e)
        {
            string alustus;
            string tuloste;
            string rivinvaihto = "";

            int i = generateAmount;
            while (i > 0)
            {


                if (choiceRand) //Random only worked once and randomized only when switched between races.
                {
                    race = cCreatorInst.RandRace("WH");
                }
                alustus = "Generoidaan hahmo rodulla " + race;
                tuloste = cCreatorInst.MainProfileCreatorWH(race);

                cCreatorInst.PrintToFile(alustus);
                cCreatorInst.PrintToFile(tuloste);
                cCreatorInst.PrintToFile(rivinvaihto);
                i--;
            }
            MessageBox.Show("Tulostettiin " + generateAmount + " hahmoa tekstitiedostoon " +AppDomain.CurrentDomain.BaseDirectory + "Characters.txt");
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
            comboBoxWHGenerateAmount.SelectedIndex = 0; //The amount to generate is by default 1, combo has default value of 1
            comboBoxWHGenerateAmount.DropDownStyle = ComboBoxStyle.DropDownList; //User cannot edit the values
        }

        private void comboBoxWHGenerateAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboWHgenerateAmount = comboBoxWHGenerateAmount.Text;
            generateAmount = Int32.Parse(comboWHgenerateAmount); //Because the combo is locked and only has values from 1-10 no need to TryParse.
        }
    }
}
