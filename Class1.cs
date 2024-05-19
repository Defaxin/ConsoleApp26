

namespace ConsoleApp26
{
    public class Film : IDisposable
    {
        public string Name { get; set; }
        public string NameStudio { get; set; }
        public string Genre { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }
        public Film(string n, string ns, string g, int d, int y)
        {
            Name = n;
            NameStudio = ns;
            Genre = g;
            Duration = d;
            Year = y;
        }
        ~Film()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            //Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Show()
        {
            Console.WriteLine($"Name: {Name}\nNameStudio: {NameStudio}\n" +
                $"Genre: {Genre}\nDuration: {Duration}\nYear: {Year}");
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
