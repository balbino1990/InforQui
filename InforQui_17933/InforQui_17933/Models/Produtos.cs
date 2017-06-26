using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InforQui_17933.Models
{
    public class Produtos
    {
        //################ O construtor da classe####################
        public Produtos()
        {
            ListaComprasProdutos = new HashSet<Compras_Produtos>();
        }

        //############ Os atributos da tabela Produtos################
        //O identificador da tabela Produtos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  //quando usado, inibe o atributo de ser Auto Number
        [Display(Name = "Identifcador do Produto")]
        public int ProdutoID { get; set; }

        //O nome do produto
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Nome do produto")]
        //[RegularExpression("[A-ZÁÉÍÓÚÀÈÌÒÙ][a-záéíóúàèìòùãõâêîôûäëïöüçñ]+((( (de|da|do|ou|para) ))[A-Z][a-záéíóúàèìòùãõâêîôûäëïöüçñ]+){1,3}",
        //                  ErrorMessage = "O campo do {0} não permite o algarismo e letra minúscula no inicio do nome e permite os caracteres português")]
        public string Nome { get; set; }

        //A descrição do produto
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Descrição do produto")]
        //[RegularExpression("[A-ZÁÉÍÓÚ0-9][a-záéíóúàèìòùãõç0-9]+( [A-Z][a-záéíóúàèìòùãõç0-9]+)*",
          //                ErrorMessage = "O campo do {0} não permite no ínicio da descrição com letra minúscula")]
        public string Descricao { get; set; }

        //O preço do produto
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        //[RegularExpression("[0-9]+([.][0-9]{2})?",
        //                  ErrorMessage = "O preço do produto tem de se usar a moeda euro (€) e pode ter dois digitos decimais no fim")]
        [Display(Name = "Preço do produto")]
        public double Preco { get; set; }

        //A imagem do produto
        //[Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Imagem do produto")]
        public string Imagem { get; set; }

        //O tipo do produto
        //[Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Tipo do produto")]
        public string Tipo { get; set; }

    //    public string NomeUtilizador { get; set; }

        //########## Relacionamentos e chaves estrangeiras
        //Relacionamento entre a tabela Produto e Compras_Produtos
        //1 'Produto' relacionar com muitas 'Compras_Produtos'
        public virtual ICollection<Compras_Produtos> ListaComprasProdutos { get; set; }
    }
}
