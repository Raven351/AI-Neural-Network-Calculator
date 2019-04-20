using NNObjectsLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private readonly Neurons _neurons = new Neurons();
        private readonly NeuralNetworks _neuralNetworks = new NeuralNetworks();
        #endregion

        public MainWindow()
        {
            InitializeComponent();
            InitializeViews();
            
        }

       
        private void AddWeightButton_Click(object sender, RoutedEventArgs e)
        {
            _neurons[neuronsListView.SelectedIndex].Weights.Add(double.Parse(inputWeightTextBox.Text));
            _neurons[neuronsListView.SelectedIndex].WeightsCount += 1;
            inputWeightTextBox.Clear();
        }

        private void CreateNeuronButton_Click(object sender, RoutedEventArgs e)
        {
            var neuron = new Neuron(double.Parse(inputWeightTextBox.Text));
            neuron.WeightsCount += 1; //should use event, for testing purposes
            _neurons.NeuronsList.Add(neuron);
            neuronsListView.SelectedIndex = _neurons.NeuronsList.Count - 1;
            inputWeightTextBox.Clear();
            weightsListView.ItemsSource = _neurons[neuronsListView.SelectedIndex].Weights; //selected neuron
        }

        private void InputWeightTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void InputWeightTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            int key = (int)e.Key;
            e.Handled = !(key >= (int)Key.D0 && key <= (int)Key.D9 || key >= (int)Key.NumPad0 && key <= (int)Key.NumPad9 || key == (int)Key.Back); //only numeric keys and backspace allowed
        }

        private void NeuronsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            weightsListView.ItemsSource = _neurons[neuronsListView.SelectedIndex].Weights; // selected neuron
        }

        private void InputWeightTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            addWeightButton.IsEnabled = inputWeightTextBox.Text.Length > 0 && neuronsListView.SelectedItem != null;
        }

        private void InitializeViews()
        {
            neuronsListView.ItemsSource = _neurons.NeuronsList;
            neuronsListViewNeuralNetworkCreator.ItemsSource = _neurons.NeuronsList;
            neuralNetworksTreeView.ItemsSource = _neuralNetworks.NeuralNetworksList;
            
        }

        private void CreateNeuralNetworkButton_click(object sender, RoutedEventArgs e)
        {
            var neuralNetwork = new NeuralNetwork(int.Parse(layersCountTextBox.Text), double.Parse(biasTextBox.Text));
            _neuralNetworks.NeuralNetworksList.Add(neuralNetwork);
            layersCountTextBox.Clear();
            biasTextBox.Clear();
        }
    }
}
