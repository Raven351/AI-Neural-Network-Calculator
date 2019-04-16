using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NNObjectsLib
{
    public class Neurons
    {
        #region PROPERTIES
        public ObservableCollection<Neuron> NeuronsList { get; set; }
        #endregion

        #region CONSTRUCTORS
        public Neurons()
        {
            NeuronsList = new ObservableCollection<Neuron>();
        }
        #endregion

        #region INDEXER
        public Neuron this[int index]
        {
            get => NeuronsList[index];

            set => NeuronsList[index] = value;
        }
        #endregion
    }
}
