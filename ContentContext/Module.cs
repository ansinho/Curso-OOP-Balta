using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lactures = new List<Lacture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lacture> Lactures { get; set; }
    }
}
