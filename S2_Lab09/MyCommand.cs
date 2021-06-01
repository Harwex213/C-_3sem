using System.Windows.Input;

namespace S2_Lab09
{
    public class MyCommand
    {
        static MyCommand()
        {
            var inputs = new InputGestureCollection
            {
                new KeyGesture(Key.C, ModifierKeys.Control, "Ctrl + C"),
                new KeyGesture(Key.V, ModifierKeys.Control, "Ctrl + V")
            };
            Requery = new RoutedUICommand("Requery", "Requery", typeof(MyCommand), inputs);
        }

        public static RoutedUICommand Requery { get; }
    }
}