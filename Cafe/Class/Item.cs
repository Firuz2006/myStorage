namespace Cafe.Class
{
    public class Item
    {
        public int Key { get; set; }
        public string Value { get; set; }


        public Item(int key, string value)
        {
            Key = key;
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
