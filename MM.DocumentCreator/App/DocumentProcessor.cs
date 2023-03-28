using Xceed.Words.NET;

namespace MM.DocumentCreator.App
{
    public class DocumentProcessor<T> where T : class
    {
        public string TemplatePath { get; set; }

        public DocumentProcessor(string templatePath)
        {
            TemplatePath = templatePath;
        }

        public DocX Process(T form)
        {

            if (!File.Exists(TemplatePath))
            {
                throw new Exception("kutas");
            }

            DocX doc = DocX.Load(TemplatePath);

            foreach (var field in typeof(T).GetProperties())
            {
                doc.ReplaceText("{{" + field.Name + "}}", field.GetValue(form).ToString());
            }

            return doc;
        }
    }
}
