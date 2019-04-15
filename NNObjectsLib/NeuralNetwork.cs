using System;
using System.Collections.Generic;
using System.Text;

namespace NNObjectsLib
{
    class NeuralNetwork
    {
        #region CONSTRUCTORS
        /// <summary>
        /// Creates default neuron network object.
        /// </summary>
        public NeuralNetwork()
        {
            Vectors = new List<double>();
            Layers = new List<NetworkLayer>();
        }

        public NeuralNetwork(int vectorsCount, int layersCount, List<double> vectors, double bias, List<NetworkLayer> layers)
        {
            VectorsCount = vectorsCount;
            LayersCount = layersCount;
            Vectors = vectors;
            Bias = bias;
            Layers = layers;
        }
        #endregion

        #region PROPS
        public int VectorsCount { get; set; }
        public int LayersCount { get; set; }
        public List<double> Vectors { get; set; }
        public double Bias { get; set; }
        public List<NetworkLayer> Layers { get; set; }
        #endregion
    }
}
