using ConsoleApp1.Services;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using testovoe.Services;

namespace testovoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Item> Items { get; set; }
        
        private readonly ImportService importService;
        private readonly DrawingService drawingService;

        public MainWindow()
        {
            InitializeComponent();

            Items = new ObservableCollection<Item>();
            DataGridObjects.ItemsSource = Items;
                        
            importService = new ImportService();
            drawingService = new DrawingService();

            Items.CollectionChanged += Items_CollectionChanged;

            CanvasArea.Loaded += (s, e) => RedrawCanvas();

            // тест
            Items.Add(new Item
            {
                Name = "Объект 1",
                XCoordinate = 5,
                YCoordinate = 3,
                Width = 4,
                Height = 2,
                IsDefect = true
            });

            Items.CollectionChanged += (s, e) => RedrawCanvas();

            CanvasArea.Loaded += (s, e) => RedrawCanvas();
        }

        private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Item newItem in e.NewItems)
                {
                    newItem.PropertyChanged += Item_PropertyChanged;
                }
            }

            if (e.OldItems != null)
            {
                foreach (Item oldItem in e.OldItems)
                {
                    oldItem.PropertyChanged -= Item_PropertyChanged;
                }
            }

            RedrawCanvas();
        }

        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            RedrawCanvas();
        }

        private void DataGridObjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RedrawCanvas();
        }

        private void RedrawCanvas()
        {
            drawingService.DrawItems(CanvasArea, Items, DataGridObjects.SelectedItem);
        }

        private void ImportCsv_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv"
            };

            if (dlg.ShowDialog() == true)
            {
                try
                {
                    var importedItems = importService.ImportCsv(dlg.FileName);
                    foreach (var item in importedItems)
                        Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при импорте CSV: " + ex.Message);
                }
            }
        }

        private void ImportExcel_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx;*.xls)|*.xlsx;*.xls"
            };

            if (dlg.ShowDialog() == true)
            {
                try
                {
                    var importedItems = importService.ImportExcel(dlg.FileName);
                    foreach (var item in importedItems)
                        Items.Add(item);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при импорте Excel: " + ex.Message);
                }
            }
        }

    }
}