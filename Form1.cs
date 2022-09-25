namespace AS2223_4G_INF_AngeliniAlex_RubricaCSV
{
    public partial class Form1 : Form
    {
        public string[] Nomi = new string[100];
        public string[] Cognomi = new string[100];
        public string[] Citta = new string[100];
        static int righe;
        static bool file;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog finestrafile = new OpenFileDialog();

            //apertura della finestra del file
            if(finestrafile.ShowDialog() == DialogResult.OK) 
            { 
                //una volta selezionato il file, il suo indirizzo viene scritto nella textbox "txtFile"
                txtFile.Text = finestrafile.FileName;
                file = true;
            }
            StreamReader fi = new StreamReader(finestrafile.FileName);

            //legge il numero delle righe presenti nel file e conta quante righe ci sono nel file
            righe = File.ReadLines(finestrafile.FileName).Count();

            for(int i = 0; i < righe; i++) 
            {
                //creo un array temporaneo in cui salvo i valori
                string[] brray = new string[3];

                //salvo le prime righe del file
                string infoPersone = fi.ReadLine();

                //separa le varie parole
                brray = infoPersone.Split(';');

                //salvo i valori negli appositi array
                Nomi[i] = brray[0]; //Mauro
                Cognomi[i] = brray[1]; //Rossi
                Citta[i] = brray[2]; //Rimini
            }

        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            if (file == true) 
            {            
                //leggo l'opzione inserita del combobox
                string combobox = cmbCognome.Text;
                if (combobox == "")
                {
                    MessageBox.Show("Inserisci un'opzione");
                    return;

                }

                //leggo la textbox "Cognome"
                string Cognome = txtCognome.Text;
                if(Cognome == "") 
                {
                    MessageBox.Show("Inserisci una lettera");
                    return;
            
                }

                //Inizia per:
                if(cmbCognome.Text == "Inizia per:") 
                {
                    lstElenco.Items.Clear();
                    for(int i = 0; i < righe; i++) 
                    {
                        //aggiunta della parole che iniziano per "x"
                        if (Cognomi[i].ToUpper().StartsWith(Cognome.ToUpper())) 
                        {
                            lstElenco.Items.Add(Nomi[i] + " " + Cognomi[i] + " " + Citta[i] + " ");                
                        }  
                    }
                }

                //Contiene:
                if (cmbCognome.Text == "Contiene:")
                {
                    lstElenco.Items.Clear();
                    for (int i = 0; i < righe; i++)
                    {
                        //aggiunta della parole che contengono "x"
                        if (Cognomi[i].ToUpper().Contains(Cognome.ToUpper()))
                        {
                            lstElenco.Items.Add(Nomi[i] + " " + Cognomi[i] + " " + Citta[i] + " ");
                        }
                    }
                }

                //Finisce per:
                if (cmbCognome.Text == "Finisce per:")
                {
                    lstElenco.Items.Clear();
                    for (int i = 0; i < righe; i++)
                    {
                        //aggiunta della parole che finiscono per "x"
                        if (Cognomi[i].ToUpper().EndsWith(Cognome.ToUpper()))
                        {
                            lstElenco.Items.Add(Nomi[i] + " " + Cognomi[i] + " " + Citta[i] + " ");
                        }
                    }
                }
            }
            else 
            {
                //il file non è stato inserito
                MessageBox.Show("Inserisci un file valido.");
            }
            
        }
    }
}