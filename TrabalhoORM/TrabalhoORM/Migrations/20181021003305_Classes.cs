using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TrabalhoORM.Migrations
{
    public partial class Classes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: false),
                    nome = table.Column<string>(nullable: false),
                    telefone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diretores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: false),
                    endereco = table.Column<string>(nullable: false),
                    nome = table.Column<string>(nullable: false),
                    telefone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtores",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: false),
                    nome = table.Column<string>(nullable: false),
                    telefone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Filmes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Discriminator = table.Column<string>(nullable: false),
                    atorId = table.Column<int>(nullable: true),
                    dtGravacaoFinal = table.Column<DateTime>(nullable: false),
                    dtGravacaoInicio = table.Column<DateTime>(nullable: false),
                    idAtorRoteirista = table.Column<int>(nullable: true),
                    titulo = table.Column<string>(nullable: false),
                    verba = table.Column<double>(nullable: false),
                    assunto = table.Column<string>(nullable: false),
                    categoria = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Filmes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Filmes_Atores_atorId",
                        column: x => x.atorId,
                        principalTable: "Atores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Atuacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    atorId = table.Column<int>(nullable: true),
                    filmeId = table.Column<int>(nullable: true),
                    idAtor = table.Column<int>(nullable: false),
                    idFilme = table.Column<int>(nullable: false),
                    papel = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atuacoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atuacoes_Atores_atorId",
                        column: x => x.atorId,
                        principalTable: "Atores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atuacoes_Filmes_filmeId",
                        column: x => x.filmeId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Direcoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    diretorId = table.Column<int>(nullable: true),
                    filmeId = table.Column<int>(nullable: true),
                    idDiretor = table.Column<int>(nullable: false),
                    idFilme = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Direcoes_Diretores_diretorId",
                        column: x => x.diretorId,
                        principalTable: "Diretores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Direcoes_Filmes_filmeId",
                        column: x => x.filmeId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Producoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    filmeId = table.Column<int>(nullable: true),
                    idFilme = table.Column<int>(nullable: false),
                    idProdutor = table.Column<int>(nullable: false),
                    produtorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producoes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Producoes_Filmes_filmeId",
                        column: x => x.filmeId,
                        principalTable: "Filmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Producoes_Produtores_produtorId",
                        column: x => x.produtorId,
                        principalTable: "Produtores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atuacoes_atorId",
                table: "Atuacoes",
                column: "atorId");

            migrationBuilder.CreateIndex(
                name: "IX_Atuacoes_filmeId",
                table: "Atuacoes",
                column: "filmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Direcoes_diretorId",
                table: "Direcoes",
                column: "diretorId");

            migrationBuilder.CreateIndex(
                name: "IX_Direcoes_filmeId",
                table: "Direcoes",
                column: "filmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Filmes_atorId",
                table: "Filmes",
                column: "atorId");

            migrationBuilder.CreateIndex(
                name: "IX_Producoes_filmeId",
                table: "Producoes",
                column: "filmeId");

            migrationBuilder.CreateIndex(
                name: "IX_Producoes_produtorId",
                table: "Producoes",
                column: "produtorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atuacoes");

            migrationBuilder.DropTable(
                name: "Direcoes");

            migrationBuilder.DropTable(
                name: "Producoes");

            migrationBuilder.DropTable(
                name: "Diretores");

            migrationBuilder.DropTable(
                name: "Filmes");

            migrationBuilder.DropTable(
                name: "Produtores");

            migrationBuilder.DropTable(
                name: "Atores");
        }
    }
}
