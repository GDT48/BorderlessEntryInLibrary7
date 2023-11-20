using BorderlessEntryInLibrary7.Handlers;
using ClassLibrary7;

namespace BorderlessEntryInLibrary7
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            var newEntry = new BorderlessEntry()
            {
                Placeholder = "Borderless Entry Added From Code Behind",
                PlaceholderColor = Colors.Red,
            };
            this.EntryLayout.Add(newEntry);
            Class1.AddEntryControl(EntryLayout);
        }

    }

}
