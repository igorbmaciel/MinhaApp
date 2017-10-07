namespace MinhaApp.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AutoInfracao",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Gravidade = c.Int(nullable: false),
                        Atenuante = c.Boolean(nullable: false),
                        Agravante = c.Boolean(nullable: false),
                        Multa = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Processo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Processo", t => t.Processo_Id)
                .Index(t => t.Processo_Id);
            
            CreateTable(
                "dbo.Processo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RelatoFiscalizacao = c.String(maxLength: 100, unicode: false),
                        DataRelato = c.DateTime(nullable: false),
                        FiscalResponsavel = c.String(maxLength: 500, unicode: false),
                        Fornecedor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fornecedor", t => t.Fornecedor_Id)
                .Index(t => t.Fornecedor_Id);
            
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(maxLength: 500, unicode: false),
                        RazaoSocial = c.String(maxLength: 500, unicode: false),
                        InscricaoMunicipal = c.String(maxLength: 500, unicode: false),
                        ReceitaBruta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Endereco_Id = c.Int(),
                        Produto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Endereco", t => t.Endereco_Id)
                .ForeignKey("dbo.Produto", t => t.Produto_Id)
                .Index(t => t.Endereco_Id)
                .Index(t => t.Produto_Id);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Logradouro = c.String(maxLength: 500, unicode: false),
                        Numero = c.String(maxLength: 500, unicode: false),
                        Complemento = c.String(maxLength: 500, unicode: false),
                        Bairro = c.String(maxLength: 500, unicode: false),
                        Municipio = c.String(maxLength: 500, unicode: false),
                        Cep = c.String(maxLength: 500, unicode: false),
                        Uf = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 500, unicode: false),
                        Marca = c.String(maxLength: 500, unicode: false),
                        Estoque = c.String(maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AutoInfracao", "Processo_Id", "dbo.Processo");
            DropForeignKey("dbo.Processo", "Fornecedor_Id", "dbo.Fornecedor");
            DropForeignKey("dbo.Fornecedor", "Produto_Id", "dbo.Produto");
            DropForeignKey("dbo.Fornecedor", "Endereco_Id", "dbo.Endereco");
            DropIndex("dbo.Fornecedor", new[] { "Produto_Id" });
            DropIndex("dbo.Fornecedor", new[] { "Endereco_Id" });
            DropIndex("dbo.Processo", new[] { "Fornecedor_Id" });
            DropIndex("dbo.AutoInfracao", new[] { "Processo_Id" });
            DropTable("dbo.Produto");
            DropTable("dbo.Endereco");
            DropTable("dbo.Fornecedor");
            DropTable("dbo.Processo");
            DropTable("dbo.AutoInfracao");
        }
    }
}
