using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaTreeViewBugTest.ViewModels;

namespace AvaloniaTreeViewBugTest.Views
{
    public class TestView : ReactiveUserControl<TestViewModel>
    {
        public TestView()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
