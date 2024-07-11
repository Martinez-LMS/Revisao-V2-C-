﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 13, 20, 31, 18, 482, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 12, 20, 31, 18, 482, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 11, 20, 31, 18, 482, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 13, 20, 31, 18, 482, DateTimeKind.Local).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 17, 20, 31, 18, 482, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 24, 20, 31, 18, 482, DateTimeKind.Local).AddTicks(5499));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "39be53a2-fc09-4b6a-bafa-18a6a23c8f6e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 4, 13, 30, 2, 76, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "6d091456-5a2f-4b5a-98fc-f1a3b50a627d",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 3, 13, 30, 2, 76, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "CategoriaId",
                keyValue: "bfe4e7dc-81e4-4e47-a67b-d4fbf3e124bd",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 2, 13, 30, 2, 76, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "2f1b7dc1-3b9a-4e1a-a389-7f5d2f1c8f3e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 4, 13, 30, 2, 76, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "6a8b3e4d-5e4e-4f7e-bdc9-9181e456ad0e",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 8, 13, 30, 2, 76, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Tarefas",
                keyColumn: "TarefaId",
                keyValue: "e5d4a7b9-1f9e-4c4a-ae3b-5b7c1a9d2e3f",
                column: "CriadoEm",
                value: new DateTime(2024, 7, 15, 13, 30, 2, 76, DateTimeKind.Local).AddTicks(1801));
        }
    }
}
