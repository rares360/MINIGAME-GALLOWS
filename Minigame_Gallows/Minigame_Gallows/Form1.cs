using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;


namespace Minigame_Gallows
{   
        public partial class Form1:Form
        {

        WindowsMediaPlayer player = new WindowsMediaPlayer();
        
        int i, ok = 1;
        int Score = 0;
            int domeniu = 0;  
            int[] v = new int[50];
            string[] SWord = new string[20];
            string[] SecretWordsMasini = { "DACIA", "BMW", "AUDI", "FORD", "MERCEDES", "OPEL", "TOYOTA", "SUZUKI", "MAZDA", "SUBARU", "KIA", "HONDA", "NISSAN", "RENAULT", "VOLKSWAGEN","TESLA","CHEVROLET","FIAT","LEXUS","LOTUS","MAZDA","SUZUKI"};
            string[] SecretWordsCulori = { "MARO", "VERDE", "ROZ", "GALBEN","ALBASTRU","GRI","NEGRU","AURIU","ARGINTIU","INDIGO","KAKI","OLIV","BEJ","VIOLET","ARGINTIU"};
        string[] SecretWordsOrase = { "ORADEA","CRAIOVA","ARAD","SIBIU","SUCEAVA","TULCEA","DEVA","HUNEDOARA","TIMISOARA","IASI","CONSTANTA","PLOIESTI","PITESTI","BACAU","ZALAU","BISTRITA"};
            string[] SecretWordsAnimale = { "CAINE","PISICA","CAL","ARICI","LEU","TIGRU","BROASCA","BABUIN","GORILA","GIRAFA","GHEPARD","HIPOPOTAM","JAGUAR","LAMA","LEOPARD","NEVASTUICA","PAPAGAL","PELICAN","PINGUIN","PORC","VACA","RAC","RECHIN","RINOCER","SURICATA","URS","ZEBRA"};
            string[] SecretWordsTari = { "ROMANIA", "AUSTRIA","ITALIA","SPANIA","SUEDIA","FRANTA","POLONIA","GRECIA","NORVEGIA","DANEMARCA","GERMANIA","ESTONIA","CROATIA","PORTUGALIA" };
            string[] SecretWordsCapitale = { "BUCURESTI", "MADRID","PARIS","BERLIN","SOFIA","COPENHAGA","STOCKHOLM","ROMA","ANKARA","LONDRA","KIEV","ZAGREB","BUDAPESTA","PRAGA","BRATISLAVA","AMSTERDAM","DUBLIN","HELSINKI","LISABONA","BERNA","COPENHAGA","ATENA"};
            

            Random r = new Random();
            Random rr = new Random();

