using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InforQui_17933.Models
{
    //Classe Compras Produtos
    public class Compras_Produtos
    {
        //################## Os atributos da tabela Compras_produtos #########
        //O identificador da tabela Compras_Produtos
        [Key]
        [Display(Name = "Identificador de Compras Produtos")]
        public int Compras_ProdutoID { get; set; }
        //A quantidade da compra dos produtos
        [Display(Name = "Quantidade dos Produtos")]
        [Required(ErrorMessage = "O {0} é preenchimento obrigatorio")]
        public int Quantidade { get; set; }
        //O preço dos produtos comprado
        [Display(Name = "Preço do produto comprados")]
        [Required(ErrorMessage = "O {0} é preenchimento obrigatorio")]
        public double Preco { get; set; }

        //######### Relacionamentos e Chaves estrangeiras ###################
        //chave estrangeira da tabela Compras_Produtos
        [ForeignKey("Compra")]
        //existe para criar a FK na BD
        public int CompraFK { get; set; }
        //Relacionamento entre a tabela Compra com a tabela Compras_Produtos
        public Compras Compra { get; set; }

        //chave estrangeira da tabela Produtos
        [ForeignKey("Produto")]
        //existe para criar a FK na BD
        public int ProdutoFK { get; set; }
        //Relacionamento entre a tabela Produto com a tabela Compras_Produtos
        public Produtos Produto { get; set; }

    }
}