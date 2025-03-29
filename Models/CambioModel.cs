namespace CasaCambio.Models
{
    public class CambioModel
    {
        public decimal Cantidad { get; set; }
        public string MonedaOrigen { get; set; }
        public string MonedaDestino { get; set; }
        public decimal Resultado { get; set; }
    }
}
