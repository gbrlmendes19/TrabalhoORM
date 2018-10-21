using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using TrabalhoORM;

namespace TrabalhoORM.Migrations
{
    [DbContext(typeof(EstudioContext))]
    [Migration("20181021003305_Classes")]
    partial class Classes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TrabalhoORM.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("nome");

                    b.Property<string>("telefone");

                    b.HasKey("Id");

                    b.ToTable("Atores");
                });

            modelBuilder.Entity("TrabalhoORM.Atuacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("atorId");

                    b.Property<int?>("filmeId");

                    b.Property<int>("idAtor");

                    b.Property<int>("idFilme");

                    b.Property<string>("papel");

                    b.HasKey("Id");

                    b.HasIndex("atorId");

                    b.HasIndex("filmeId");

                    b.ToTable("Atuacoes");
                });

            modelBuilder.Entity("TrabalhoORM.DirecaoFilme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("diretorId");

                    b.Property<int?>("filmeId");

                    b.Property<int>("idDiretor");

                    b.Property<int>("idFilme");

                    b.HasKey("Id");

                    b.HasIndex("diretorId");

                    b.HasIndex("filmeId");

                    b.ToTable("Direcoes");
                });

            modelBuilder.Entity("TrabalhoORM.Diretor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("endereco");

                    b.Property<string>("nome");

                    b.Property<string>("telefone");

                    b.HasKey("Id");

                    b.ToTable("Diretores");
                });

            modelBuilder.Entity("TrabalhoORM.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("atorId");

                    b.Property<DateTime>("dtGravacaoFinal");

                    b.Property<DateTime>("dtGravacaoInicio");

                    b.Property<int>("idAtorRoteirista");

                    b.Property<string>("titulo");

                    b.Property<double>("verba");

                    b.HasKey("Id");

                    b.HasIndex("atorId");

                    b.ToTable("Filmes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Filme");
                });

            modelBuilder.Entity("TrabalhoORM.ProducaoFilme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("filmeId");

                    b.Property<int>("idFilme");

                    b.Property<int>("idProdutor");

                    b.Property<int?>("produtorId");

                    b.HasKey("Id");

                    b.HasIndex("filmeId");

                    b.HasIndex("produtorId");

                    b.ToTable("Producoes");
                });

            modelBuilder.Entity("TrabalhoORM.Produtor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("email");

                    b.Property<string>("nome");

                    b.Property<string>("telefone");

                    b.HasKey("Id");

                    b.ToTable("Produtores");
                });

            modelBuilder.Entity("TrabalhoORM.Documentario", b =>
                {
                    b.HasBaseType("TrabalhoORM.Filme");

                    b.Property<string>("assunto");

                    b.ToTable("Documentarios");

                    b.HasDiscriminator().HasValue("Documentario");
                });

            modelBuilder.Entity("TrabalhoORM.LongaMetragem", b =>
                {
                    b.HasBaseType("TrabalhoORM.Filme");

                    b.Property<string>("categoria");

                    b.ToTable("Longas");

                    b.HasDiscriminator().HasValue("LongaMetragem");
                });

            modelBuilder.Entity("TrabalhoORM.Atuacao", b =>
                {
                    b.HasOne("TrabalhoORM.Ator", "ator")
                        .WithMany()
                        .HasForeignKey("atorId");

                    b.HasOne("TrabalhoORM.Filme", "filme")
                        .WithMany()
                        .HasForeignKey("filmeId");
                });

            modelBuilder.Entity("TrabalhoORM.DirecaoFilme", b =>
                {
                    b.HasOne("TrabalhoORM.Diretor", "diretor")
                        .WithMany()
                        .HasForeignKey("diretorId");

                    b.HasOne("TrabalhoORM.Filme", "filme")
                        .WithMany()
                        .HasForeignKey("filmeId");
                });

            modelBuilder.Entity("TrabalhoORM.Filme", b =>
                {
                    b.HasOne("TrabalhoORM.Ator", "ator")
                        .WithMany()
                        .HasForeignKey("atorId");
                });

            modelBuilder.Entity("TrabalhoORM.ProducaoFilme", b =>
                {
                    b.HasOne("TrabalhoORM.Filme", "filme")
                        .WithMany()
                        .HasForeignKey("filmeId");

                    b.HasOne("TrabalhoORM.Produtor", "produtor")
                        .WithMany()
                        .HasForeignKey("produtorId");
                });
        }
    }
}
