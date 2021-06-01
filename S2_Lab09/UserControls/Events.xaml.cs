using System.Windows.Controls;
using System.Windows.Input;

namespace S2_Lab09.UserControls
{
    public partial class Events : UserControl
    {
        public Events()
        {
            InitializeComponent();
        }
        
        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock1.Text = TextBlock1.Text + "sender: " + sender + "\n";
            TextBlock1.Text = TextBlock1.Text + "source: " + e.Source + "\n\n";
        }


        private void Control_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock1.Text = TextBlock1.Text + "sender: " + sender + "\n";
            TextBlock1.Text = TextBlock1.Text + "source: " + e.Source + "\n\n";
        }

        private void UIElement_OnMouseEnter(object sender, MouseEventArgs e)
        {
            TextBlock1.Text = TextBlock1.Text + "sender: " + sender + "\n";
            TextBlock1.Text = TextBlock1.Text + "source: " + e.Source + "\n\n";
        }
    }
}