
namespace ClassLibrary7
{
    // All the code in this file is included in all platforms.
    public static class Class1
    {
        public static void AddEntryControl(VerticalStackLayout layout)
        {
            var newEntry = new Entry()
            {
                Placeholder = "Entry Added From Class Library",
                PlaceholderColor = Colors.Red,
            };
            layout.Add(newEntry);
        }
    }
}
