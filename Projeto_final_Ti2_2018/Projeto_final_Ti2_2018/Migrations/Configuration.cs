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
                 new Cliente{IDCliente=1,Nome="Tânia Borges Vieira",Email="taniabv@falseMail.com",InfoCartaoCredito="",NIF="999123123" },
                 new Cliente{IDCliente=2,Nome="António Miguel Silves Rocha",Email="antoniomsrocha@falseMail.com",InfoCartaoCredito="",NIF="999456123" },
                 new Cliente{IDCliente=3,Nome="André Rodrigo Antunes Silveira",Email="andreras@falseMail.com",InfoCartaoCredito="",NIF="999789123" },
                 new Cliente{IDCliente=4,Nome="Lurdes Sousa Vieira",Email="lsouzav@falseMail.com",InfoCartaoCredito="",NIF="999456789" },
                 new Cliente{IDCliente=5,Nome="Claudia Gomes Pinto",Email="cladiagp98@falseMail.com",InfoCartaoCredito="",NIF="999987123" },
                 new Cliente{IDCliente=6,Nome="Rui Santos Vieira",Email="rui17santos05vieira1985@falseMail.com",InfoCartaoCredito="",NIF="999999987" },
                 new Cliente{IDCliente=7,Nome="Paulos Santos Vieira",Email="paulosv@falseMail.com",InfoCartaoCredito="",NIF="999321456" },
                 new Cliente{IDCliente=8,Nome="Augusto Manuel Carvalho",Email="augustmacarv@falseMail.com",InfoCartaoCredito="",NIF="999456456" },
                 new Cliente{IDCliente=9,Nome="Beatriz Gomes Pinto",Email="bia83@falseMail.com",InfoCartaoCredito="",NIF="999456788" },
                 new Cliente{IDCliente=10,Nome="José Carlos Matos Alves",Email="zematos@falseMail.com",InfoCartaoCredito="",NIF="999456465" },
                 new Cliente{IDCliente=11,Nome="Manuel Luís Coelho Alfaiate",Email="mane_alfaiate@falseMail.com",InfoCartaoCredito="",NIF="999500823" },
                 new Cliente{IDCliente=12,Nome="Duarte de Jesus Alguém",Email="duarte_jesus@falseMail.com",InfoCartaoCredito="cartão falso",NIF="999025836" },
                 new Cliente{IDCliente=13,Nome="Rafael Alexandre Moura",Email="rafaela_moura@falseMail.com",InfoCartaoCredito="",NIF="999852014" },
                 new Cliente{IDCliente=14,Nome="Ana Bispo Moita",Email="bispo.ana33@falseMail.com",InfoCartaoCredito="",NIF="999963025" },
                 new Cliente{IDCliente=15,Nome="Carina Silva Nunes",Email="carsilnes156@falseMail.com",InfoCartaoCredito="",NIF="999874120" }

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
                new SubCategoria{ IDSubCategoria=2, IDCategoriaFK=1, Nome="Leite"},
                new SubCategoria{ IDSubCategoria=3, IDCategoriaFK=2, Nome="Talho"},
                new SubCategoria{ IDSubCategoria=4, IDCategoriaFK=2, Nome="Peixaria"},
                new SubCategoria{ IDSubCategoria=5, IDCategoriaFK=2, Nome="Legumes"},
                new SubCategoria{ IDSubCategoria=6, IDCategoriaFK=3, Nome="Pizzas"},
                new SubCategoria{ IDSubCategoria=7, IDCategoriaFK=4, Nome="Água"},
                new SubCategoria{ IDSubCategoria=8, IDCategoriaFK=4, Nome="Sumos e Néctares"},
                new SubCategoria{ IDSubCategoria=9, IDCategoriaFK=4, Nome="Refrigerantes"},


            };
            subCategorias.ForEach(sc => context.SubCatergorias.AddOrUpdate(s => s.Nome, sc));
            context.SaveChanges();

            //adiciona produtos
            var produtos = new List<Produto> {
                    new Produto{ IDProduto=1,Nome="Arroz Cigala Agulha", Descricao="arroz ideal para", Preco=1, IVA=6, Fotografia="", Peso=1000, Stock=800, IDSubCategoriaFK=1},
                    new Produto{ IDProduto=2,Nome="Massa Milanesa Linguine", Descricao="", Preco=129, IVA=6, Fotografia="", Peso=500, Stock=250, IDSubCategoriaFK=1},
                    new Produto{ IDProduto=3,Nome="Mimosa Calcio + Meio Gordo", Descricao="Leite rico em calcio", Preco=079, IVA=6, Fotografia="", Peso=1000, Stock=300, IDSubCategoriaFK=2},
                    new Produto{ IDProduto=4,Nome="Mimosa Magro 0% lactose", Descricao="", Preco=119, IVA=6, Fotografia="", Peso=1000, Stock=150, IDSubCategoriaFK=2},
                    new Produto{ IDProduto=5,Nome="Asas de Peru", Descricao="da marca lusiaves", Preco=225, IVA=006, Fotografia="", Peso=1000, Stock=20, IDSubCategoriaFK=3},
                    new Produto{ IDProduto=6,Nome="Perca do Nilo", Descricao="pescado em Uganda", Preco=1199, IVA=006, Fotografia="", Peso=1000, Stock=30, IDSubCategoriaFK=4},
                    new Produto{ IDProduto=7,Nome="Salmão Posta", Descricao="viveiro da Noruega", Preco=1099, IVA=006, Fotografia="", Peso=1000, Stock=30, IDSubCategoriaFK=4},
                    new Produto{ IDProduto=8,Nome="Curgete ", Descricao="", Preco=109, IVA=006, Fotografia="", Peso=1000, Stock=50, IDSubCategoriaFK=5},
                    new Produto{ IDProduto=9,Nome="Pizza de Espinafres Ristorante Dr.Otker", Descricao="sem glúten", Preco=429, IVA=013, Fotografia="", Peso=325, Stock=10, IDSubCategoriaFK=6},
                    new Produto{ IDProduto=10,Nome="Garrafão Luso", Descricao="garrafão familiar", Preco=186, IVA=006, Fotografia="", Peso=7000, Stock=300, IDSubCategoriaFK=7},
                    new Produto{ IDProduto=11,Nome="Compal Manga", Descricao="manga madalena da Colômbia", Preco=149, IVA=023, Fotografia="", Peso=1000, Stock=24, IDSubCategoriaFK=8},
                    new Produto{ IDProduto=12,Nome="Compal Pêssego", Descricao="pessego paraguaio da Espanha", Preco=149, IVA=23, Fotografia="", Peso=1000, Stock=26, IDSubCategoriaFK=8},
                    new Produto{ IDProduto=13,Nome="Compal Laranja", Descricao="laranja do Algarve", Preco=149, IVA=023, Fotografia="", Peso=1000, Stock=20, IDSubCategoriaFK=8},
                    new Produto{ IDProduto=14,Nome="Pepsi Zero Max", Descricao="", Preco=173, IVA=013, Fotografia="", Peso=2000, Stock=6, IDSubCategoriaFK=9},
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
                new Encomenda{IDEncomenda= 1, DataCriacaoEncomenda= new DateTime(2018,4,1), DataEnvioEncomenda=new DateTime(2018,4,1), EstadoCompra="concluido", CustoEnvio=399,
                    MoradaFaturacao ="Rua Calouste Gulbenkian nº5", CodPostalFaturacao="8002-125", MoradaEntrega="Rua Calouste Gulbenkian nº5", CodigoPostalEntrega="8002-125", ClienteFK=15,
                    TipoEnvioFK =6, RegiaoEnvioFK=9  },
                new Encomenda{IDEncomenda= 2, DataCriacaoEncomenda= new DateTime(2018,4,1), DataEnvioEncomenda=new DateTime(2018,4,2), EstadoCompra="concluido", CustoEnvio=299,
                    MoradaFaturacao ="Rua das Margaridas nº18", CodPostalFaturacao="2300-311", MoradaEntrega="Rua das Margaridas nº18", CodigoPostalEntrega="2300-311", ClienteFK=4,
                    TipoEnvioFK =1, RegiaoEnvioFK=3  },
                new Encomenda{IDEncomenda= 3, DataCriacaoEncomenda= new DateTime(2018,4,2), DataEnvioEncomenda=new DateTime(2018,4,4), EstadoCompra="concluido", CustoEnvio=199,
                    MoradaFaturacao ="Labirinto Vale de Rãs Lote C6 5ºC", CodPostalFaturacao="2200-271", MoradaEntrega="Labirinto Vale de Rãs Lote C6 5ºC", CodigoPostalEntrega="2200-271",
                    ClienteFK =3, TipoEnvioFK=2, RegiaoEnvioFK=7  },
                new Encomenda{IDEncomenda= 4, DataCriacaoEncomenda= new DateTime(2018,4,2), DataEnvioEncomenda=new DateTime(2018,4,3), EstadoCompra="concluido", CustoEnvio=350,
                    MoradaFaturacao ="Rua Calouste Gulbenkian nº5", CodPostalFaturacao="8002-125", MoradaEntrega="Rua Calouste Gulbenkian nº5", CodigoPostalEntrega="8002-125", ClienteFK=15,
                    TipoEnvioFK =5, RegiaoEnvioFK=9  },
                new Encomenda{IDEncomenda= 5, DataCriacaoEncomenda= new DateTime(2018,4,2), DataEnvioEncomenda=new DateTime(2018,4,5), EstadoCompra="concluido", CustoEnvio=1599,
                    MoradaFaturacao ="Avenida de S.Salvador nº90", CodPostalFaturacao="8500-004", MoradaEntrega="Avenida de S.Salvador nº90", CodigoPostalEntrega="8500-004", ClienteFK=13,
                    TipoEnvioFK =6, RegiaoEnvioFK=10  }
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
                new CarrinhoComprasProdutos{ IDcomprasProduto=3, IDCarrinhoComprasFK=2, IDProdutoFK=9, Quantidade=1  }

            };
            carrinhoComprasProdutos.ForEach(ccpr => context.CarrinhoComprasProdutos.AddOrUpdate(ccp => ccp.IDCarrinhoComprasFK, ccpr));
            context.SaveChanges();

            //adiciona encomenda/produtos
            var encomendaProdutos = new List<EncomendaProduto> {
                new EncomendaProduto{ IDEncomendaProduto=1, Quantidade=3, Preco=558, IVA=006, IDEncomendaFK=1, IDProdutoFK=10},
                new EncomendaProduto{ IDEncomendaProduto=2, Quantidade=4, Preco=744, IVA=006, IDEncomendaFK=2, IDProdutoFK=10},
                new EncomendaProduto{ IDEncomendaProduto=3, Quantidade=1, Preco=186, IVA=006, IDEncomendaFK=3, IDProdutoFK=2}
       
            };

            encomendaProdutos.ForEach(epr => context.EncomendaProdutos.AddOrUpdate(ep => ep.IDEncomendaProduto, epr));
            context.SaveChanges();

        }
        }
    }
