using FactoryPattern;


class Program
{

    static void Main(string[] args)
    {

        DocumentFactory factory = new DocumentFactory();


        Document word = factory.CreateDocument("WORD");
        word.Open();


        Document pdf = factory.CreateDocument("PDF");
        pdf.Open();


        Document excel = factory.CreateDocument("EXCEL");
        excel.Open();

    }

}