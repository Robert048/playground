using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsm
{
    public partial class Grafiek : Form
    {
        // Database ophalen en laden in een array?
        private List<int> rowList = new List<int>();

        private void Form2_Load(object sender, EventArgs e)
        {
            updateAll();
            getLastUpdateTime();
            toolStripLabel1.Text = "last update: "/*+ lastUpdateTime + ""*/;
        }

        // Voorbeeld/Test methode
        private void getLastUpdateTime()
        {
            // Database script verversing tijd ophalen
            // lastUpdateTime = Database.getLastUpdateTime
        }

        public Grafiek()
        {
            InitializeComponent();
            chart1.Show();
            chart1.Visible = true;
        }

        private void loadDatabase()
        {
            // Test database, Echte database moet nog gerealiseerd worden
            /////////////////////////////////////
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                int value = random.Next(1, 20);
                Console.WriteLine(value);
                rowList.Add(value);
            }
            /////////////////////////////////////
        }

        private void updateAll()
        {
            /*
             * 1 Clear all entry's
             * 2 Schoonmaken van alle gebruikte variabelen
             * 3 Nieuwe database ophalen
             * 4 Nieuwe database verwerken en weergeven
             * 5 De laatste update tijd weergeven
             * */
            chart1.Series.Clear();          // Chart lijnen verwijderen
            rowList.Clear();                // List rowList legen
            loadDatabase();                 // Database laden
            updateChart();                  // Nieuwe grafiek tekenen met de nieuwe waardes
            toolStripLabel1.Text = "last update: "/*+ lastUpdateTime + ""*/;
        }


        public void updateChart()
        {
            // Nieuwe serie/grafiek toevoegen
            chart1.Series.Add("Temperatuur");

            // Type grafiek definiëren
            chart1.Series["Temperatuur"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;     // Maximale temperatuur

            // Waardes toevoegen aan de grafiek/chart
            int i = 0;
            foreach (int temp in rowList)
            {
                chart1.Series["Temperatuur"].Points.AddXY(i, temp);
                i+=1;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Updaten van alle informatie binnen de grafiek:
            updateAll();
        }

        //Updaten van de laatste tijd dat de database is upgehaald.
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //private String lastUpdateTime = (Database klasse).getLastUpdateTime();
        }

        private void saveChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opslaan functie moet nog worden verwerkt (onderzoek wordt op dit moment gedaan)
        }

        private void closeChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sluit het venster
            // Mogelijk moet een prompt komen om te vragen of de gebruiker wil opslaan of niet
            this.Close();
        }
    }
}
