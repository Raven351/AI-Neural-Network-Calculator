using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NNObjectsLib
{
    public class Neuron
    {
        public int WieghtsCount { get; set; }
        public ObservableCollection<double> Weights;

        public Neuron()
        {
            WieghtsCount = 0;
            Weights = new ObservableCollection<double>();
        }

        public void AddWeights()
        {

        }
    }
}
