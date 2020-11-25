using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdfcommentreader
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfReader reader = new PdfReader(@"doc.pdf");
            PdfDocument doc = new PdfDocument(reader);
            var notes = doc.GetPage(1).GetAnnotations();

            foreach (var note in notes)
            {
                Console.WriteLine(note.GetContents());
            }
            Console.ReadKey();
        }
    }
}
