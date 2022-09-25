namespace AS2223_4G_INF_AngeliniAlex_RubricaCSV
{
    public partial class Form1 : Form
    {
        public string[] infoPersone = new string[100];
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
            }
            StreamReader fi = new StreamReader(finestrafile.FileName);

            //legge il numero delle righe presenti nel file e conta quante righe ci sono nel file
            int righe = File.ReadLines(finestrafile.FileName).Count();

            for(int i = 0; i < righe; i++) 
            {
                infoPersone[i] = fi.ReadLine();
            
            
            }

        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            //leggo l'opzione del combobox
            string combobox = cmbCognome.Text;
            //leggo la textbox Cognome
            string Cognome = txtCognome.Text;
        }
    }
}