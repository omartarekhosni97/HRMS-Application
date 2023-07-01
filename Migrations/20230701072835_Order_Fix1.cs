using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieHub.Migrations
{
    /// <inheritdoc />
    public partial class Order_Fix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Dishes_MovieId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Dishes_MovieId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_MovieId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "ShoppingCartItems",
                newName: "DishId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_MovieId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_DishId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_DishId",
                table: "OrderItems",
                column: "DishId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Dishes_DishId",
                table: "OrderItems",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Dishes_DishId",
                table: "ShoppingCartItems",
                column: "DishId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Dishes_DishId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Dishes_DishId",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_DishId",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "DishId",
                table: "ShoppingCartItems",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCartItems_DishId",
                table: "ShoppingCartItems",
                newName: "IX_ShoppingCartItems_MovieId");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "OrderItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_MovieId",
                table: "OrderItems",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Dishes_MovieId",
                table: "OrderItems",
                column: "MovieId",
                principalTable: "Dishes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Dishes_MovieId",
                table: "ShoppingCartItems",
                column: "MovieId",
                principalTable: "Dishes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
