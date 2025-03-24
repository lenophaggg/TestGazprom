using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace testovoe.Services
{
    public class DrawingService
    {
        public void DrawItems(Canvas canvas, IEnumerable<Item> items, object selectedItem)
        {
            if (canvas == null) return;

            canvas.Children.Clear();

            double canvasWidth = canvas.ActualWidth;
            double canvasHeight = canvas.ActualHeight;
            if (canvasWidth == 0) canvasWidth = canvas.Width;
            if (canvasHeight == 0) canvasHeight = canvas.Height;
                        
            foreach (var item in items)
            {
                var rect = new Rectangle
                {
                    Width = item.Width * canvasWidth / 20.0,
                    Height = item.Height * canvasHeight / 12.0,
                    Stroke = item.IsDefect ? Brushes.Red : Brushes.Green,
                    StrokeThickness = 2
                };

                if (selectedItem == item)
                {
                    rect.StrokeThickness = 4;
                    rect.Fill = new SolidColorBrush(Color.FromArgb(50, 255, 255, 0));
                }

                Canvas.SetLeft(rect, item.XCoordinate * canvasWidth / 20.0);
                Canvas.SetTop(rect, item.YCoordinate * canvasHeight / 12.0);

                canvas.Children.Add(rect);
            }
        }
    }
}
