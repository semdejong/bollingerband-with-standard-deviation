using System;
using System.Collections.Generic;

namespace bollingbandhelper
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double[] datapointsArray = { 86.16, 89.09, 88.78, 90.32, 89.07, 91.15, 89.44, 89.18, 86.93, 87.68, 86.96, 89.43, 89.32, 88.72, 87.45, 87.26, 89.50, 87.90, 89.13, 90.70};

            List<double> datapoints = new List<double>();

            foreach(double datapointInArray in datapointsArray)
            {
                datapoints.Add(datapointInArray);
            }

            double avg = 0;

            foreach (double datapoint in datapoints)
            {
                avg += datapoint;
            }



            avg = avg / datapoints.Count;

            avg = 88.71;


            double DiffMeanVSDatapointSQCount = 0;

            foreach(double datapoint in datapoints)
            {
                double diff;

                if(datapoint > avg)
                {
                    diff = datapoint - avg;
                }
                else
                {
                    diff = avg - datapoint;
                }

                diff = Math.Pow(diff, 2);

                //Console.WriteLine(diff);

                DiffMeanVSDatapointSQCount = DiffMeanVSDatapointSQCount + diff;
            }

            double BollingBandResult = Math.Sqrt(DiffMeanVSDatapointSQCount / datapoints.Count);

            Console.WriteLine($"Bovenste 'Band' = {avg + (2 * BollingBandResult)}");
            Console.WriteLine($"Middelste moving average = {avg}");
            Console.WriteLine($"Onderste 'Band' = {avg - (2 * BollingBandResult)}");
            Console.ReadKey();


        }
    }
}
