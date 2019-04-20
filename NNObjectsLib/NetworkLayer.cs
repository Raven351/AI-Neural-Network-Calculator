using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NNObjectsLib
{
    /// <summary>
    /// Represents network layer in neural network.
    /// </summary>
    public class NetworkLayer
    {
        #region PROPERTIES
        public int LayerNumber { get; set; }
        public int NeuronsCount { get; set; }
        public ObservableCollection<Neuron> NeuronsList { get; set; }
        #endregion

        #region CONSTRUCTORS
        public NetworkLayer()
        {
            NeuronsList = new ObservableCollection<Neuron>();
        }

        public NetworkLayer(int layerNumber) : this()
        {
            LayerNumber = layerNumber;
        }
        #endregion
    }
}
