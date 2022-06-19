using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APINet6MySQL___EF_CORE.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(Nome, ImagemURL) values ('Bebidas','bebidas.jpg')");
            mb.Sql("Insert into Categorias(Nome, ImagemURL) values ('Comida','comida.jpg')");
            mb.Sql("Insert into Categorias(Nome, ImagemURL) values ('Lanches','lanches.jpg')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}
