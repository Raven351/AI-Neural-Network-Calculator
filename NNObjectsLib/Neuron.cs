using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace NNObjectsLib
{
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
        public ObservableCollection<PrimitiveWrapper> Weights2;
        #endregion

        #region CONSTRUCTORS
        public Neuron()
        {
            WeightsCount = 0;
            Weights = new ObservableCollection<double>();
        }

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
