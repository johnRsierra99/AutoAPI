﻿namespace AutogermanaAPI
{
    public class Concesionarios
    {
        public int ConcesionarioID { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Ciudad { get; set; } = string.Empty;

        public ICollection<Transaccion> Transacciones { get; set; }
    }
}

