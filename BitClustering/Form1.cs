using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitseriesType = System.Collections.Generic.List<int>;//user defined type
using RawDataType = System.Collections.Generic.List<double>;//user defined type for the raw data
namespace BitClustering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_algorithm1_Click(object sender, EventArgs e)
        {
            //get values frome user:
            int N_LENGTH, W_LENGTH, K_CENTERS;
            string file_name;
            getValuesFromUsers(out N_LENGTH, out W_LENGTH, out K_CENTERS, out file_name);

            
            //Done
            Console.WriteLine(this.Text + " : Done. Do nothing ! Just testing.");
        }

        private void btn_algorithm2_Click(object sender, EventArgs e)
        {
            
            //get values frome user:
            int N_LENGTH, W_LENGTH, K_CENTERS;
            string file_name;

            //starting time
            getValuesFromUsers(out N_LENGTH, out W_LENGTH, out K_CENTERS, out file_name);

            var watch = System.Diagnostics.Stopwatch.StartNew();///calc execution time
            //call algorithm2
            Console.WriteLine("Calling Algorithm 2...");
            RawDataType data;
            Tuple<double, int> result = BitClusterDiscord.bitClusterDiscord(out data, N_LENGTH, W_LENGTH, K_CENTERS, file_name);



            watch.Stop();//stop timer
            var elapsedMs = watch.ElapsedMilliseconds;


            this.txt_time.Text = elapsedMs.ToString();
            this.best_so_far_dist_txt.Text = result.Item1.ToString();
            this.best_so_far_loc_txt.Text = result.Item2.ToString();

            Console.WriteLine("Writing to file...");
            IOFunctions.writeFile(data, N_LENGTH, result.Item2);
            //Done
            Console.WriteLine(this.Text + " : Done Algorithm 2. Best_so_far_loc = "+ result.Item2 +". Time: "+ elapsedMs);
        }
    }
}
