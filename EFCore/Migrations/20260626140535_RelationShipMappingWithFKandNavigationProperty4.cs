using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class RelationShipMappingWithFKandNavigationProperty4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentDeptId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                schema: "dbo",
                table: "DepartmentsInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentsInfo_EmployeeId",
                schema: "dbo",
                table: "DepartmentsInfo",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentsInfo_Employees_EmployeeId",
                schema: "dbo",
                table: "DepartmentsInfo",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_DepartmentsInfo_DepartmentDeptId",
                table: "Employees",
                column: "DepartmentDeptId",
                principalSchema: "dbo",
                principalTable: "DepartmentsInfo",
                principalColumn: "DeptId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DepartmentsInfo_Employees_EmployeeId",
                schema: "dbo",
                table: "DepartmentsInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_DepartmentsInfo_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentsInfo_EmployeeId",
                schema: "dbo",
                table: "DepartmentsInfo");

            migrationBuilder.DropColumn(
                name: "DepartmentDeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                schema: "dbo",
                table: "DepartmentsInfo");
        }
    }
}
