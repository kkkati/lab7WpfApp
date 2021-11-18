using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace lab7WpfApp
{
    class MyCommands
    {
        
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand Open { get; set; }
        public static RoutedCommand Save { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control,"Ctrl+T"));
            InputGestureCollection inputs2 = new InputGestureCollection();
            inputs2.Add(new KeyGesture(Key.O, ModifierKeys.Control, "Ctrl+O"));
            InputGestureCollection inputs3 = new InputGestureCollection();
            inputs2.Add(new KeyGesture(Key.S, ModifierKeys.Control, "Ctrl+S"));
            Exit = new RoutedCommand("Exit", typeof(MyCommands), inputs);
            Open = new RoutedCommand("Open", typeof(MyCommands), inputs2);
            Save = new RoutedCommand("Save", typeof(MyCommands), inputs3);
        }
    }
}
