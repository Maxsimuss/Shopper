using System.Text.Json;

namespace Shopper
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private List<KeyValuePair<string, double>> produkti = new List<KeyValuePair<string, double>>();

        public Form1()
        {
            InitializeComponent();

            form2 = new Form2();
            form2.Parent = this;
        }

        private void RecalculateSum()
        {
            double summa = 0;
            foreach (var produkts in produkti)
            {
                summa += produkts.Value;
            }

            Summa.Text = "Summa: " + summa.ToString("0.##") + " Eur";
        }

        public void AddProduct(string nosaukums, double cena)
        {
            produkti.Add(new KeyValuePair<string, double>(nosaukums, cena));
            ProductList.Items.Add(nosaukums + " (" + cena.ToString("0.##") + " Eur)");
            RecalculateSum();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            form2.Show();
            form2.Focus();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ProductList.SelectedIndex >= 0 && ProductList.SelectedIndex < ProductList.Items.Count)
            {
                produkti.RemoveAt(ProductList.SelectedIndex);
                ProductList.Items.RemoveAt(ProductList.SelectedIndex);
                RecalculateSum();
            }
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Produkti|*.produkti";
            dialog.Title = "Atvērt";
            dialog.ShowDialog();

            if (dialog.FileName != "")
            {
                string json = File.ReadAllText(dialog.FileName);
                produkti = JsonSerializer.Deserialize<List<KeyValuePair<string, double>>>(json);
                if (produkti == null)
                {
                    throw new Exception();
                }

                ProductList.Items.Clear();
                foreach (var produkts in produkti)
                {
                    ProductList.Items.Add(produkts.Key + " (" + produkts.Value.ToString("0.##") + " Eur)");
                }

                RecalculateSum();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Produkti|*.produkti";
            dialog.Title = "Saglabāt";
            dialog.ShowDialog();

            if (dialog.FileName != "")
            {
                string json = JsonSerializer.Serialize(produkti);
                File.WriteAllText(dialog.FileName, json);
            }
        }
    }
}