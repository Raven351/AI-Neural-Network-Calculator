using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NNObjectsLib
{
    public class NeuralNetworks
    {
        #region PROPERTIES
        public ObservableCollection<NeuralNetwork> NeuralNetworksList { get; set; }
        #endregion

        #region CONSTRUCORS
        public NeuralNetworks()
        {
            NeuralNetworksList = new ObservableCollection<NeuralNetwork>();
        }
        #endregion

        #region INDEXER
        public NeuralNetwork this[int index]
        {
            get => NeuralNetworksList[index];
            set => NeuralNetworksList[index] = value;
        }
        #endregion

    }
}
