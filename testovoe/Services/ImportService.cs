using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testovoe;
using ClosedXML.Excel;
using System.IO;

namespace ConsoleApp1.Services
{
    public class ImportService
    {
        public List<Item> ImportCsv(string fileName)
        {
            var items = new List<Item>();
            var lines = File.ReadAllLines(fileName);
            int startLine = 0;
                       
            if (lines.Length > 0 && lines[0].ToLower().Contains("name"))
                startLine = 1;

            var culture = new CultureInfo("ru-RU");

            for (int i = startLine; i < lines.Length; i++)
            {
                var line = lines[i];
                var parts = line.Split(';');
                if (parts.Length < 6)
                    continue;

                string isDefectStr = parts[5].Trim().ToLower();

                var item = new Item
                {
                    Name = parts[0],
                    XCoordinate = double.TryParse(parts[1], NumberStyles.Any, culture, out var x) ? x : 0,
                    YCoordinate = double.TryParse(parts[2], NumberStyles.Any, culture, out var y) ? y : 0,
                    Width = double.TryParse(parts[3], NumberStyles.Any, culture, out var w) ? w : 0,
                    Height = double.TryParse(parts[4], NumberStyles.Any, culture, out var h) ? h : 0,
                    IsDefect = isDefectStr == "да" || isDefectStr == "yes"
                };

                items.Add(item);
            }

            return items;
        }

        public List<Item> ImportExcel(string fileName)
        {
            var items = new List<Item>();
            var culture = new CultureInfo("ru-RU");

            using (var workbook = new XLWorkbook(fileName))
            {
                var worksheet = workbook.Worksheet(1);
                int row = 2;

                while (!worksheet.Cell(row, 1).IsEmpty())
                {
                    string isDefectStr = worksheet.Cell(row, 6).GetValue<string>().Trim().ToLower();

                    var item = new Item
                    {
                        Name = worksheet.Cell(row, 1).GetValue<string>(),
                        XCoordinate = DoubleTryParse(worksheet.Cell(row, 2).GetValue<string>(), culture),
                        YCoordinate = DoubleTryParse(worksheet.Cell(row, 3).GetValue<string>(), culture),
                        Width = DoubleTryParse(worksheet.Cell(row, 4).GetValue<string>(), culture),
                        Height = DoubleTryParse(worksheet.Cell(row, 5).GetValue<string>(), culture),
                        IsDefect = isDefectStr == "да" || isDefectStr == "yes"
                    };

                    items.Add(item);
                    row++;
                }
            }

            return items;
        }

        private double DoubleTryParse(string input, CultureInfo culture)
        {
            return double.TryParse(input, NumberStyles.Any, culture, out var val) ? val : 0;
        }
    }
}
