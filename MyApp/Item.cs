using PropertyChanged;

namespace MyApp
{
    [ImplementPropertyChanged]
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Item()
        {
            Name = "Testing Item";
            Description = "Just an item used for testing";
        }
    }
}