            string SecretWord, litera;
            bool buttonVietiClick;
            int Vieti;
            public Form1()
            {
            InitializeComponent();
                player.URL = "jazz.mp3";
            textBoxScor.Text = "Scor: " + Vieti;

            }
            private void Form1_Load(object sender, EventArgs e)
            {
                player.controls.play();
            }
            private void LetterPressed(object sender, EventArgs e)
            {
            
                Button b = (Button)sender;
                textBoxLitereF.Text = textBoxLitereF.Text + " " + b.Text;
                b.Visible = false;
                string s = SecretWord;
                string cuv;
                char c1;
                char[] cuvGasit = new char[50];
                SecretWord = SecretWord.ToUpper();
                if (SecretWord.Contains(b.Text.ToUpper()))
                {
                    char c2 = Convert.ToChar(b.Text.ToUpper());

                    for (int i = 0; i < s.Length; i++)
                    {
                        c1 = s[i];
                        if (c1 == c2)
                        {
                            cuvGasit = textBoxCuvantG.Text.Trim().ToCharArray();
                            cuvGasit[i] = c1;
                            cuv = new string(cuvGasit);
                            textBoxCuvantG.Text = cuv;
                            if (!textBoxCuvantG.Text.Contains("_"))
                            {
                                Score++;
                                DialogResult dr = MessageBox.Show("Score: "+ Score + "\nMAI JUCATI?" , "ATI GHICIT", MessageBoxButtons.YesNo);
                            
                                switch (dr)
                                {

                                    case DialogResult.Yes:
                                    {
                                        
                                        textBoxScor.Text ="Scor: " + Score.ToString();
                                        b_A.Visible = true; b_B.Visible = true; b_C.Visible = true; b_D.Visible = true; b_E.Visible = true; b_F.Visible = true; b_G.Visible = true;
                                        b_H.Visible = true; b_I.Visible = true; b_J.Visible = true; b_K.Visible = true; b_L.Visible = true; b_M.Visible = true;
                                        b_N.Visible = true; b_O.Visible = true; b_P.Visible = true; b_Q.Visible = true; b_R.Visible = true; b_S.Visible = true;
                                        b_T.Visible = true; b_U.Visible = true; b_V.Visible = true; b_W.Visible = true; b_X.Visible = true; b_Y.Visible = true;
                                        b_Z.Visible = true;
                                        textBoxLitereF.Text = "";
                                        textBoxCuvantG.Text = "";
                                        textBoxVieti.Visible = true;
                                        labelNrVieti.Visible = true;
                                        textBoxScor.Text = "Scor: " + Score.ToString();
                                        textBoxVieti.Visible = true;
                                        Vieti = 5;
                                        textBoxVieti.Text = "5";
                                        if (domeniu != 0)
                                        {
                                            if (domeniu == 1)
                                            {
                                                SecretWord = SecretWordsMasini[r.Next(0, SecretWordsMasini.Length)];
                                            }
                                            if (domeniu == 2)
                                            {
                                                SecretWord = SecretWordsCulori[r.Next(0, SecretWordsCulori.Length)];
                                            }
                                            if (domeniu == 3)
                                            {
                                                SecretWord = SecretWordsOrase[r.Next(0, SecretWordsOrase.Length)];
                                            }
                                            if (domeniu == 4)
                                            {
                                                SecretWord = SecretWordsTari[r.Next(0, SecretWordsTari.Length)];
                                            }
                                            if (domeniu == 5)
                                            {
                                                SecretWord = SecretWordsCapitale[r.Next(0, SecretWordsCapitale.Length)];
                                            }
                                            if (domeniu == 6)
                                            {
                                                SecretWord = SecretWordsAnimale[r.Next(0, SecretWordsAnimale.Length)];
                                            }
                                            textBoxLitereF.Visible = true;
                                            textBox3.Visible = true;
                                            textBoxCuvantG.Visible = true;
                                            labelCuvantG.Visible = true;
                                            Random litera = new Random();
                                            int poz = litera.Next(0, SecretWord.Length - 1);
                                            for (i = 0; i < SecretWord.Length; i++)
                                            {
                                                if (i == poz)
                                                    textBoxCuvantG.Text = textBoxCuvantG.Text + SecretWord.ToCharArray()[poz];
                                                else
                                                    textBoxCuvantG.Text = textBoxCuvantG.Text + "_";

                                            }
                                        }
                                    }
                                        break;
                                    case DialogResult.No:
                                        Application.Exit();
                                        break;
                                }

                            }

                        }
                    }
                }
                else
                {
                    Vieti--;
                    pictureBox1.Visible = true;
                    if (Vieti == 5)
                        pictureBox1.Image = Image.FromFile("Image1.png");
                    if (Vieti == 4)
                        pictureBox1.Image = Image.FromFile("Image2.png");
                    if (Vieti == 3)
                        pictureBox1.Image = Image.FromFile("Image3.png");
                    if (Vieti == 2)
                        pictureBox1.Image = Image.FromFile("Image4.png");
                    if (Vieti == 1)
                    {
                        pictureBox1.Image = Image.FromFile("Image5.png");
                    }
                    textBoxVieti.Text = Convert.ToString(Vieti);
                    if (textBoxVieti.Text == "0")
                    {
                        pictureBox1.Image = Image.FromFile("Image6.png");
                    DialogResult dr = MessageBox.Show("Cuvantul era : " + SecretWord + "\nRESTART JOC?", "ATI PIERDUT", MessageBoxButtons.YesNo);
                        switch (dr)
                        {
                            case DialogResult.Yes:
                                Application.Restart();
                                break;

                            case DialogResult.No:
                                Application.Exit();
                                break;
                        }

                    }

                }
            }
            private void ButtonENTER_Click(object sender, EventArgs e)
            {
            labelClasa.Visible = false;
            labelNumeleMeu.Visible = false;
            labelProf.Visible = false;
            buttonENTER.Visible = false;
            textBoxScor.Text = "Scor: " + Score.ToString();
            textBoxVieti.Visible = true;
                labelNrVieti.Visible = true;
               
                Vieti = 5;
                textBoxVieti.Text = "5";
                if (domeniu != 0)
                {
                b_A.Visible = true; b_B.Visible = true; b_C.Visible = true; b_D.Visible = true; b_E.Visible = true; b_F.Visible = true; b_G.Visible = true;
                b_H.Visible = true; b_I.Visible = true; b_J.Visible = true; b_K.Visible = true; b_L.Visible = true; b_M.Visible = true;
                b_N.Visible = true; b_O.Visible = true; b_P.Visible = true; b_Q.Visible = true; b_R.Visible = true; b_S.Visible = true;
                b_T.Visible = true; b_U.Visible = true; b_V.Visible = true; b_W.Visible = true; b_X.Visible = true; b_Y.Visible = true;
                b_Z.Visible = true;
                if (domeniu == 1)
                    {
                        SecretWord = SecretWordsMasini[r.Next(0, SecretWordsMasini.Length)];
                    }
                    if (domeniu == 2)
                    {
                        SecretWord = SecretWordsCulori[r.Next(0, SecretWordsCulori.Length)];
                    }
                    if (domeniu == 3)
                    {
                        SecretWord = SecretWordsOrase[r.Next(0, SecretWordsOrase.Length)];
                    }
                if (domeniu == 4)
                {
                    SecretWord = SecretWordsTari[r.Next(0, SecretWordsTari.Length)];
                }
                if (domeniu == 5)
                {
                    SecretWord = SecretWordsCapitale[r.Next(0, SecretWordsCapitale.Length)];
                }
                if (domeniu == 6)
                {
                    SecretWord = SecretWordsAnimale[r.Next(0, SecretWordsAnimale.Length)];
                }
                BoxNR.Text = "Textul contine " + SecretWord.Length.ToString() + " litere" ;
                BoxNR.Visible = true;
                textBoxLitereF.Visible = true;
                    textBox3.Visible = true;
                    textBoxCuvantG.Visible = true;
                    labelCuvantG.Visible = true;
                    Random litera = new Random() ;
                    int poz = litera.Next(0, SecretWord.Length - 1);
                for (i = 0; i < SecretWord.Length; i++)
                {
                    if (i == poz)
                        textBoxCuvantG.Text = textBoxCuvantG.Text + SecretWord.ToCharArray()[poz];
                        else
                            textBoxCuvantG.Text = textBoxCuvantG.Text + "_"; 
                            
                    }
                }
                else
                    MessageBox.Show("DOMENIUL NU A FOST ALES !");
            }
            private void buttonMasini_Click(object sender, EventArgs e)
            {
                domeniu = 1;
                labelDOMENIU.Visible = true;
                labelALEGETI.Visible = false;
                buttonCulori.Visible = false;
                buttonOrase.Visible = false;
            buttonCapitale.Visible = false;
            buttonTari.Visible = false;
            buttonAnimale.Visible = false;

            }

