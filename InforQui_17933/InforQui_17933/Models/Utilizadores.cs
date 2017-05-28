using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InforQui_17933.Models
{
    public class Utilizadores
    {
        //#####################################################
        //O construtor da classe Utilizadores
        public Utilizadores()
        {
            ListaDeCompras = new HashSet<Compras>();
        }

        //####################################################
        //##########Os atributos da tabela utilizador#########
        //####################################################
        //O identificador da tabela Utilizador
        [Key]
        [Display(Name = "Identificador de utilizador")]
        public int UtilizadorID { get; set; }

        //O Nome do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Nome do utilizador")]
        //[RegularExpression("[A-Z][a-záéíóúàèìòùãõäëïöüçñ]+((( )|(-)|( (e|de|da|dos) )|( d'))[A-Z][a-záéíóúàèìòùãõäëïöüçñ]+){1,3}",
          //                ErrorMessage = "Deve escrever o {0} só com letras. Pode usar um espaço em branco entre palavras. Deve começar cada nome com uma maiúscula, seguida de minúsculas.")]
        public string Nome { get; set; }

        //O Email do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Email de utilizador")]
        //[RegularExpression("[A-Za-z][A-Za-z0-9._%+-]+@inforqui.com",
          //                ErrorMessage = "o {0} tem de ser compativel com o servidor inforqui (@inforqui.com), e não permite os algarismos no inicio do email")]
        public string Email { get; set; }

        //A Morada do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Morada do utilizador")]
        //[RegularExpression("[A-Z][A-ZÁÉÍÓÚÀÈÌÒÙÇaa-záéíóúàèìòùç]+( [A-ZÁÉÍÓÚÀÈÌÒÙÇa-záéíóúàèìòùç0-9])+")]
        public string Morada { get; set; }

        // O código postal do utilizador
        [Required(ErrorMessage = "O {0} é preenchimento obrigatoria")]
        [Display(Name = "Código Postal de utilizador")]
        //[RegularExpression("[0-9]+[-][0-9]{3}", ErrorMessage = "O campo {0} vai aceitar 7 algarismos e um (-)")]
        public string CodPostal { get; set; }

        //O NIF do utilizador
        [Required(ErrorMessage = "O {0} é preenchimento obrigatoria")]
        [Display(Name = "O NIF do utilizador")]
        //[RegularExpression("[0-9]{9}", ErrorMessage = "O campo {0} só vai aceitar 9 algarismos")]
        public int NIF { get; set; }

        //O Contacto do utilizador
        [Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Contacto do utilizador")]
        //[RegularExpression("[9](1|2|3|6){1}([0-9]+){7}", ErrorMessage = "O {0} só aceita nove algarismos")]
        public string Contacto { get; set; }

        //O Imgem do utilizador
        //[Required(ErrorMessage = "O campo {0} é obrigatoria")]
        [Display(Name = "Imagem de Utilizador")]
        public string Imagem { get; set; }

        //##################################################################
        //################Relacionamento e chaves estrangeiras##############
        //##################################################################
        //1 Utilizador relaciona com muitas Compras
        public virtual ICollection<Compras> ListaDeCompras { get; set; }
    }
}