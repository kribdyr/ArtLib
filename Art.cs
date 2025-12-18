namespace ArtLib
{
    public class Art
    {
        int id;
        string artName;
        string artType;
        double price;

        public Art()
        {
            artName = string.Empty;
            artType = string.Empty;
            price = 0;
        }

        public int Id { get; set; }
        public string ArtName { get { return artName; } set { artName = value; } }
        public string ArtType { get { return artType; } set {artType = value; } }
        public double Price { get { return price; } set { price = value; } }

        public override string ToString()
        {
            return $"(ID: {id}\n Name: {artName}\n Type: {artType}\n Price: {price})";
        }

    }
}
