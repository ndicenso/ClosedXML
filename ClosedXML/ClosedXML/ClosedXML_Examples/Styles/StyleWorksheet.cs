﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Drawing;


namespace ClosedXML_Examples.Styles
{
    public class StyleWorksheet
    {
        public void Create(String filePath)
        {
            var workbook = new XLWorkbook();
            var ws = workbook.Worksheets.Add("Style Worksheet");

            ws.Style.Font.Bold = true;
            ws.Style.Font.FontColor = Color.Red;
            ws.Style.Fill.BackgroundColor = Color.Cyan;

            // The following cells will be bold and red
            // because we've specified those attributes to the entire worksheet
            ws.Cell(1, 1).Value = "Test";
            ws.Cell(1, 2).Value = "Case";

            // Here we'll change the style of a single cell
            ws.Cell(2, 1).Value = "Default";
            ws.Cell(2, 1).Style = XLWorkbook.DefaultStyle;

            // Let's play with some rows
            ws.Row(4).Style = XLWorkbook.DefaultStyle;
            ws.Row(4).Height = 20;
            ws.Rows(5, 6).Style = XLWorkbook.DefaultStyle;
            ws.Rows(5, 6).Height = 20;

            // Let's play with some columns
            ws.Column(4).Style = XLWorkbook.DefaultStyle;
            ws.Column(4).Width = 5;
            ws.Columns(5, 6).Style = XLWorkbook.DefaultStyle;
            ws.Columns(5, 6).Width = 5;

            workbook.SaveAs(filePath);
        }
    }
}