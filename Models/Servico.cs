using System;

namespace EcommerceAPI.Models
{
    public class Servico
    {

        public int Id { get; set; }
        public long CPF { get; set; }
        public DateTime Data { get; set; }

        public int Hora { get; set; }
        public string Descricao { get; set; }
    }
}