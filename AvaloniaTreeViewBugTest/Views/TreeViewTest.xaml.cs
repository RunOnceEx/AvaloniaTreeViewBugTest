using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using AvaloniaTreeViewBugTest.ViewModels;

namespace AvaloniaTreeViewBugTest.Views
{
    public class TreeViewTest : ReactiveUserControl<TreeViewTestViewModel>
    {
        public TreeViewTest()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
