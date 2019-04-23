using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NNObjectsLib
{
    public class Calculator
    {

        #region STATIC METHODS
        /// <summary>
        /// Returns NET value of given neuron. 
        /// </summary>
        /// <param name="vectors">Collection of input vectors. Must be even with weights of given neuron</param>
        /// <param name="neuron">Neuron object containing collectio of weights. Weights count must be even with number of input vectors</param>
        /// <param name="bias">Bias value</param>
        /// <returns>NET value</returns>
        public static double NetValue(Neuron neuron, Collection<double> vectors, double bias)
        {
            //NET = x1w1 + x2w2 + ... + xnwn + BIAS
            //ex. x1 = 1; x2 = -0.5; x3 = 1.5
            //    w1 = 1; w2 = 2; w3 = 3
            //    bias = -5
            // NET = 1-1+4.5-5 = -0.5
            double sum = bias;
            for (int i = 0; i < neuron.Weights.Count; i++)
            {
                sum += neuron.Weights[i] * vectors[i];
            }
            return sum;
        }

        /// <summary>
        /// Checks if NET value of give neuron can be counted with collection of given vectors. 
        /// </summary>
        /// <param name="neuron">Neoron type object</param>
        /// <param name="vectors">Collection of vectors</param>
        /// <returns></returns>
        public static bool IsNetCountable(Neuron neuron, Collection<double> vectors)
        {
            return neuron.Weights.Count == vectors.Count;
        }

        public static int DiscreteUnipolar(double netValue)
        {
            return netValue >= 0 ? 1 : 0;
        }

        public static int DisreteBipolar(double netValue)
        {
            return netValue >= 0 ? 1 : -1;
        }

        public static double ContinuousUnipolar(double netValue)
        {
            return (1 / (1 + (Math.Pow(Math.E, - netValue))));
        }

        public static double ContinuousBipolar(double netValue)
        {
            return (2 / (1 + (Math.Pow(Math.E, -netValue)))) - 1;
        }


        private void NetValue(NetworkLayer networkLayer, NetworkLayer previousLayer, double bias)
        {
            Collection<double> vector = new Collection<double>();
            foreach (Neuron neuron in previousLayer.NeuronsList) vector.Add(neuron.NetValue);
            foreach (Neuron neuron in networkLayer.NeuronsList) neuron.NetValue = NetValue(neuron, vector, bias);
        }

        private void NetValue(NetworkLayer networkLayer, Collection<double> inputVector, double bias)
        {
            foreach (Neuron neuron in networkLayer.NeuronsList) neuron.NetValue = NetValue(neuron, inputVector, bias);
        }

        private void NetValue(NeuralNetwork neuralNetwork)
        {
            for (int i = 0; i < neuralNetwork.Layers.Count; i++) // for every layer in neural network
            {
                if (i == 0)
                {
                    NetValue(neuralNetwork.Layers[i], neuralNetwork.Vectors, neuralNetwork.Bias);
                }
                else
                {
                    NetValue(neuralNetwork.Layers[i], neuralNetwork.Layers[i - 1], neuralNetwork.Bias);
                }
            }
        }

        // there can be more than 1 output signals!
        public static Collection<int> DiscreteUnipolar(NeuralNetwork neuralNetwork) //can be 0 or 1
        {
            Collection<int> outputSignal = new Collection<int>();
            foreach (Neuron neuron in neuralNetwork.Layers[neuralNetwork.Layers.Count].NeuronsList)
            {
                outputSignal.Add(DiscreteUnipolar(neuron.NetValue));
            }
            return outputSignal;
        }



        #endregion
    }
}
