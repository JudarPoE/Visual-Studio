using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fehlzeiten
{
    public partial class Form1 : Form
    {
        List<Schüler> PersonenListe = new List<Schüler>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Button_SchülerAnlegen(object sender, EventArgs e)
        {
            if (TextBox_Name_Schülerverwalten.Text != "" && TextBox_Vorname_Schülerverwalten.Text != "")
            {
                Schüler einSchüler = new Schüler(TextBox_Name_Schülerverwalten.Text, TextBox_Vorname_Schülerverwalten.Text, Convert.ToDateTime(DateTimePicker_Schülerverwalten.Text), Convert.ToDouble(NumericUpDown_Anfahrt_Schülerverwalten.Text), CheckBox_Buskarte_Schülerverwalten.Checked);
                PersonenListe.Add(einSchüler);

                TextBox_Name_Schülerverwalten.Text = "";
                TextBox_Vorname_Schülerverwalten.Text = "";
                DateTimePicker_Schülerverwalten.Text = "";
                NumericUpDown_Anfahrt_Schülerverwalten.Text = "";
                CheckBox_Buskarte_Schülerverwalten.Checked = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox mit Schülern füllen
            ComboBox_Schüler_Fehlzeitenverwalten.DataSource = PersonenListe;
            ComboBox_Schüler_Fehlzeitenverwalten.DisplayMember = "Name"; // Hier "Name" durch den tatsächlichen Eigenschaftsnamen ersetzen
        }

        private void ComboBox_Schüler_Fehlzeitenverwalten_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hier können Sie bei Bedarf weitere Aktionen ausführen, wenn ein anderer Schüler ausgewählt wird
        }
    }
}
