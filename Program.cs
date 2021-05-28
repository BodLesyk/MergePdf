using Aspose.Pdf.Facades;
using System;
using System.IO;

namespace PDF_Merge
{
    class Program
    {
        static void Main(string[] args)
        {

            


            PdfFileEditor pdfEditor = new PdfFileEditor();
            

            //try
            //{
            //    pdfEditor.Concatenate("C://real.pdf", "C://Example.pdf", "C://Result.pdf");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            FileStream outputStream = new FileStream("C://Merged.pdf", FileMode.Create);
            FileStream[] streamArray = new FileStream[3];
            streamArray[0] = new FileStream("C://real.pdf", FileMode.Open);
            streamArray[1] = new FileStream("C://Example.pdf", FileMode.Open);
            streamArray[2] = new FileStream("C://empty.pdf", FileMode.Open);

            try
            {
                pdfEditor.Concatenate(streamArray, outputStream);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
