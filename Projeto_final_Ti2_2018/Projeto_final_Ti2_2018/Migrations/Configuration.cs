namespace Projeto_final_Ti2_2018.Migrations
{
    using Projeto_final_Ti2_2018.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SuperDbGes>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed( SuperDbGes context)
        {
            //  This method will be called after migrating to the latest version.

            //Adiciona Clientes
            var clientes = new List<Cliente> {
                 new Cliente{IDCliente=1,Nome="Tânia Borges Vieira",Morada="Rua das Ameijoas nº17, Abrantes",Email="taniabv@falseMail.com",InfoCartaoCredito="",NIF="999123123" },
                 new Cliente{IDCliente=2,Nome="António Miguel Silves Rocha",Morada="Urbanização da Encosta da Barata Bloco C Rés do Chão Esquerdo, Abrantes",Email="antoniomsrocha@falseMail.com",InfoCartaoCredito="",NIF="999456123" },
                 new Cliente{IDCliente=3,Nome="André Rodrigo Antunes Silveira",Morada="Labirinto Vale de Rãs Lote C6 5ºC, Abrantes",Email="andreras@falseMail.com",InfoCartaoCredito="",NIF="999789123" },
                 new Cliente{IDCliente=4,Nome="Lurdes Sousa Vieira",Morada="Rua das Margaridas nº18, Tomar",Email="lsouzav@falseMail.com",InfoCartaoCredito="",NIF="999456789" },
                 new Cliente{IDCliente=5,Nome="Claudia Gomes Pinto",Morada="Campo dos Alecrins nº1, Ferreira de Zêzere",Email="cladiagp98@falseMail.com",InfoCartaoCredito="",NIF="999987123" },
                 new Cliente{IDCliente=6,Nome="Rui Santos Vieira",Morada="Avenida das Forças Armadas nº43, Constância",Email="rui17santos05vieira1985@falseMail.com",InfoCartaoCredito="",NIF="999999987" },
                 new Cliente{IDCliente=7,Nome="Paulos Santos Vieira",Morada="Rua dos Clérigos nº5, Coimbra",Email="paulosv@falseMail.com",InfoCartaoCredito="",NIF="999321456" },
                 new Cliente{IDCliente=8,Nome="Augusto Manuel Carvalho",Morada="Rua Infante D.Henrique Nº7, Chamusca",Email="augustmacarv@falseMail.com",InfoCartaoCredito="",NIF="999456456" },
                 new Cliente{IDCliente=9,Nome="Beatriz Gomes Pinto",Morada="Avenida das Dalilas nº79, Lisboa",Email="bia83@falseMail.com",InfoCartaoCredito="",NIF="999456788" },
                 new Cliente{IDCliente=10,Nome="José Carlos Matos Alves",Morada="Quinta dos Telheiros nº15, Bombarral",Email="zematos@falseMail.com",InfoCartaoCredito="",NIF="999456465" },
                 new Cliente{IDCliente=11,Nome="Manuel Luís Coelho Alfaiate",Morada="Rua Bate Chapas nº5, Cabeça Gorda",Email="mane_alfaiate@falseMail.com",InfoCartaoCredito="",NIF="999500823" },
                 new Cliente{IDCliente=12,Nome="Duarte de Jesus Alguém",Morada="Rua Regadinha nº10, Viseu",Email="duarte_jesus@falseMail.com",InfoCartaoCredito="cartão falso",NIF="999025836" },
                 new Cliente{IDCliente=13,Nome="Rafael Alexandre Moura",Morada="Avenida de S.Salvador nº90, Viseu",Email="rafaela_moura@falseMail.com",InfoCartaoCredito="",NIF="999852014" },
                 new Cliente{IDCliente=14,Nome="Ana Bispo Moita",Morada="Rua Filipa Borges nº12, Barcelos",Email="bispo.ana33@falseMail.com",InfoCartaoCredito="",NIF="999963025" },
                 new Cliente{IDCliente=15,Nome="Carina Silva Nunes",Morada="Rua Calouste Gulbenkian nº5, Monchique",Email="carsilnes156@falseMail.com",InfoCartaoCredito="",NIF="999874120" }

             };
            clientes.ForEach(cl => context.Clientes.AddOrUpdate(c => c.NIF, cl));
            context.SaveChanges();

            //adiciona categorias
            var categorias = new List<Categoria> {
                new Categoria{ IDCategoria=1, Nome="Mercearia"},
                new Categoria{ IDCategoria=2, Nome="Frescos"},
                new Categoria{ IDCategoria=3, Nome="Congelados"},
                new Categoria{ IDCategoria=4, Nome="Bebidas"}

            };
            categorias.ForEach(cc => context.Categorias.AddOrUpdate(c => c.Nome, cc));
            context.SaveChanges();

            //adiciona subCategorias
            var subCategorias = new List<SubCategoria> {
                new SubCategoria{ IDSubCategoria=1, IDCategoriaFK=1, Nome="Arroz e Massa"},
                new SubCategoria{ IDSubCategoria=2, IDCategoriaFK=1, Nome="Farinhas"},
                new SubCategoria{ IDSubCategoria=3, IDCategoriaFK=1, Nome="Azeite, Óleo e Vinagre"},
                new SubCategoria{ IDSubCategoria=4, IDCategoriaFK=1, Nome="Feijão e Grão"},
                new SubCategoria{ IDSubCategoria=5, IDCategoriaFK=1, Nome="Bolachas, Biscoitos e Bolos"},
                new SubCategoria{ IDSubCategoria=6, IDCategoriaFK=1, Nome="Cereais"},
                new SubCategoria{ IDSubCategoria=7, IDCategoriaFK=1, Nome="Leite"},
                new SubCategoria{ IDSubCategoria=8, IDCategoriaFK=2, Nome="Talho"},
                new SubCategoria{ IDSubCategoria=9, IDCategoriaFK=2, Nome="Peixaria"},
                new SubCategoria{ IDSubCategoria=10, IDCategoriaFK=2, Nome="Legumes"},
                new SubCategoria{ IDSubCategoria=11, IDCategoriaFK=2, Nome="Frutas"},
                new SubCategoria{ IDSubCategoria=12, IDCategoriaFK=2, Nome="Queijos"},
                new SubCategoria{ IDSubCategoria=13, IDCategoriaFK=2, Nome="Charcutaria"},
                new SubCategoria{ IDSubCategoria=14, IDCategoriaFK=3, Nome="Vegetais e Fruta Congelada"},
                new SubCategoria{ IDSubCategoria=15, IDCategoriaFK=3, Nome="Pizzas"},
                new SubCategoria{ IDSubCategoria=16, IDCategoriaFK=3, Nome="Gelados e Sobremesas"},
                new SubCategoria{ IDSubCategoria=17, IDCategoriaFK=3, Nome="Peixe"},
                new SubCategoria{ IDSubCategoria=18, IDCategoriaFK=3, Nome="Carne"},
                new SubCategoria{ IDSubCategoria=19, IDCategoriaFK=4, Nome="Água"},
                new SubCategoria{ IDSubCategoria=20, IDCategoriaFK=4, Nome="Sumos e Néctares"},
                new SubCategoria{ IDSubCategoria=21, IDCategoriaFK=4, Nome="Refrigerantes"},
                new SubCategoria{ IDSubCategoria=22, IDCategoriaFK=4, Nome="Cervejas"},
                new SubCategoria{ IDSubCategoria=23, IDCategoriaFK=4, Nome="Vinhos"}

            };
            subCategorias.ForEach(sc => context.SubCatergorias.AddOrUpdate(s => s.Nome, sc));
            context.SaveChanges();

            //adiciona produtos
            var produtos = new List<Produto> {
                    new Produto{ IDProduto=1,Nome="Arroz Cigala Agulha", Descricao="arroz ideal para", Preco=1.69, IVA=0.06, Fotografia="", Peso=1000, Stock=800, IDSubCategoriaFK=1},
                    new Produto{ IDProduto=2,Nome="Massa Milanesa Linguine", Descricao="", Preco=1.29, IVA=0.06, Fotografia="", Peso=500, Stock=250, IDSubCategoriaFK=1},
                    new Produto{ IDProduto=3,Nome="Farinha Nacional", Descricao="farinha com levedura, ideal para bolos", Preco=1.49, IVA=0.06, Fotografia="", Peso=1000, Stock=200, IDSubCategoriaFK=2},
                    new Produto{ IDProduto=4,Nome="Azeite Galo Virgem", Descricao="aroma suave", Preco=4.59, IVA=0.06, Fotografia="", Peso=750, Stock=100, IDSubCategoriaFK=3},
                    new Produto{ IDProduto=5,Nome="Azeite Oliveira da Serra Soberbo", Descricao="sabor intenso", Preco=6.29, IVA=0.06, Fotografia="", Peso=750, Stock=100, IDSubCategoriaFK=3},
                    new Produto{ IDProduto=6,Nome="Óleo Fula", Descricao="reduz o cheiro a fritos", Preco=1.34, IVA=0.06, Fotografia="", Peso=1000, Stock=200, IDSubCategoriaFK=3},
                    new Produto{ IDProduto=7,Nome="Compal Feijão Frade", Descricao="em lata, da gama Sabores da horta", Preco=1.57, IVA=0.06, Fotografia="", Peso=800, Stock=30, IDSubCategoriaFK=4},
                    new Produto{ IDProduto=8,Nome="Compal Grão de Bico", Descricao="em lata, da gama Sabores da horta", Preco=1.57, IVA=0.06, Fotografia="", Peso=800, Stock=35, IDSubCategoriaFK=4},
                    new Produto{ IDProduto=9,Nome="Chiquilin Bolachas Milenares", Descricao="Bolachas com de aveia e trigo com sementes de quinoa", Preco=1.69, IVA=0.06, Fotografia="", Peso=200, Stock=40, IDSubCategoriaFK=5},
                    new Produto{ IDProduto=10,Nome="Kellogs Special K Frutos Vermelhos", Descricao="Rico em fibras", Preco=3.19, IVA=0.06, Fotografia="", Peso=375, Stock=50, IDSubCategoriaFK=6},
                    new Produto{ IDProduto=11,Nome="Mimosa Calcio + Meio Gordo", Descricao="Leite rico em calcio", Preco=0.79, IVA=0.06, Fotografia="", Peso=1000, Stock=300, IDSubCategoriaFK=7},
                    new Produto{ IDProduto=12,Nome="Mimosa Magro 0% lactose", Descricao="", Preco=1.19, IVA=0.06, Fotografia="", Peso=1000, Stock=150, IDSubCategoriaFK=7},
                    new Produto{ IDProduto=13,Nome="Asas de Peru", Descricao="da marca lusiaves", Preco=2.25, IVA=0.06, Fotografia="", Peso=1000, Stock=20, IDSubCategoriaFK=8},
                    new Produto{ IDProduto=14,Nome="Perca do Nilo", Descricao="pescado em Uganda", Preco=11.99, IVA=0.06, Fotografia="", Peso=1000, Stock=30, IDSubCategoriaFK=9},
                    new Produto{ IDProduto=15,Nome="Salmão Posta", Descricao="viveiro da Noruega", Preco=10.99, IVA=0.06, Fotografia="", Peso=1000, Stock=30, IDSubCategoriaFK=9},
                    new Produto{ IDProduto=16,Nome="Curgete ", Descricao="", Preco=1.09, IVA=0.06, Fotografia="", Peso=1000, Stock=50, IDSubCategoriaFK=10},
                    new Produto{ IDProduto=17,Nome="Physalis", Descricao="Fruta ácida da familia dos tomates", Preco=1.79, IVA=0.06, Fotografia="", Peso=100, Stock=100, IDSubCategoriaFK=11},
                    new Produto{ IDProduto=18,Nome="Queijo Serras de Penela", Descricao="uma bola", Preco=6.49, IVA=0.13, Fotografia="", Peso=1000, Stock=10, IDSubCategoriaFK=12},
                    new Produto{ IDProduto=19,Nome="Chourição Campofrio", Descricao="", Preco=15.69, IVA=0.06, Fotografia="", Peso=1000, Stock=3, IDSubCategoriaFK=13},
                    new Produto{ IDProduto=20,Nome="Peito de Peru Campofrio", Descricao="forno de lenha", Preco=15.99, IVA=0.06, Fotografia="", Peso=1000, Stock=5, IDSubCategoriaFK=13},
                    new Produto{ IDProduto=21,Nome="Mirtilo", Descricao="", Preco=3.99, IVA=0.06, Fotografia="", Peso=400, Stock=20, IDSubCategoriaFK=14},
                    new Produto{ IDProduto=22,Nome="Ervilhas Iglo", Descricao="saca familiar", Preco=1.69, IVA=0.06, Fotografia="", Peso=1125, Stock=40, IDSubCategoriaFK=14},
                    new Produto{ IDProduto=23,Nome="Pizza de Espinafres Ristorante Dr.Otker", Descricao="sem glúten", Preco=4.29, IVA=0.13, Fotografia="", Peso=325, Stock=10, IDSubCategoriaFK=15},
                    new Produto{ IDProduto=24,Nome="Vienetta Caramelo", Descricao="", Preco=2.27, IVA=0.06, Fotografia="", Peso=600, Stock=8, IDSubCategoriaFK=16},
                    new Produto{ IDProduto=25,Nome="Petit Gateau", Descricao="sobremesa fria", Preco=3.65, IVA=0.13, Fotografia="", Peso=400, Stock=6, IDSubCategoriaFK=16},
                    new Produto{ IDProduto=26,Nome="Grelhados Tomate e Manjericão Iglo", Descricao="para ir ao forno", Preco=4.99, IVA=0.06, Fotografia="", Peso=200, Stock=16, IDSubCategoriaFK=17},
                    new Produto{ IDProduto=27,Nome="Hamburguers de Vaca Iglo", Descricao="saca familiar", Preco=19.99, IVA=0.06, Fotografia="", Peso=1000, Stock=5, IDSubCategoriaFK=18},
                    new Produto{ IDProduto=28,Nome="Garrafão Luso", Descricao="garrafão familiar", Preco=1.86, IVA=0.06, Fotografia="", Peso=7000, Stock=300, IDSubCategoriaFK=19},
                    new Produto{ IDProduto=29,Nome="Compal Manga", Descricao="manga madalena da Colômbia", Preco=1.49, IVA=0.23, Fotografia="", Peso=1000, Stock=24, IDSubCategoriaFK=20},
                    new Produto{ IDProduto=30,Nome="Compal Pêssego", Descricao="pessego paraguaio da Espanha", Preco=1.49, IVA=0.23, Fotografia="", Peso=1000, Stock=26, IDSubCategoriaFK=20},
                    new Produto{ IDProduto=31,Nome="Compal Laranja", Descricao="laranja do Algarve", Preco=1.49, IVA=0.23, Fotografia="", Peso=1000, Stock=20, IDSubCategoriaFK=20},
                    new Produto{ IDProduto=32,Nome="Pepsi Zero Max", Descricao="", Preco=1.73, IVA=0.13, Fotografia="", Peso=2000, Stock=6, IDSubCategoriaFK=21},
                    new Produto{ IDProduto=33,Nome="Sagres Frutos Vermelhos", Descricao="", Preco=1.15, IVA=0.23, Fotografia="", Peso=330, Stock=172, IDSubCategoriaFK=22},
                    new Produto{ IDProduto=34,Nome="Rovisco Pais Premium 2018", Descricao="vinho tinto da região de penisula de Setúbal e Lisboa", Preco=13.99, IVA=0.23, Fotografia="", Peso=750, Stock=24, IDSubCategoriaFK=23}
            };

            produtos.ForEach(pr => context.Produtos.AddOrUpdate(p => p.Nome, pr));
            context.SaveChanges();

            //Adiciona tipo de envio
            var tipoEnvio = new List<TipoEnvio> {
                new TipoEnvio{ ID=1, TiposEnvio="Correio registado" },
                new TipoEnvio{ ID=2, TiposEnvio="Correio normal" },
                new TipoEnvio{ ID=3, TiposEnvio="Correio azul" },
                new TipoEnvio{ ID=4, TiposEnvio="Correio verde" },
                new TipoEnvio{ ID=5, TiposEnvio="Correio expresso" },
                new TipoEnvio{ ID=6, TiposEnvio="Encomendas" }

            };
            tipoEnvio.ForEach(te => context.TiposEnvio.AddOrUpdate(t => t.TiposEnvio, te));
            context.SaveChanges();


            //adiciona regiao de envio
            var regiaoEnvio = new List<RegiaoEnvio> {
                new RegiaoEnvio{ IDRegiaoEnvio=1, NomeRegiao="Santarém" },
                new RegiaoEnvio{ IDRegiaoEnvio=2, NomeRegiao="Chamusca" },
                new RegiaoEnvio{ IDRegiaoEnvio=3, NomeRegiao="Tomar" },
                new RegiaoEnvio{ IDRegiaoEnvio=4, NomeRegiao="Golegã" },
                new RegiaoEnvio{ IDRegiaoEnvio=5, NomeRegiao="Entroncamento" },
                new RegiaoEnvio{ IDRegiaoEnvio=6, NomeRegiao="Torres Novas" },
                new RegiaoEnvio{ IDRegiaoEnvio=7, NomeRegiao="Abrantes" },
                new RegiaoEnvio{ IDRegiaoEnvio=8, NomeRegiao="Sardoal" },
                new RegiaoEnvio{ IDRegiaoEnvio=9, NomeRegiao="Monchique" },
                new RegiaoEnvio{ IDRegiaoEnvio=10, NomeRegiao="Viseu" }

            };
            regiaoEnvio.ForEach(re => context.RegiaoEnvio.AddOrUpdate(r => r.NomeRegiao, re));
            context.SaveChanges();
            
            //adiciona encomendas
            var encomendas = new List<Encomenda>
            {
                new Encomenda{IDEncomenda= 1, DataCriacaoEncomenda= new DateTime(2018,4,1), DataEnvioEncomenda=new DateTime(2018,4,1), EstadoCompra="concluido", CustoEnvio=3.99, MoradaFaturacao="Rua Calouste Gulbenkian nº5", CodPostalFaturacao="8002-125", MoradaEntrega="Rua Calouste Gulbenkian nº5", CodigoPostalEntrega="8002-125", ClienteFK=15, TipoEnvioFK=6, RegiaoEnvioFK=9  },
                new Encomenda{IDEncomenda= 2, DataCriacaoEncomenda= new DateTime(2018,4,1), DataEnvioEncomenda=new DateTime(2018,4,2), EstadoCompra="concluido", CustoEnvio=2.99, MoradaFaturacao="Rua das Margaridas nº18", CodPostalFaturacao="2300-311", MoradaEntrega="Rua das Margaridas nº18", CodigoPostalEntrega="2300-311", ClienteFK=4, TipoEnvioFK=1, RegiaoEnvioFK=3  },
                new Encomenda{IDEncomenda= 3, DataCriacaoEncomenda= new DateTime(2018,4,2), DataEnvioEncomenda=new DateTime(2018,4,4), EstadoCompra="concluido", CustoEnvio=1.99, MoradaFaturacao="Labirinto Vale de Rãs Lote C6 5ºC", CodPostalFaturacao="2200-271", MoradaEntrega="Labirinto Vale de Rãs Lote C6 5ºC", CodigoPostalEntrega="2200-271", ClienteFK=3, TipoEnvioFK=2, RegiaoEnvioFK=7  },
                new Encomenda{IDEncomenda= 4, DataCriacaoEncomenda= new DateTime(2018,4,2), DataEnvioEncomenda=new DateTime(2018,4,3), EstadoCompra="concluido", CustoEnvio=3.50, MoradaFaturacao="Rua Calouste Gulbenkian nº5", CodPostalFaturacao="8002-125", MoradaEntrega="Rua Calouste Gulbenkian nº5", CodigoPostalEntrega="8002-125", ClienteFK=15, TipoEnvioFK=5, RegiaoEnvioFK=9  },
                new Encomenda{IDEncomenda= 5, DataCriacaoEncomenda= new DateTime(2018,4,2), DataEnvioEncomenda=new DateTime(2018,4,5), EstadoCompra="concluido", CustoEnvio=15.99, MoradaFaturacao="Avenida de S.Salvador nº90", CodPostalFaturacao="8500-004", MoradaEntrega="Avenida de S.Salvador nº90", CodigoPostalEntrega="8500-004", ClienteFK=13, TipoEnvioFK=6, RegiaoEnvioFK=10  }
            };
            encomendas.ForEach(ee=> context.Encomendas.AddOrUpdate(e => e.IDEncomenda, ee));
            context.SaveChanges();

            

            //adiciona carrinhoCompras
            var carrinhoCompras = new List<CarrinhoCompras> {
                    new CarrinhoCompras{ ClienteFK=1},
                    new CarrinhoCompras{ ClienteFK=2},
                    new CarrinhoCompras{ ClienteFK=3}

            };

            carrinhoCompras.ForEach(cc => context.CarrinhoCompras.AddOrUpdate(c => c.ClienteFK, cc));
            context.SaveChanges();

            //adiciona carrinhoCompras/produtos
            var carrinhoComprasProdutos = new List<CarrinhoComprasProdutos> {
                new CarrinhoComprasProdutos{ IDcomprasProduto=1, IDCarrinhoComprasFK=1, IDProdutoFK=1, Quantidade=5  },
                new CarrinhoComprasProdutos{ IDcomprasProduto=2, IDCarrinhoComprasFK=3, IDProdutoFK=3, Quantidade=2  },
                new CarrinhoComprasProdutos{ IDcomprasProduto=3, IDCarrinhoComprasFK=2, IDProdutoFK=24, Quantidade=1  }

            };
            carrinhoComprasProdutos.ForEach(ccpr => context.CarrinhoComprasProdutos.AddOrUpdate(ccp => ccp.IDCarrinhoComprasFK, ccpr));
            context.SaveChanges();

            //adiciona encomenda/produtos
            var encomendaProdutos = new List<EncomendaProduto> {
                new EncomendaProduto{ IDEncomendaProduto=1, NomeProduto="Garrafão Luso", Quantidade=3, Preco=5.58, IVA=0.06, IDEncomendaFK=1, IDProdutoFK=28},
                new EncomendaProduto{ IDEncomendaProduto=2, NomeProduto="Hambuger iglo", Quantidade=4, Preco=7.44, IVA=0.06, IDEncomendaFK=2, IDProdutoFK=27},
                new EncomendaProduto{ IDEncomendaProduto=3, NomeProduto="Milanesa Linguine", Quantidade=1, Preco=1.86, IVA=0.06, IDEncomendaFK=3, IDProdutoFK=2}
       
            };

            encomendaProdutos.ForEach(epr => context.EncomendaProdutos.AddOrUpdate(ep => ep.NomeProduto, epr));
            context.SaveChanges();

        }
        }
    }
