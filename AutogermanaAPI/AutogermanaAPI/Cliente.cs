namespace AutogermanaAPI
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Email { get; set; } = string.Empty;
        public long Telefono { get; set; }

        public ICollection<Transaccion> Transacciones { get; set; }
    }
}

