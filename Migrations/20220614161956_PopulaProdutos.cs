using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APINet6MySQL___EF_CORE.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Produto(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                 " values ('Coca-Cola Diet','Refrigerante 350ml', 5.45, 'cocacola.jpg', 50, now(), 1)");
            mb.Sql("Insert into Produto(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                 " values ('Banana','banana kg', 4.45, 'banana.jpg',30, now(), 2)");
            mb.Sql("Insert into Produto(Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId)" +
                 " values ('Hamburguer','xtudo', 6.45, 'hamburguer.jpg',10, now(), 3)");

        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Produto");
        }
    }
}
