using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.DataModel
{
    public class ImagePrediction : ImageData
    {
        public float[] Score;

        public string PredictedLabelValue;
    }
}
