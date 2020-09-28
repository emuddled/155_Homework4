/// Homework No. 4		Exercise Part 1
/// File Name: BMIGUI
/// @author: Evan Sinclair
/// Date:  Sept 26, 2020
///
/// Problem Statement:Write a program that calculates a person’s BMI and prints a message telling
/// whether they below, within, or above the healthy range.  Include a color element of blue (below), 
/// green(within), yellow (above).Use a GUI for the input and output.Show the calculated BMI score in the GUI.
/// 
/// Overall Plan:
/// 1)Create a canvas
/// 2)Create text boxes and labels for weight and height
/// 3)Create a text box for output
/// 4)Create Button for execution
/// 5)Calculate BMI
/// 6)Output message and change color of canvas
///
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Part1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // get input data from weight and height textboxes
            
            double weight = Convert.ToDouble(enterWeight.Text);
            double height = Convert.ToDouble(enterHeight.Text);
            
            // calculate BMI
            
            double BMI = (weight * 720) / (height * height);
            
            // if else depending on BMI
            if (BMI < 15)
            {
                mainCanvas.Background = new SolidColorBrush(Colors.Blue);
                BMIOutput.Text = "Your BMI is: " + BMI + Environment.NewLine + "You are underweight.";
            }
            else if (BMI > 26)
            {
                mainCanvas.Background = new SolidColorBrush(Colors.Yellow);
                BMIOutput.Text = "Your BMI is: " + BMI + Environment.NewLine + "You are overweight.";
            }
            else
            {
                mainCanvas.Background = new SolidColorBrush(Colors.Green);
                BMIOutput.Text = "Your BMI is: " + BMI + Environment.NewLine + "You are within the healty range.";

            }

        }
    }
}
