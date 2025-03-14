using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KargoTakipUygulamasi.UI.Data
{
    public class Nakliyeci
    {
        public void KargoyuTasi(string kargoNo)
        {
            MessageBox.Show(kargoNo + " nolu kargo adresinize teslim edilmek üzere dağıtıma çıkmıştır.");
        }
    }
}

