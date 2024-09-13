using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using OfficeOpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Linq;

namespace ExcelReadingBenchmark
{
	public class ExcelReadingBenchmark
	{
		private const string filePath = @"C:\Users\lahuu\Downloads\Test.xlsx"; // Đổi đường dẫn tới file Excel của bạn

		//// Phương thức đọc Excel bằng EPPlus
		[Benchmark]
		public void ReadExcelUsingEPPlus()
		{
			// Đặt LicenseContext để tránh lỗi giấy phép
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			using (var package = new ExcelPackage(new FileInfo(filePath)))
			{
				ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

				// Lấy số dòng và số cột từ worksheet
				int rowCount = worksheet.Dimension.Rows;

				// Đọc dữ liệu từ các ô trong cột A (dòng 1 đến dòng 1000)
				for (int row = 1; row <= rowCount; row++)
				{
					var value = worksheet.Cells[row, 1].Value?.ToString(); // Đọc từ cột A
   					//Console.WriteLine($"EPPlus - Row {row}, Value: {value}");
				}
			}
		}



		// Phương thức đọc Excel bằng OpenXML
		[Benchmark]
		public void ReadExcelUsingOpenXml()
		{
			using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(filePath, false))
			{
				WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
				WorksheetPart worksheetPart = workbookPart.WorksheetParts.FirstOrDefault();
				Worksheet worksheet = worksheetPart.Worksheet;

				// Lấy tất cả các ô (Cell) trong worksheet
				var cells = worksheet.Descendants<Cell>().ToList();

				// Lấy số dòng từ worksheet (cần chắc chắn có đúng chỉ số dòng)
				int rowCount = worksheet.Descendants<Row>().Count();

				// Đọc dữ liệu từ các ô trong cột A
				for (int row = 1; row <= rowCount; row++)
				{
					var cellReference = $"A{row}"; // Đọc từ cột A
					var cell = cells.FirstOrDefault(c => c.CellReference == cellReference);
					if (cell != null)
					{
						var value = cell.CellValue?.InnerText;
						//Console.WriteLine($"OpenXml - Row {row}, Value: {value}");
					}
				}
			}
		}



	}

	class Program
	{
		static void Main(string[] args)
		{
			// Khởi chạy Benchmark
			var summary = BenchmarkRunner.Run<ExcelReadingBenchmark>();
			Console.ReadLine();
		}
	}
}
