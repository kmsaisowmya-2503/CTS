namespace FactoryPattern
{
    public class DocumentFactory
    {

        public Document CreateDocument(string type)
        {

            switch(type.ToUpper())
            {

                case "WORD":
                    return new WordDocument();


                case "PDF":
                    return new PDFDocument();


                case "EXCEL":
                    return new ExcelDocument();


                default:
                    throw new Exception("Invalid Document Type");

            }

        }

    }
}