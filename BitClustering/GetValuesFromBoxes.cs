using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitClustering
{
    public partial class Form1
    {
        private void getValuesFromUsers(out int N_LENGTH, out int W_LENGTH, out int K_CENTERS, out string file_name)
        {
            N_LENGTH = Convert.ToInt16(this.txt_N_LENGTH.Text);
            W_LENGTH = Convert.ToInt16(this.txt_W_LENGTH.Text);
            K_CENTERS = Convert.ToInt16(this.txt_K_CENTERS.Text);
            file_name = this.txt_FileName.Text;
        }
    }
}
