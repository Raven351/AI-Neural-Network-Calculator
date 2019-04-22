using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NNObjectsLib
{
    public class NeuralNetwork
    {
        #region CONSTRUCTORS
        /// <summary>
        /// Creates default neuron network object.
        /// </summary>
        public NeuralNetwork()
        {
            Vectors = new ObservableCollection<double>();
            Layers = new ObservableCollection<NetworkLayer>();
        }

        public NeuralNetwork(int layersCount, double bias) : this()
        {
            LayersCount = layersCount;
            Bias = bias;
            for (int i = 0; i<layersCount; i++)
            {
                Layers.Add(new NetworkLayer(i+1));
            }
        }


        #endregion

        #region PROPS
        public int VectorsCount { get; set; }
        public int LayersCount { get; set; }
        public ObservableCollection<double> Vectors { get; set; }
        public double Bias { get; set; }
        public ObservableCollection<NetworkLayer> Layers { get; set; }
        #endregion
    }
}
