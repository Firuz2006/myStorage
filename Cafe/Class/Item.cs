namespace Cafe.Class
{
    internal class Item
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public string Image { get; set; }

        public Item(int key, string value)
        {
            Key = key;
            Value = value;
        }
        public Item(int key, string value, string image = "")
        {
            Key = key;
            Value = value;
            Image = image;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