            private void buttonCulori_Click(object sender, EventArgs e)
            {
                domeniu = 2;
                labelDOMENIU.Visible = true;
                labelALEGETI.Visible = false;
                buttonMasini.Visible = false;
                buttonOrase.Visible = false;
                buttonAnimale.Visible = false;
                buttonTari.Visible = false;
                buttonCapitale.Visible = false;

            }

            private void buttonOrase_Click(object sender, EventArgs e)
            {


                domeniu = 3;
                labelDOMENIU.Visible = true;
                labelALEGETI.Visible = false;
                buttonCulori.Visible = false;
                buttonMasini.Visible = false;
                buttonAnimale.Visible = false;
                buttonTari.Visible = false;
                buttonCapitale.Visible = false;
        }
        private void ButtonTari_Click(object sender, EventArgs e)
        {
            domeniu = 4;
            labelDOMENIU.Visible = true;
            labelALEGETI.Visible = false;
            buttonCulori.Visible = false;
            buttonMasini.Visible = false;
            buttonAnimale.Visible = false;
            buttonOrase.Visible = false;
            buttonCapitale.Visible = false;

        }
        private void ButtonCapitale_Click(object sender, EventArgs e)
        {
            domeniu = 5;
            labelDOMENIU.Visible = true;
            labelALEGETI.Visible = false;
            buttonCulori.Visible = false;
            buttonMasini.Visible = false;
            buttonAnimale.Visible = false;
            buttonOrase.Visible = false;
            buttonTari.Visible = false;
        }
        private void ButtonAnimale_Click(object sender, EventArgs e)
        {
            domeniu = 6;
            labelDOMENIU.Visible = true;
            labelALEGETI.Visible = false;
            buttonCulori.Visible = false;
            buttonMasini.Visible = false;
            buttonTari.Visible = false;
            buttonOrase.Visible = false;
            buttonCapitale.Visible = false;
        }

        private void ButtonMUTE_Click(object sender, EventArgs e)
            {
                player.controls.stop();
            }

            private void ButtonIndiciu_Click(object sender, EventArgs e)
            {
                int i = 0;
                string a;
                a = Convert.ToString(SecretWord);

            }
        private void ButtonUNMUTE_Click(object sender, EventArgs e)
            {
                player.controls.play();
            }
            private void b_EXIT_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
        }
    
}
