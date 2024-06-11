using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Controls.Models.TreeDataGrid;
using Avalonia.Controls.Selection;
using Bogus;
using ReactiveUI;
using TreeDataGridDemo.Models;

namespace TreeDataGridDemo.ViewModels
{
    internal class DragDropPageViewModel : ReactiveObject
    {
        private ObservableCollection<DragDropItem> _data;

        public DragDropPageViewModel()
        {
            _data = DragDropItem.CreateRandomItems();
            var source = new HierarchicalTreeDataGridSource<DragDropItem>(_data)
            {
                Columns =
                {
                    new HierarchicalExpanderColumn<DragDropItem>(
                        new TextColumn<DragDropItem, string>(
                            "Name",
                            x => x.Name,
                            GridLength.Star),
                        x => x.Children),
                    new CheckBoxColumn<DragDropItem>(
                        "Allow Drag",
                        x => x.AllowDrag,
                        (o, x) => o.AllowDrag = x),
                    new CheckBoxColumn<DragDropItem>(
                        "Allow Drop",
                        x => x.AllowDrop,
                        (o, x) => o.AllowDrop = x),
                }
            };

            source.RowSelection!.SingleSelect = false;
            Source = source;
            CopyCommand = ReactiveCommand.Create(() =>
            {
                var r = Source.Selection as TreeDataGridRowSelectionModel<DragDropItem>;
                var r2 = r?.SelectedItem;
                _data.Insert(r?.SelectedIndex[0]??0, r2!);
            }
            );
        }

        public ITreeDataGridSource<DragDropItem> Source { get; }


        public ICommand CopyCommand { get; set; }
    }
}
