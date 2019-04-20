using System;
using System.Collections.Generic;
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
            Vectors = new List<double>();
            Layers = new List<NetworkLayer>();
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
        public List<double> Vectors { get; set; }
        public double Bias { get; set; }
        public List<NetworkLayer> Layers { get; set; }
        #endregion
    }
}
