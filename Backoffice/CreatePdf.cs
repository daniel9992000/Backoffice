using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace Backoffice
{
    public class CreatePdf
    {

        BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
        BaseFont bfHelvetica = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        Document pdf = new Document();

        private Font getheaderFont()
        {
            Font header = new Font(bfTimes, 26, Font.BOLD, new BaseColor(54,54,120));
            return header;
        }

        private Font getsmallheaderFont()
        {
            Font sheader = new Font(bfHelvetica, 14, Font.BOLDITALIC, new BaseColor(10,10,10));
            return sheader;
        }

        private Font gettextfont()
        {
            Font text = new Font(bfHelvetica, 12, Font.NORMAL, new BaseColor(0, 0, 0));
            return text;
        }
        public void CreatePdfDocument(string pdfname)
        {
            PdfWriter writer = PdfWriter.GetInstance(pdf, new FileStream(pdfname,FileMode.Create));
            pdf.Open();        
        }

        public void AddText(string text)
        {
            Paragraph p = new Paragraph(text);
            p.Leading = 25;
            p.Alignment = 0;
            pdf.Add(p);
        }

        public void addKundenname(string sheader)
        {
            Font myfont = getsmallheaderFont();
            Paragraph sheadline = new Paragraph(sheader, myfont);
            sheadline.Leading = 40;
            sheadline.Alignment = 2;
            pdf.Add(sheadline);
        }

        public void addKundenanschrift(string text)
        {
            Paragraph p = new Paragraph(text);
            p.Leading = 20;
            p.Alignment = 2;
            pdf.Add(p);
        }

        public void AddHeader(string header)
        {
            Font myfont = getheaderFont();
            Paragraph headline = new Paragraph(header, myfont);
            headline.Alignment = 1;
            pdf.Add(headline);
        }

        public void AddsmallHeader(string sheader)
        {
            Font myfont = getsmallheaderFont();
            Paragraph sheadline = new Paragraph(sheader, myfont);
            sheadline.Leading = 40;
            sheadline.Alignment = 0;
            pdf.Add(sheadline);
        }

        public void addTableRechnung(int anzcol, List<string> values, string summe)
        {
            PdfPTable table = new PdfPTable(anzcol);
            
            table.TotalWidth = 500f;
            table.LockedWidth = true;
            table.SpacingAfter = 10f;
            table.SpacingBefore = 30f;
            table.DefaultCell.Padding = 5f;            

            int i = 1;
            foreach (var item in values)
            {
                PdfPCell cell = new PdfPCell(new Phrase(item));
                cell.Padding = 5f;
                if ((i % 2) == 0)
                {
                    
                    cell.HorizontalAlignment = 2;
                }
                table.AddCell(cell);
                i++;
            }
            PdfPCell sum = new PdfPCell(new Phrase(summe));
            sum.Colspan = anzcol;
            sum.HorizontalAlignment = 2;
            sum.Padding = 5f;
            table.AddCell(sum);
            pdf.Add(table);
        }
        
        public void addTable(int anzcol, string tableheader, List<string> values)
        {
            PdfPTable table = new PdfPTable(anzcol);
            PdfPCell cell = new PdfPCell(new Phrase(tableheader));
            table.TotalWidth = 500f;
            table.LockedWidth = true;
            table.SpacingAfter = 10f;
            table.SpacingBefore = 30f;
            table.DefaultCell.Padding = 5f;
            cell.Colspan = anzcol;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right
            cell.Padding = 10f;
            table.AddCell(cell);
            foreach (var item in values)
            {
                table.AddCell(item);
            } 
            pdf.Add(table);
        }
        public void ClosePdf()
        {
            pdf.Close();
        }

        
      
    }
}
