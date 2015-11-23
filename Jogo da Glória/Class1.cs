using System;
using System.Runtime.CompilerServices;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Jogo_da_Glória
{
    public static class ButtonAwaiterExtensions
    {
        public static ButtonAwaiter GetAwaiter(this Button button)
        {
            return new ButtonAwaiter
            {
                Button = button
            };
        }
    }

    public class ButtonAwaiter : INotifyCompletion
    {
        public bool IsCompleted
        {
            get { return false; }
        }

        public Button Button { get; set; }

        public void OnCompleted(Action continuation)
        {
            RoutedEventHandler h = null;
            h = (o, e) =>
            {
                Button.Click -= h;
                continuation();
            };
            Button.Click += h;
        }

        public void GetResult()
        {
        }
    }
}