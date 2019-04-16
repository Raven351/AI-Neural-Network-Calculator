using NNObjectsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SINeuralNetworkCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region FIELDS
        private Neurons _neurons = new Neurons();
        private Neuron _selectedNeuron = new Neuron();
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            weightsListView.ItemsSource = _selectedNeuron.Weights; //todo
            
        }


        #region XAML EVENTS
        private void AddWeightButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateNeuronButton_Click(object sender, RoutedEventArgs e)
        {
            var neuron = new Neuron();
            _selectedNeuron = neuron;
            _neurons.NeuronsList.Add(_selectedNeuron);
            inputWeightTextBox.Clear();
        }

        private void InputWeightTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        #endregion

        #region METHODS

        #endregion

        private void InputWeightTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.Key;
            e.Handled = !(key >= (int)Key.D0 && key <= (int)Key.D9 || key >= (int)Key.NumPad0 && key <= (int)Key.NumPad9 || key == (int)Key.Back); //only numeric keys and backspace allowed
        }
    }
}
