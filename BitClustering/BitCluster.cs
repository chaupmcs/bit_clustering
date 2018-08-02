using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitseriesType = System.Collections.Generic.List<int>;//user defined type
using RawDataType = System.Collections.Generic.List<double>;//user defined type for the raw data


namespace BitClustering
{
    class BitCluster
    {
        static private List<int> getKRandomCenter(int bit_series_data_length, int NUMBER_OF_CENTERS)
        {
            List<int> k_centers = new List<int>(); //store K_centers
            Random r = new Random();
            
            while (k_centers.Count < NUMBER_OF_CENTERS)
            {
                int index = r.Next(bit_series_data_length);
                if (k_centers.Contains(index) == false)
                {
                    k_centers.Add(index);
                }
            }

            return k_centers;
        }

        static public List<int> getKCentersContinuously(int NUMBER_OF_CENTERS)
        {
            List<int> k_indice = new List<int>();

            for (int i = 0; i < NUMBER_OF_CENTERS; i++)
                k_indice.Add(i);
            return k_indice;
        }

        static public void bitCluster(out List<Cluster> b_cluster, out List<int> cluster_belong, int K_CENTERS, int N_LENGTH, int W_LENGTH, string file_name)                        
        {

            //read data 
            RawDataType data = IOFunctions.readFile(file_name);

            Dictionary<int, BitseriesType> bit_series_data;//store Bit series data

            bit_series_data = HelperFunctions.bitSeriesDataset(data, N_LENGTH, W_LENGTH);//get bit series data from original data


            //set some variables:
            int bit_series_data_length = bit_series_data.Count;



            b_cluster = new List<Cluster>();//store k clusters

            List<int> k_centers;//store k centers

            cluster_belong = new List<int>(); //store the cluster whose each point belong to

            double dist_i, dist_p;

            for (int i=0; i < bit_series_data_length; i++)
            {
                cluster_belong.Add(-1);
            }

            //initialize K centers
            k_centers = getKRandomCenter(bit_series_data_length, K_CENTERS);
            //k_centers = getKCentersContinuously(K_CENTERS);



            //(line 1 - 4 of the paper): initialize k cluster, then append them to 'b_cluster' 
            for (int i = 0; i < K_CENTERS; i++)
            {
                Cluster one_cluster = new Cluster(k_centers[i], 1);
                b_cluster.Add(one_cluster);
            }   
            

            //(line 5-15 in the paper): 
            for (int j=0; j < bit_series_data_length; j++)//go through the BD data
            {
                //get each element:
                if (cluster_belong[j] == (-1)) //if the point hasn't belong any cluster yet
                {
                    int p = 0;
                    for (int i = 1; i < K_CENTERS; i++)
                    {
                        dist_i = HelperFunctions.bitSeriesDistance(bit_series_data[j], bit_series_data[b_cluster[i].getCenterIndex()]);
                        dist_p = HelperFunctions.bitSeriesDistance(bit_series_data[j], bit_series_data[b_cluster[p].getCenterIndex()]);


                        if (dist_i < dist_p)
                            p = i;
                    }//end for

                    // line 12-14 in the paper
                    cluster_belong[j] = p;
                    b_cluster[p].plusOneToNumberOfMembers();
                    b_cluster[p].addToListMemberIndice(j);

                }
            }//end of for

            double radius;
            List<double> center_value;
            for (int i=0; i <K_CENTERS; i++)
            {
                center_value = data.GetRange(b_cluster[i].getCenterIndex(), N_LENGTH);
                radius = HelperFunctions.calculateRadius(data, b_cluster[i].getListMemberIndice(), center_value, N_LENGTH);
                b_cluster[i].setRadius(radius);
            }

        }//end of function
    }
}
