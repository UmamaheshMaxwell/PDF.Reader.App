using System;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;


namespace PDF.Reader.App
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void pdfUploadBtn_Click(object sender, EventArgs e)
        {
            if (pdfUpload.HasFile)
            {

                string filePath = Server.MapPath("Files/" + pdfUpload.PostedFile.FileName);
                pdfUpload.SaveAs(filePath);
                string pdfText = GetTextFromPDF(filePath);
                System.IO.File.Delete(filePath);
                lblMessage.Text = pdfText;
            }
            else
            {
                lblMessage.Text = "No File Uploaded.";
            }
        }

        private string GetTextFromPDF(string file)
        {
            StringBuilder text = new StringBuilder();
            using (PdfReader reader = new PdfReader(file))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            return text.ToString();
        }
    }
}