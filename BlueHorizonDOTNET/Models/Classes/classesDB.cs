using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueHorizon.Models
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        
        [Required, MaxLength(50)]
        public string NmComum { get; set; }
        
        [Required, MaxLength(50)]
        public string NmCientifico { get; set; }
        
        [MaxLength(50)]
        public string Habitat { get; set; }
        
        [MaxLength(50)]
        public string StatConservacao { get; set; }
    }

    public class Cliente
    {
        [Key]
        [MaxLength(5)]
        public string IdCliente { get; set; }

        [Required, MaxLength(50)]
        public string NmCliente { get; set; }

        [MaxLength(9)]
        public string Cep { get; set; }

        [MaxLength(50)]
        public string TipoCliente { get; set; }

        public int TelefCliente { get; set; }
    }

    public class Ia
    {
        [Key]
        [MaxLength(5)]
        public string IdIa { get; set; }

        [Required, MaxLength(50)]
        public string NmIa { get; set; }

        [MaxLength(10)]
        public string VersaoIa { get; set; }

        [MaxLength(5000)]
        public string Dados { get; set; }

        [MaxLength(500)]
        public string DescIa { get; set; }
    }

    public class Organizacao
    {
        [Key]
        [MaxLength(5)]
        public string IdOrgan { get; set; }

        [Required, MaxLength(50)]
        public string NmOrgan { get; set; }

        [MaxLength(9)]
        public string Cep { get; set; }

        [MaxLength(20)]
        public string EmailOrgan { get; set; }

        public int TelefOrgan { get; set; }
    }

    public class Registro
    {
        [Key]
        [MaxLength(5)]
        public string IdRegistro { get; set; }

        public DateTime DtRegistro { get; set; }

        [MaxLength(50)]
        public string Localizacao { get; set; }

        public int QntdRegistro { get; set; }

        [MaxLength(50)]
        public string MtdPesca { get; set; }

        [ForeignKey("Cliente")]
        public string ClienteIdCliente { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey("Organizacao")]
        public string OrganizacaoIdOrgan { get; set; }
        public Organizacao Organizacao { get; set; }

        [ForeignKey("Ia")]
        public string IaIdIa { get; set; }
        public Ia Ia { get; set; }

        [ForeignKey("Animal")]
        public int AnimalAnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
