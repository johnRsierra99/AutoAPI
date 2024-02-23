namespace AutogermanaAPI
{
    public class Vehiculos
    {
        public int VehiculosID { get; set; }
        public int Marca { get; set; }
        public int Modelo { get; set; }
        public DateTime Anio { get; set; }
        public int Precio { get; set; }

        public ICollection<Transaccion> Transacciones { get; set; }
    
}
}
