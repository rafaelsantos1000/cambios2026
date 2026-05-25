namespace Cambios2026.Modelos
{
    public class Response
    {
        public bool IsSucccess { get; set; }

        public string Message { get; set; } = null!;

        public object Result { get; set; } = null!;
    }
}
