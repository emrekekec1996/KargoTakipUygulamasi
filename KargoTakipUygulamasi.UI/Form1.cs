using KargoTakipUygulamasi.UI.Data;

namespace KargoTakipUygulamasi.UI
{
    public partial class Form1 : Form
    {
        Nakliyeci nakliyeci = new Nakliyeci();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNoAta_Click(object sender, EventArgs e)
        {

            try
            {
                //Yazýlan kargo numarasý geçerli ise daðýtýma çýkacak!
                Kargo kargo = new Kargo();
                kargo.DagitimaCikar += nakliyeci.KargoyuTasi;
                kargo.KargoNo = txtKargo.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }


        }
    }
}
