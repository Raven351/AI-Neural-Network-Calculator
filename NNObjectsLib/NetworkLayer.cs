using System.Collections.Generic;

namespace NNObjectsLib
{
    class NetworkLayer
    {
        public int LayerNumber { get; set; }
        public int NeuronsCount { get; set; }
        public List<Neuron> NueronsList { get; set; }
    }
}
