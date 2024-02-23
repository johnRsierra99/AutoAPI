namespace AutogermanaAPI
{
    public class Empresa
    {
        public int EmpresaID { get; set; }
        public int NIT { get; set; }

        public ICollection<Transaccion> Transacciones { get; set; }
    
}
}
