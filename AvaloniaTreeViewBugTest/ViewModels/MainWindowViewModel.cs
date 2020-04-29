using Avalonia.Controls;
using AvaloniaTreeViewBugTest.Models;
using AvaloniaTreeViewBugTest.Views;
using DynamicData.Binding;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace AvaloniaTreeViewBugTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        [Reactive]
        public ObservableCollectionExtended<DataEntry> Entries { get; set; }
           = new ObservableCollectionExtended<DataEntry>();
        [Reactive]
        public DataEntry SelectedEntry { get; set; }
        [Reactive]
        public Control PopupManager { get; set; }
        public MainWindowViewModel() 
        {
            Entries.Add(new DataEntry { Name = "test", View = new TestView { DataContext = new TestViewModel() } }) ;
            Entries.Add(new DataEntry {Name = "TreeViewTest" ,View = new TreeViewTest { DataContext = new TreeViewTestViewModel() } });
           this .WhenAnyValue(x => x.SelectedEntry)
                 .SubscribeOn(RxApp.TaskpoolScheduler)
                 .ObserveOn(RxApp.MainThreadScheduler)
               .Subscribe(item => HandleChangeAsync(item));
        }
        private  void HandleChangeAsync(DataEntry item)
        { 
            if (!object.ReferenceEquals(null, item))
            {
                //已发送判断
                //if (item.HasUnread|| db.GetTask(item.Uuid, item.Plugin.PluginID)!=null) 
                //{
                //    PopupManager = item.Hostscontrol;
                //    return;
                //}
                try
                {
                   
                        PopupManager = item.View;
                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);

                }

            }

        }
    }
}
