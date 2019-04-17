using System.Collections.Generic;

namespace NNObjectsLib
{
    /// <summary>
    /// Represents network layer in neural network.
    /// </summary>
    class NetworkLayer
    {
        public int LayerNumber { get; set; }
        public int NeuronsCount { get; set; }
        public List<Neuron> NueronsList { get; set; }
    }
}
