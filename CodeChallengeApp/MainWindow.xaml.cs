using CodeChallengeApp.Models;
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

namespace CodeChallengeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var buttonName = button.Name;
            ButtonEventCreator(buttonName);
        }

        private void ButtonEventCreator(string buttonName)
        {
            switch (buttonName)
            {
                case "RegisterButton":
                    var registerEvent = new RegisterEvent();
                    registerEvent.EventFired += EventCreated;
                    registerEvent.FireEvent();
                    //RenderOutput(registerEvent);
                    break;
                case "DiagnoseButton":
                    var diagnoseEvent = new DiagnoseEvent();
                    diagnoseEvent.EventFired += EventCreated;
                    diagnoseEvent.FireEvent();
                    //RenderOutput(diagnoseEvent);
                    break;
                default:
                    break;
            }
        }

        private void EventCreated(object sender, CodeChallengeEventArgs cce)
        {
            RenderOutput(cce);
        }

        private void RenderOutput(CodeChallengeEventArgs theseArgs) // IEvent thisEvent)
        {
            OutputTextBlock.Text = "";
            for (int i = 1; i <= 100; i++)
            {
                if ( i % theseArgs.LowerNumber == 0 && i % theseArgs.UpperNumber != 0)
                {
                    OutputTextBlock.Text += theseArgs.LowerNumberText;
                }
                else if (i % theseArgs.LowerNumber != 0 && i % theseArgs.UpperNumber == 0)
                {
                    OutputTextBlock.Text += theseArgs.UpperNumberText;
                }
                else if (i % theseArgs.LowerNumber == 0 && i % theseArgs.UpperNumber == 0)
                {
                    OutputTextBlock.Text += theseArgs.CombinedText;
                }
                else
                {
                    OutputTextBlock.Text += i.ToString();
                }

                // Append a line break to the content to prepare for the next line, except when i == 100
                if (i != 100)
                {
                    OutputTextBlock.Text += ", ";
                }
            }
        }
    }
}
