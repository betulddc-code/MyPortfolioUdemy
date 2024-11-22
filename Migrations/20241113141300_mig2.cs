﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolioUdemy.Migrations
{
	/// <inheritdoc />
	public partial class mig2 : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
							name: "ToDoLists",
							columns: table => new
							{
								ToDoListId = table.Column<int>(type: "int", nullable: false)
									.Annotation("SqlServer:Identity", "1, 1"),
								Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
								ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
								Date = table.Column<DateTime>(type: "datetime2", nullable: true),
								Status = table.Column<bool>(type: "bit", nullable: false)
							},
							constraints: table =>
							{
								table.PrimaryKey("PK_ToDoLists", x => x.ToDoListId);
							});
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
			   name: "ToDoLists");
		}
	}
}
