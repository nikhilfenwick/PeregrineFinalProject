using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BarberServicesCouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "barberCoupons",
                columns: table => new
                {
                    BarberCouponId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BarberCouponCode = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountAmount = table.Column<double>(type: "REAL", nullable: false),
                    MinAmount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_barberCoupons", x => x.BarberCouponId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "barberCoupons");
        }
    }
}
