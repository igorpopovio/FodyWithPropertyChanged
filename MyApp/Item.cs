namespace MyApp
{
    public class Item : ObservableObject
    {
        public Item()
        {
            Name = "Testing Item";
            Description = "Just an item used for testing";
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
    }
}
