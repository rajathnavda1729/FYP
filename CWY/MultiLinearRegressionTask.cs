using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CWY
{
    public class MultiLinearRegressionTask
    {
        public Dictionary<string, double> GetWeights(List<Sample> samples)
        {
            int nAttributes = 13;
            int nSamples = samples.Count;
            double[,] tsData = new double[nSamples, nAttributes];
            double[] resultData = new double[nSamples];

            for (int i = 0; i < samples.Count; i++)
            {
                tsData[i, 0] = samples[i].Precipitation;
                tsData[i, 1] = samples[i].SoilWatFieldCapacity;
                tsData[i, 2] = samples[i].Swawp;
                tsData[i, 3] = samples[i].SoilWaterStorage;
                tsData[i, 4] = samples[i].IrrigationEfficiency;
                tsData[i, 5] = samples[i].MaxYield;
                tsData[i, 6] = samples[i].GrossIrrig;
                tsData[i, 7] = samples[i].InputCosts;
                tsData[i, 8] = samples[i].OperationCosts;
                tsData[i, 9] = samples[i].MiscCosts;
                tsData[i, 10] = samples[i].IrrigCosts;
                tsData[i, 11] = samples[i].MiscReturns;
                tsData[i, 6] = samples[i].TotalIrrig;
                tsData[i, 13] = samples[i].PriceUnit;

                resultData[i] = samples[i].Yield;
            }

            double[] weights = null;
            int fitResult = 0;
            alglib.lsfit.lsfitreport rep = new alglib.lsfit.lsfitreport();
            alglib.lsfit.lsfitlinear(resultData, tsData, nSamples, nAttributes, ref fitResult, ref weights, rep);

            Dictionary<string, double> labelsAndWeights = new Dictionary<string, double>();
            labelsAndWeights.Add("Precipitation", weights[0]);
            labelsAndWeights.Add("SoilWatFieldCapacity", weights[1]);
            labelsAndWeights.Add("Swawp", weights[2]);
            labelsAndWeights.Add("SoilWaterStorage", weights[2]);
            labelsAndWeights.Add("IrrigationEfficiency", weights[3]);  
            labelsAndWeights.Add("MaxYield", weights[4]);
            labelsAndWeights.Add("GrossIrrig", weights[5]);
            labelsAndWeights.Add("InputCosts", weights[6]);
            labelsAndWeights.Add("OperationCosts", weights[7]);
            labelsAndWeights.Add("MiscCosts", weights[8]);
            labelsAndWeights.Add("IrrigCosts", weights[9]);
            labelsAndWeights.Add("MiscReturns", weights[10]);
            labelsAndWeights.Add("TotalIrrig", weights[11]);
            labelsAndWeights.Add("PriceUnit", weights[12]);

            return labelsAndWeights;
        }
    }
}
