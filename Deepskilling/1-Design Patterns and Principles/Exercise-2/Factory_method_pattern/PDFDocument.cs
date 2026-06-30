namespace FactoryPattern
{
    public class PDFDocument : Document
    {
        public void Open()
        {
            Console.WriteLine("Opening PDF Document");
        }
    }
}