namespace InforQui_17933.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<InforQui_17933.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(InforQui_17933.Models.ApplicationDbContext context)
        {
            //#######################################################################################
            //Adiciona os Produtos
            //#######################################################################################
            var produtos = new List<Produtos> {
               new Produtos  {ProdutoID=1, Nome = "Balão de Fundo chato",
                           Descricao ="A utilização do Balão de Fundo chata é para armazenar, preparar, aquecer ou recolher soluções. Podem ser de vidro transparente ou âmbar.",
                           Preco="€20,00", Imagem="balao_de_fundo_chato.jpg", Tipo="Instrumento", NomeUtilizador="a@a.aa"},
               new Produtos  {ProdutoID=2, Nome = "Erlenmeyer",
                           Descricao ="A utilização de Erlenmeyer é para recolher frações de materiais destilados ou para conter misturas que serão homogeneizadas.",
                           Preco="€50,00", Imagem="Erlenmeyer.jpg", Tipo="Instrumento",  NomeUtilizador="b@b.bb"},
               new Produtos  {ProdutoID=3, Nome = "Béquer",
                           Descricao ="A utilização do Béquer é resistir o aquecimento, resfriamento e ataques de produtos químicos, com escala de pouca precisão.",
                           Preco="€40,00", Imagem="Calix_Beaker.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=4, Nome = "Funil de Vidro",
                           Descricao ="A utilização de funil de Vidro é para transferir líquidos e apoiar o papel de filtro",
                           Preco="€20,00", Imagem="funil_de_vidro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=5, Nome = "Tubos de ensaio",
                           Descricao ="A utilização de tubos de ensaio é fazer reações e análises de recipientes. Também utilizados para coleta de amostras em pequena quantidade.",
                           Preco="€20,00", Imagem="tubos_de_ensaio.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=6, Nome = "Condensadores",
                           Descricao ="A condensador consiste por colunas de vidro com tamanho variável entre 10 cm e 1,7 metro, dentro das quais existem tubos em forma reta, espiral ou bolas sequenciais. São utilizados em destilações",
                           Preco="€30,00", Imagem="Condensadores.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=7, Nome = "Bastão ou baqueta",
                           Descricao ="É um bastão maciço de vidro. Serve para agitar e facilitar as dissoluções ou manter massas líquidas em constante movimento",
                           Preco="€30,00", Imagem="Baqueta_ou_bastão.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=8, Nome = "Proveta ou cilindro graduado",
                           Descricao ="A utilização de proveta é serve para medição aproximada de volumes maiores de líquidos",
                           Preco="€30,00", Imagem="proveta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=9, Nome = "Bureta",
                           Descricao ="A Bureta serve para determinar pequenos volumes de reagentes com precisão. Pode ser de vidro ou de polietileno",
                           Preco="€20,00", Imagem="Bureta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=10, Nome = "Pipetas",
                           Descricao ="Utilizadas para medir e transferir mínimas quantidades de líquidos com precisão. Podem ser graduadas ou volumétricas",
                           Preco="€10,00", Imagem="pipetas.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=11, Nome = "Bico de Bunsen",
                           Descricao ="Aquecedor a gás com chama de temperatura variável, de acordo com a regulagem",
                           Preco="€20,00", Imagem="bico_de_bunsen.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=12, Nome = "Cadinho ou cápsula de porcelana",
                           Descricao ="É usada em evaporação ou secagem e pode ser levada ao fogo sobre tela de amianto",
                           Preco="€30,00", Imagem="Capsupa_de_porcelana.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=13, Nome = "Suporte universal, garra e pinças de fixação",
                           Descricao ="Usados para segurar e sustentar vidrarias, como balões e condensadores, entre outros",
                           Preco="€20,00", Imagem="pinças_e_garras.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=14, Nome = "Tripé de ferro",
                           Descricao ="Usado como apoio para tela de amianto e outros objetos a serem aquecidos",
                           Preco="€20,00", Imagem="tripe_de_ferro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=15, Nome = "Tela de amianto",
                           Descricao ="Suporte para as peças a serem aquecidas. A função do amianto é distribuir uniformemente o calor recebido pela chama do bico de Bunsen",
                           Preco="€30,00", Imagem="tela_de_amianto.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=16, Nome = "Estante para tubos de ensaio",
                           Descricao ="É utilizado para apoiar tubos de ensaio",
                           Preco="€20,00", Imagem="estante_para_os_tubos.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=17, Nome = "Funil de Buchner",
                           Descricao ="Usado em filtrações a vácuo, pode substituir os cadinhos de Gooch",
                           Preco="€20,00", Imagem="funil_de_bucher.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=18, Nome = "Kitassato",
                           Descricao ="Recipiente de vidro com paredes super-reforçadas e indicado para filtrações a vácuo",
                           Preco="€20,00", Imagem="Kitassato.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=19, Nome = "Funil de separação",
                           Descricao ="Utilizado na separação de misturas de líquidos imiscíveis. Também pode ser chamado funil de decantação ou funil de bromo",
                           Preco="€30,00", Imagem="funil_de_separacao.Jpeg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=20, Nome = "Pisseta",
                           Descricao ="Deve conter solventes, água ou soluções de sabões e é utilizada para efetuar lavagens de outras vidrarias",
                           Preco="€30,00", Imagem="pisseta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=21, Nome = "Suporte de bureta",
                           Descricao ="Ferramentas para reforçar a Bureta, a ampola de decantação combinado com o anel de suporte ou grampo",
                           Preco="€15,00", Imagem="suporte_de-burreta.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=22, Nome = "Jarra de vidro",
                           Descricao ="Como um recipiente que é usado para saturar o eluente no corante de teste",
                           Preco="€30,00", Imagem="jarra_de_vidro.jpg", Tipo="Instrumento"},
               new Produtos  {ProdutoID=23, Nome = "Dessecador",
                           Descricao ="Usado como um lugar para se refrescar equipamentos / materiais e absorver a umidade após a secagem",
                           Preco="€30,00", Imagem="dessecador.jpg", Tipo="Instrumento"},
               new Produtos {ProdutoID=24, Nome="Ácido sulfúrico",
                           Descricao ="O ácido sulfúrico, H2SO4, é um ácido mineral forte. É solúvel na água em qualquer concentração. Uma característica peculiar ao ácido sulfúrico é quanto ao seu comportamento relacionado à concentração. Quando diluído (abaixo de concentrações molares de 90%), a solução assume caráter de ácido forte e não apresenta poder desidratante. Por outro lado, quando é concentrado (acima de 90%), deixa de ter caráter ácido e acentua-se o seu poder desidratante. Soluções concentradas deste ácido possuem pH=1,5.",
                           Preco="€60,00", Imagem="Acido_sulfurico.jpg", Tipo="Material"},
               new Produtos {ProdutoID=25, Nome="Bissulfito de sódio",
                           Descricao="Hidrogenosulfito de sódio ou bissulfito de sódio é um composto químico com a fórmula NaHSO3. Bissulfito de sódio é um aditivo alimentar com número E E-222. Bissulfito de sódio em contato com alvejante de cloro (solução aquosa de hipoclorito de sódio) irá produzir vapores nocivos.",
                           Preco="€50,00", Imagem="Bissulfito_de_Sodio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=26, Nome="Bórax",
                            Descricao="O bórax (Na2B4O7·10H2O), também conhecido como Borato de sódio ou Tetraborato de sódio é um mineral alcalino derivado da mistura de um sal hidratado de sódio e ácido bórico. Facilmente solúvel em água, é frequentemente formado na natureza como evaporito. Por isso é encontrado na forma de pequenos cristais agrupados facilmente friável, com aparência macroscópica de um pó esbranquiçado. Microscopicamente seus cristais são transparentes e de pequena dureza.",
                            Preco="€32,00", Imagem="Borax.jpg", Tipo="Material"},
               new Produtos {ProdutoID=27, Nome="Brometo de Potássio",
                            Descricao="Brometo de potássio (KBr) é um composto químico, formado de potássio e bromo, de fórmula KBr. É um sal sólido, cristalino de cor branca, higroscópico, solúvel em água e em etanol. Devido a sua natureza iônica, sua solução aquosa é um condutor elétrico.",
                            Preco="€30,00", Imagem="Brometo_Potassio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=28, Nome="Brometo de sódio",
                            Descricao="Brometo de sódio é um sal com fórmula NaBr, largamente usado como um anticonvulsivo e um sedativo no século XIX e no início do século XX. Sua ação se dá pelo íon brometo (brometo de potássio é igualmente efetivo). É um sal sólido branco cristalino de alto ponto de fusão que lembra o cloreto de sódio. É amplamente usado como fonte do íon brometo.",
                            Preco="€40,00", Imagem="Brometo_Sodio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=29, Nome="Butanona",
                            Descricao="Butanona é um composto químico de fórmula C4H8O ou CH3COC2H3. É um líquido incolor inflamável com um odor doce penetrante. É uma cetona, também conhecida como metil-etil-cetona (MEK de methyl ethyl ketone).",
                            Preco="€50,00", Imagem="butanona.jpg", Tipo="Material"},
               new Produtos {ProdutoID=30, Nome="Carbonato de amónio",
                            Descricao="Carbonato de amônio é o composto químico de fórmula (NH4)2CO3 conhecido comercialmente como 'sal de amônio' ou 'sal volátil'.O carbonato de amônio é produzido pela hidrólise da ureia aplicada ao solo. O carbonato de amônio , sendo um composto instável, na presença de água, dissocia-se em íons NH4 e CO3.",
                            Preco="€40,00", Imagem="Carbonato_Amonio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=31, Nome="Carbonato de potássio",
                            Descricao="Carbonato de potássio é um composto químico de fórmula K2CO3. É um sal branco, solúvel em água (insolúvel em álcool), na qual forma uma solução fortemente alcalina. Pode ser produzido pela reação de absorção de dióxido de carbono pelo hidróxido de potássio. É deliquescente, frequentemente apresentando-se como um sólido úmido ou molhado. Misturada com água causa uma reação exotérmica que resulta em aumento de temperatura.",
                            Preco="€50,00", Imagem="Carbonato_Potassio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=32, Nome="Enxofre",
                            Descricao="O enxofre (do latim sulphur) é um elemento químico de símbolo S, número atômico 16 e de massa atômica 32 u. À temperatura ambiente, o enxofre encontra-se no estado sólido. É um não-metal insípido e inodoro,(O famoso 'Cheiro de enxofre' vem de seus compostos voláteis, por exemplo o Sulfeto de hidrogênio), facilmente reconhecido na forma de cristais amarelos que ocorrem em diversos minerais de sulfito e sulfato, ou mesmo em sua forma pura(especialmente em regiões vulcânicas).",
                            Preco="€30,00", Imagem="Enxofre.jpg", Tipo="Material"},
               new Produtos {ProdutoID=33, Nome="Eritorbato de sódio",
                            Descricao="Eritorbato de sódio (C6H7NaO6) é usado predominantemente em carnes, aves, e bebidas não alcoólicas na indústria de alimentos.",
                            Preco="€40,00", Imagem="Eritorbato_Sodio.jpeg", Tipo="Material"},
               new Produtos {ProdutoID=34, Nome="Carbonato de Calcio",
                            Descricao="Carbonato de cálcio é uma substância química de fórmula CaCO3. É o principal componente de rochas como os calcários. Tem características alcalinas (ou seja, é um sal com características básicas que aumenta o pH de uma solução aquosa) e é resultado da reação do óxido de cálcio (cal virgem) com dióxido de carbono.",
                            Preco="€55,50", Imagem="Carbonato_Calcio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=35, Nome="Cloreto de Calcio",
                            Descricao="Cloreto de cálcio é um composto químico formado por cálcio e cloro. É extremamente solúvel em água e é deliquescente. É um sal que se apresenta no estado sólido à temperatura ambiente e comporta-se como um típico haleto iônico.",
                            Preco="€40,30", Imagem="Cloreto_Calcio.jpeg", Tipo="Material"},
               new Produtos {ProdutoID=36, Nome="Cloreto de magnésio",
                            Descricao="Cloreto de magnésio é um composto químico de fórmula MgCl2, usado para diversos fins, designadamente na culinária, para preparação de tofu a partir do leite de soja, na medicina, com fins terapêuticos, ou mesmo na indústria, como anti-congelante ou para produção de magnésio por electrólise.",
                            Preco="€56,00", Imagem="Cloreto_Magnessio.jpg", Tipo="Material"},
               new Produtos {ProdutoID=37, Nome="Cloreto de amónio",
                            Descricao="O cloreto de amónio, cuja fórmula química é NH 4 Cl, é um sólido incolor oubranco, cristaliza no sistema cúbico, possui uma densidade relativa de 1,53 esublima a 340 º C. É muito solúvel em água e ligeiramente solúvel em etanolmas insolúvel em éter.",
                            Preco="€40,55", Imagem="Cloreto_Amonio.jpg", Tipo="Material"}
            };

            produtos.ForEach(pp => context.Produtos.AddOrUpdate(p => p.Nome, pp)); //metodo ForEach, pegar cada um dos objetos da lista vai fazer o trabalho que esta fazer 
                                                                                   //pp é variavel interna, => apenas é um simbolo de C#, significa 
            context.SaveChanges();      //igual o commit do mySql  

            //################################################################################
            //Adiciona um utilizador
            //################################################################################
            var utilizador = new List<Utilizadores>
            {
                new Utilizadores {UtilizadorID=1, Nome="Santos Pires", Email="santospires@hotmail.com",
                                 Morada ="Santarem", CodPostal="2004-001", NIF=976567764, Contacto="965567323", Imagem="Santos_Pires.png"},
                new Utilizadores {UtilizadorID=2, Nome="Andre Quintão", Email="andrequintao99@yahoo.com",
                                 Morada ="Entroncamento",  CodPostal="2330-501", NIF=786543987, Contacto="925676332",  Imagem="Andre_Quintao.jpg"},
                new Utilizadores {UtilizadorID=3, Nome="Manuel Pinto Sousa", Email="manuel1982@hotmail.com",
                                 Morada ="Tomar", CodPostal="2300-313", NIF=985345789, Contacto="963387123", Imagem="Manuel_Pinto.png"},
                new Utilizadores {UtilizadorID=4, Nome="Mariano Freitas", Email="freitasmariano90@gmail.com",
                                 Morada ="Torres Novas", CodPostal="2350-222", NIF=723491876, Contacto="966789552", Imagem="Mariano_Freitas.png"},
                new Utilizadores {UtilizadorID=5, Nome="Mario Suares", Email="suares1985@gmail.com",
                                 Morada ="Lisboa", CodPostal="1000-105", NIF=963452679, Contacto="92776929", Imagem="Mario_Suares.jpeg"},
                new Utilizadores {UtilizadorID=6, Nome="Martinho Gusmão", Email="gusmao1979@hotmail.com",
                                 Morada ="Lisboa", CodPostal="1000-110", NIF=879658976, Contacto="965556743", Imagem="Martinho_Gusmao.jpeg"},
                new Utilizadores {UtilizadorID=7, Nome="Rosito Belo Martins", Email="rositobelo@yahoo.com",
                                 Morada ="Entroncamento", CodPostal="2330-501", NIF=879653289, Contacto="936656992", Imagem="Rosito_Belo.png"},
            };

            utilizador.ForEach(uu => context.Utilizadores.AddOrUpdate(u => u.Nome, uu)); //metodo ForEach, pegar cada um dos objetos da lista vai fazer o trabalho que esta fazer 
                                                                                         //uu é variavel interna, => apenas é um simbolo de C#, significa 
            context.SaveChanges();      //igual o commit do mySql


            //################################################################################
            //Adiciona uma compra
            //################################################################################
            var compra = new List<Compras>
            {
                new Compras {CompraID=1, Data=new DateTime(2016, 7, 9), UtilizadorFK=1},
                new Compras {CompraID=2, Data=new DateTime(2015, 9, 9), UtilizadorFK=3},
                new Compras {CompraID=3, Data=new DateTime(2017, 1, 7), UtilizadorFK=7},
                new Compras {CompraID=4, Data=new DateTime(2012, 2, 27), UtilizadorFK=5},
                new Compras {CompraID=5, Data=new DateTime(2011, 9, 17), UtilizadorFK=4},
                new Compras {CompraID=6, Data=new DateTime(2013, 10, 20), UtilizadorFK=7},
                new Compras {CompraID=7, Data=new DateTime(2016, 9, 16), UtilizadorFK=2},
                new Compras {CompraID=8, Data=new DateTime(2014, 11, 19), UtilizadorFK=1},
                new Compras {CompraID=9, Data=new DateTime(2012, 9, 23), UtilizadorFK=4},
                new Compras {CompraID=10, Data=new DateTime(2015, 5, 15), UtilizadorFK=3},
                new Compras {CompraID=11, Data=new DateTime(2014, 9, 8), UtilizadorFK=7},
                new Compras {CompraID=12, Data=new DateTime(2013, 9, 17), UtilizadorFK=6},
                new Compras {CompraID=13, Data=new DateTime(2010, 2, 18), UtilizadorFK=5},
                new Compras {CompraID=14, Data=new DateTime(2011, 8, 29), UtilizadorFK=5},
                new Compras {CompraID=15, Data=new DateTime(2016, 9, 12), UtilizadorFK=7},
                new Compras {CompraID=16, Data=new DateTime(2015, 12, 11), UtilizadorFK=3},
                new Compras {CompraID=17, Data=new DateTime(2012, 9, 10), UtilizadorFK=2}
            };

            compra.ForEach(cc => context.Compras.AddOrUpdate(c => c.Data, cc));//metodo ForEach, pegar cada um dos objetos da lista vai fazer o trabalho que esta fazer 
                                                                               //cc é variavel interna, => apenas é um simbolo de C#, significa 
            context.SaveChanges();      //igual o commit do mySql

            //################################################################################
            //Adiciona uma Compra_Produto
            //################################################################################
            var compraProduto = new List<Compras_Produtos>
            {
                new Compras_Produtos {Compras_ProdutoID=1, Quantidade=2, Preco="€120,00", CompraFK=1, ProdutoFK=2},
                new Compras_Produtos {Compras_ProdutoID=2, Quantidade=4, Preco="€200,00", CompraFK=3, ProdutoFK=5},
                new Compras_Produtos {Compras_ProdutoID=3, Quantidade=1, Preco="€50,00", CompraFK=2, ProdutoFK=6},
                new Compras_Produtos {Compras_ProdutoID=4, Quantidade=2, Preco="€160,00", CompraFK=5, ProdutoFK=9},
                new Compras_Produtos {Compras_ProdutoID=5, Quantidade=4, Preco="€300,00", CompraFK=7, ProdutoFK=10},
                new Compras_Produtos {Compras_ProdutoID=6, Quantidade=3, Preco="€200,00", CompraFK=8, ProdutoFK=11},
                new Compras_Produtos {Compras_ProdutoID=7, Quantidade=5, Preco="€400,00", CompraFK=9, ProdutoFK=15},
                new Compras_Produtos {Compras_ProdutoID=8, Quantidade=4, Preco="€300,00", CompraFK=10, ProdutoFK=1},
                new Compras_Produtos {Compras_ProdutoID=9, Quantidade=2, Preco="€250,00", CompraFK=2, ProdutoFK=23},
                new Compras_Produtos {Compras_ProdutoID=10, Quantidade=5, Preco="€600,00", CompraFK=1, ProdutoFK=17},
                new Compras_Produtos {Compras_ProdutoID=11, Quantidade=4, Preco="€300,00", CompraFK=6, ProdutoFK=14},
                new Compras_Produtos {Compras_ProdutoID=12, Quantidade=3, Preco="€400,00", CompraFK=8, ProdutoFK=24},
                new Compras_Produtos {Compras_ProdutoID=13, Quantidade=4, Preco="€400,00", CompraFK=9, ProdutoFK=25},
                new Compras_Produtos {Compras_ProdutoID=14, Quantidade=4, Preco="€300,00", CompraFK=10, ProdutoFK=27},
                new Compras_Produtos {Compras_ProdutoID=15, Quantidade=5, Preco="€450,00", CompraFK=11, ProdutoFK=28},
                new Compras_Produtos {Compras_ProdutoID=16, Quantidade=4, Preco="€350,00", CompraFK=8, ProdutoFK=15},
                new Compras_Produtos {Compras_ProdutoID=17, Quantidade=4, Preco="€350,00", CompraFK=9, ProdutoFK=18},
                new Compras_Produtos {Compras_ProdutoID=18, Quantidade=3, Preco="€150,00", CompraFK=10, ProdutoFK=19},
                new Compras_Produtos {Compras_ProdutoID=19, Quantidade=6, Preco="€200,00", CompraFK=12, ProdutoFK=20},
                new Compras_Produtos {Compras_ProdutoID=20, Quantidade=3, Preco="€300,00", CompraFK=2, ProdutoFK=21},
                new Compras_Produtos {Compras_ProdutoID=21, Quantidade=4, Preco="€500,00", CompraFK=6, ProdutoFK=22},
                new Compras_Produtos {Compras_ProdutoID=22, Quantidade=4, Preco="€500,00", CompraFK=8, ProdutoFK=12},
                new Compras_Produtos {Compras_ProdutoID=23, Quantidade=5, Preco="€550,00", CompraFK=9, ProdutoFK=15},
                new Compras_Produtos {Compras_ProdutoID=24, Quantidade=8, Preco="€800,00", CompraFK=12, ProdutoFK=19},
                new Compras_Produtos {Compras_ProdutoID=25, Quantidade=6, Preco="€550,00", CompraFK=7, ProdutoFK=29},
                new Compras_Produtos {Compras_ProdutoID=26, Quantidade=4, Preco="€400,00", CompraFK=9, ProdutoFK=30}
            };

            compraProduto.ForEach(cp => context.Compras_Produtos.Add(cp)); //metodo ForEach, pegar cada um dos objetos da lista vai fazer o trabalho que esta fazer 
                                                                           //cp é variavel interna, => apenas é um simbolo de C#, significa 
            context.SaveChanges();                                         //igual o commit do mySql
        }
    }
    }

