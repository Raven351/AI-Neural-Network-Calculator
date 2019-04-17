using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace NNObjectsLib
{
    /// <summary>
    /// Represents neuron in neural network.
    /// </summary>
    public class Neuron : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region FIELDS
        private int _weightsCount;
        #endregion

        #region PROPERTIES
        public int WeightsCount
        {
            get => _weightsCount;
            set
            {
                _weightsCount = value;
                OnPropertyChanged("WeightsCount");
            }
        }
        public ObservableCollection<double> Weights;
        #endregion

        #region CONSTRUCTORS
        /// <summary>
        /// Creates neuron object without any values.
        /// </summary>
        public Neuron()
        {
            WeightsCount = 0;
            Weights = new ObservableCollection<double>();
        }

        /// <summary>
        /// Creates neuron object with given weight.
        /// </summary>
        /// <param name="weight">Weight value</param>
        public Neuron(double weight)
        {
            WeightsCount = 0;
            Weights = new ObservableCollection<double>
            {
                weight
            };
        }
        #endregion

        public void AddWeights()
        {

        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
