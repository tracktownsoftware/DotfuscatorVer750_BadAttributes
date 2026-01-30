using LibraryAssembly2;

namespace LibraryAssembly1
{
    public class PublicApiService
    {
        private int _counter;

        public PublicApiService(string name)
        {
            Name = name;
        }

        // Public property (should NOT be renamed)
        public string Name { get; }

        // Public method (should NOT be renamed)
        public int Increment()
        {
            _counter++;
            return _counter;
        }

        // Public method calling excluded class
        public string GetStatus()
        {
            var sum = Utility.Add(_counter, 1);
            return $"{Name}:{sum}@{Utility.GetTimestamp()}";
        }

        // Private helper (safe to obfuscate)
        private void Reset()
        {
            _counter = 0;
        }
    }
}
