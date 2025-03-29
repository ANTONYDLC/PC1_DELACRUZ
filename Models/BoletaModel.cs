namespace CasaCambio.Models
{
    public class BoletaModel
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public decimal Cantidad { get; set; }
        public string MonedaOrigen { get; set; }
        public decimal Resultado { get; set; }
        public string MonedaDestino { get; set; }
    }
}
