using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BitseriesType = System.Collections.Generic.List<int>;//user defined type 
using RawDataType = System.Collections.Generic.List<double>;//user defined type for the raw data

namespace BitClustering
{
    class HelperFunctions
    {
        static public double gaussDistance(RawDataType t1, RawDataType t2)
        {
            double dist = Math.Sqrt(t1.Zip(t2, (a, b) => (a - b) * (a - b)).Sum());
            return dist;
        }


        static public double bitSeriesDistance(BitseriesType s1, BitseriesType s2)
        {
            double dist = (s1.Zip(s2, (a, b) => (a - b) * (a - b)).Sum()) / (double)(s1.Count);
            return dist;
        }

        static public double calculateRadius(RawDataType data, List<int> list_members_index, RawDataType center_value, int N_LENGTH)
        {
            double max_dis = 0;
            double cur_dis = 0;
            foreach (int element_index in list_members_index)
            {
                cur_dis = HelperFunctions.gaussDistance(data.GetRange(element_index, N_LENGTH), center_value);
                if (max_dis < cur_dis)
                    max_dis = cur_dis;
            }
            return max_dis;
        }


        static public Dictionary<int, BitseriesType> bitSeriesDataset(RawDataType data, int N_LENGTH, int W_LENGTH)
        {
            Dictionary<int, BitseriesType> bit_series_data = new Dictionary<int, BitseriesType>();//store Bit series data

            RawDataType sub_data = new RawDataType();//sub N_LENGTH timeseries data, 

            List<double> sub_PAA = new List<double>(); // convert to PAA

            if (N_LENGTH % W_LENGTH != 0)
            {
                for (int index_data = 0; index_data + N_LENGTH <= data.Count; index_data++)
                {
                    sub_data = data.GetRange(index_data, N_LENGTH);//get the sub_timeseries
                    
                    BitseriesType sub_BitData = new BitseriesType(); // convert to BitSeriesData
                    sub_PAA.Clear();
                    for (int i = 0; i < W_LENGTH; i++)
                        sub_PAA.Add(0);//set initial value for C_w

                    //calculate PAA
                    for (int i = 0; i < N_LENGTH * W_LENGTH; i++)
                    {
                        sub_PAA[i / N_LENGTH] += sub_data[i / W_LENGTH];
                    }

                    for (int i = 1; i < W_LENGTH; i++)
                    {
                        if (sub_PAA.ElementAt(i) > sub_PAA.ElementAt(i - 1))
                            sub_BitData.Add(1);
                        else
                            sub_BitData.Add(0);
                    }

                    bit_series_data.Add(index_data, sub_BitData);

                }
            }
            //go through timeseries by the "N_LENGTH" window 

            else
            {
                double sub_w_i;
                int from_index, to_index;
                
                for (int index_data = 0; index_data + N_LENGTH <= data.Count; index_data++)
                {
                    sub_PAA.Clear();//reset 
                    sub_data = data.GetRange(index_data, N_LENGTH);//get the sub_timeseries
                    List<int> sub_BitData = new List<int>(); // convert to BitSeriesData

                    //Calculate w 
                    for (int index_w = 0; index_w < W_LENGTH; index_w++)
                    {
                        from_index = (N_LENGTH / W_LENGTH) * index_w;
                        to_index = (N_LENGTH / W_LENGTH) * (index_w + 1) - 1;

                        sub_w_i = 0;
                        for (int i = from_index; i <= to_index; i++)
                        {
                            sub_w_i += sub_data.ElementAt(i);
                        }
                        sub_w_i = sub_w_i * (W_LENGTH / (double)(N_LENGTH));

                        sub_PAA.Add(sub_w_i);
                    }


                    for (int i = 1; i < W_LENGTH; i++)
                    {
                        if (sub_PAA.ElementAt(i) > sub_PAA.ElementAt(i - 1))
                            sub_BitData.Add(1);
                        else
                            sub_BitData.Add(0);
                    }

                    bit_series_data.Add(index_data, sub_BitData);
                }//end for
            }//end else

            return bit_series_data;
        }//end function

        
    }//end class

}//end file

