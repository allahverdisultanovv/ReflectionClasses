namespace ReflectionClasses.Models
{
    internal abstract class Fruit
    {
        public decimal Price { get; set; }
        public string Sort { get; set; }

        public virtual void Taste()
        {
            Console.WriteLine("Sirindir");
        }
    }
}
