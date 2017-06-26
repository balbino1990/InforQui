using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InforQui_17933.Models
{
    public class Compras
    {
        //##################O construtor da classe###########################
        public Compras()
        {
            ListaComprasProdutos = new HashSet<Compras_Produtos>();
        }
        //##################Os stributos da tabela Compras#####################
        //O identificador da tabela Compras
        [Key]
        [Display(Name = "Identificador de Compras")]
        public int CompraID { get; set; }
        //O atributo data para fazer a compra
        [Column(TypeName = "date")] //só regista a 'data', não é as horas
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")] //Vai display só as 'datas' na pagina, não 'horas'
        [Required(ErrorMessage = "O campo da {0} é o preenchimento obrigatoria")]
        [Display(Name = "Data da Compra")]
        public DateTime Data { get; set; }


        ////########### Relacionamentos e chaves estrangeiras####################
        ////chave estrangeira das compras
        //[ForeignKey("Utilizador")]
        ////existe para criar a FK na BD
        //public int UtilizadorFK { get; set; }
        ////relacionamento entre a tabela Compras com a tabela utilizadores
        //public Utilizadores Utilizador { get; set; }

        //########### Relacionamentos e chaves estrangeiras####################
        //chave estrangeira das compras
        //existe para criar a FK na BD
        //relacionamento entre a tabela Compras com a tabela utilizadores
        public string  UtilizadorFK { get; set; }
        

        //Relacionamento entre a tabela Compras com a tabela Compras_Produtos
        // 1 'Compra' relacionar com muitas 'Compras_Produtos'
        public virtual ICollection<Compras_Produtos> ListaComprasProdutos { get; set; }
    }
}