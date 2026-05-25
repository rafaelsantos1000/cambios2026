namespace Cambios2026.Modelos
{
    public class Rate
    {
      
        public int RateId { get; set; }

        public string Code { get; set; } = null!;

        public double TaxRate { get; set; }

        public string Name { get; set; } = null!;

        //public override string ToString()
        //{
        //    return $"{Name}";
        //}
    }
}
