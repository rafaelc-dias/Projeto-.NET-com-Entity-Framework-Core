using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFrotas.Models.Domain.Entites
{
    public class Motorista
    {
        [Column(TypeName = "varchar(50)")]
        public string MotoristaId { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string Nome { get; set; }
        
        [Column(TypeName = "varchar(50)")]
        public string Cnh { get; set; }
        public DateTime ValidadeCnh { get; set; }
        public bool Ativo { get; set; }
        public IList<MotoristaVeiculo> Veiculos { get; set; }
    }
}
