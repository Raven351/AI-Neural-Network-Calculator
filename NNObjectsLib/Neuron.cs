using System.Collections.Generic;

namespace NNObjectsLib
{
    class Neuron
    {
        public int NeuronNumber { get; set; }
        public int WieghtsCount { get; set; }
        public List<double> Weights;

        public Neuron(int neuronNumber)
        {
            NeuronNumber = neuronNumber;
            WieghtsCount = 0;
            Weights = new List<double>();
        }

        public void AddWeights()
        {

        }
    }
}
