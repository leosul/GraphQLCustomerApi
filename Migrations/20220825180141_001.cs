﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphQLCustomersManager.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0901014f-e3f9-d7d5-1747-25494defb678"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8611), false, "Rúben Assunção", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8613) },
                    { new Guid("0956f0cb-5ce8-b9ee-4dd5-f89c30daefa3"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8878), true, "Miguel Saraiva", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8880) },
                    { new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8785), false, "Joaquim Loureiro", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8786) },
                    { new Guid("0eadcd5d-6da4-f8de-4ea2-c16e8f306978"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8978), false, "Ivo Carvalho", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8979) },
                    { new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8720), true, "Sara Pinto", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8721) },
                    { new Guid("15c27c1e-70fe-8dcd-5735-eef3addf447e"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8918), false, "Sebastião Teixeira", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8919) },
                    { new Guid("1fa2b8ee-36bc-8b4a-51c2-0d142b45e1d3"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8937), false, "Henrique Machado", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8939) },
                    { new Guid("26704dab-1edf-f36c-5319-da509200664a"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8816), true, "Isac Guerreiro", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8817) },
                    { new Guid("2939488a-ae74-b966-6ef3-e6fe369bd266"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8968), true, "Bruno Rocha", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8970) },
                    { new Guid("2b1fe78f-efbd-06b9-e126-3f3c8011c60b"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8678), true, "Laura Barbosa", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8679) },
                    { new Guid("2f95afa4-bd69-9815-9eaa-659b1c016222"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8657), true, "André Neves", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8658) },
                    { new Guid("36517d08-e560-3599-2714-a5fc615e4a39"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8855), true, "Sandro Ribeiro", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8856) },
                    { new Guid("54c23339-3659-4d0b-5bba-206f6d1ee736"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8889), true, "Hugo Abreu", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8890) },
                    { new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8927), true, "Lorena Rodrigues", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8928) },
                    { new Guid("5b891b29-a6b0-05ae-9379-0ec129248c2d"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8428), true, "Pilar Carvalho", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8429) },
                    { new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8709), true, "Miguel Pereira", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8710) },
                    { new Guid("6986a5ce-6a96-6ca5-d425-7b6d6b6db77f"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8601), false, "Lia Faria", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8602) },
                    { new Guid("6ad37215-8fbb-04bb-2e76-5f3faddbc6b8"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8795), false, "Lorena Esteves", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8796) },
                    { new Guid("6e7a21e1-fc0a-88d4-d552-6fd9b35c5714"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8744), true, "Núria Campos", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8745) },
                    { new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8533), true, "Renato Valente", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8534) },
                    { new Guid("734a75c1-16da-7247-5c5c-4c72f86ac6fc"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8544), true, "Letícia Leite", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8545) },
                    { new Guid("7e53c27e-6f9f-2ed8-6e7e-8b029d209f6d"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8668), false, "Lia Carvalho", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8669) },
                    { new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8486), false, "Adriana Vaz", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8487) },
                    { new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8897), true, "Soraia Andrade", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8898) },
                    { new Guid("91a20c64-4651-d3c6-b899-e3c0de1049d9"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8949), true, "Gabriela Coelho", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8951) },
                    { new Guid("91a2515b-1696-9cb2-8d9e-3d1597950190"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8806), true, "Lourenço Soares", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8807) },
                    { new Guid("9396046a-0e90-135a-e183-125b90ae0536"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8521), false, "Duarte Matos", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8522) },
                    { new Guid("94150ed1-6351-a9f7-c213-68ba7ce9cde9"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8765), true, "Elias Amaral", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8767) },
                    { new Guid("96af2292-2b68-b3ae-f9a9-64c81a69ea71"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8634), true, "Gil Borges", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8635) },
                    { new Guid("9854b33f-3fcc-2677-666f-4b61f39523fe"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8959), false, "Lorena Neto", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8960) },
                    { new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8556), false, "Emanuel Marques", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8557) },
                    { new Guid("9a3be4e8-e1b2-0e1d-7387-de3f5a266b16"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8440), false, "José Oliveira", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8441) },
                    { new Guid("a19c44b0-226c-9f61-8573-4fa1ffc22678"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8688), false, "Alexandre Carneiro", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8689) },
                    { new Guid("a2a9059a-6a66-01df-ad40-5f14ae720c27"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8908), false, "Santiago Santos", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8909) },
                    { new Guid("a41af8f4-bbd6-73b1-4bd4-804185e52a21"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8734), true, "Elias Faria", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8735) },
                    { new Guid("a6d590a8-097c-c634-9485-949a6f568c31"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8699), false, "Benjamim Paiva", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8700) },
                    { new Guid("a96c98df-93fe-b3fa-46b2-b9b104498b1a"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8577), false, "Luena Silva", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8578) },
                    { new Guid("bf8b4143-4229-56a6-c4ba-8ab9fddc618e"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8590), true, "Valter Nogueira", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8591) },
                    { new Guid("c421493e-f49e-d350-2c25-c2046f9a46aa"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8867), false, "Luna Antunes", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8868) },
                    { new Guid("c9704a14-c2c9-ea82-8f75-6e990bb34c1d"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8474), true, "Ricardo Martins", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8475) },
                    { new Guid("cf98d365-6753-2aec-f7f5-e258e49d94fa"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8845), false, "Carlos Amorim", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8846) },
                    { new Guid("d11984aa-7de6-a910-e7bf-748495ac245c"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8754), true, "António Matias", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8755) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("d2326bfa-651a-e8e2-1bb1-0f791e4190a4"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8622), true, "Guilherme Amorim", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8624) },
                    { new Guid("d418387b-096d-0f2a-2873-dc7d2fa1cb76"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8567), false, "Hugo Pacheco", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8568) },
                    { new Guid("d5c1bc86-519a-9714-6d84-1fc51d64763b"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8644), true, "Caetana Valente", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8645) },
                    { new Guid("d7d4e93a-b72b-f6f6-b28f-c11db84ff604"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8070), false, "Ígor Amorim", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8103) },
                    { new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8452), true, "Cecília Reis", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8453) },
                    { new Guid("da548aeb-7e89-dd5b-c1eb-a35703e0c154"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8416), false, "Leonardo Teixeira", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8417) },
                    { new Guid("e8a0ec4e-b058-b3de-38e1-6168297d8e51"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8775), true, "Sara Gonçalves", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8776) },
                    { new Guid("f8ff4a6d-1ba1-4306-16a1-2eb98af936c8"), new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8396), true, "Célia Matias", new DateTime(2022, 8, 25, 19, 1, 41, 440, DateTimeKind.Local).AddTicks(8398) }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("007ca419-b281-2a0f-0ea3-20625befbe01"), new Guid("0eadcd5d-6da4-f8de-4ea2-c16e8f306978"), 11.51m, new DateTime(2019, 12, 1, 0, 16, 10, 485, DateTimeKind.Local).AddTicks(5867), "XJF7783C", 2m },
                    { new Guid("0086b6e0-7d7e-9e56-bcd5-06b20d86e9cd"), new Guid("2f95afa4-bd69-9815-9eaa-659b1c016222"), 9.24m, new DateTime(2021, 9, 24, 17, 42, 11, 474, DateTimeKind.Local).AddTicks(4840), "EDWENEC0", 4m },
                    { new Guid("01e5a237-09cf-23a4-8b10-14c817a01d86"), new Guid("0956f0cb-5ce8-b9ee-4dd5-f89c30daefa3"), 6.43m, new DateTime(2021, 11, 19, 5, 8, 50, 152, DateTimeKind.Local).AddTicks(9928), "EQ2O5Y2A", 5m },
                    { new Guid("056c0109-5340-2955-8071-0eb47964b7a2"), new Guid("d418387b-096d-0f2a-2873-dc7d2fa1cb76"), 8.17m, new DateTime(2019, 12, 9, 11, 50, 2, 212, DateTimeKind.Local).AddTicks(9565), "X13XHBZR", 6m },
                    { new Guid("05d1de90-19ed-0d35-de2f-a98499dc8359"), new Guid("26704dab-1edf-f36c-5319-da509200664a"), 11.28m, new DateTime(2020, 8, 18, 23, 10, 48, 47, DateTimeKind.Local).AddTicks(5508), "PLC924Q2", 5m },
                    { new Guid("060cdcb8-92d2-b4dd-7d62-02c11a292c5b"), new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), 11.04m, new DateTime(2022, 3, 21, 12, 21, 8, 754, DateTimeKind.Local).AddTicks(7077), "1EVOW5D0", 4m },
                    { new Guid("06c43507-a100-3db8-527e-9826e9417a62"), new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), 5.70m, new DateTime(2020, 6, 5, 20, 8, 8, 6, DateTimeKind.Local).AddTicks(5682), "BC9EZY9W", 7m },
                    { new Guid("07044f61-ed7d-9766-7227-c85065f95885"), new Guid("54c23339-3659-4d0b-5bba-206f6d1ee736"), 14.87m, new DateTime(2022, 3, 7, 20, 6, 11, 170, DateTimeKind.Local).AddTicks(7796), "EVE2RXH8", 5m },
                    { new Guid("07e1624e-82fb-9116-093a-d493347ab984"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 10.44m, new DateTime(2020, 11, 7, 17, 43, 1, 14, DateTimeKind.Local).AddTicks(9121), "ZQCT3TXK", 2m },
                    { new Guid("08412b1f-a78a-7e62-8f69-3cc748032987"), new Guid("0901014f-e3f9-d7d5-1747-25494defb678"), 1.84m, new DateTime(2021, 4, 17, 1, 27, 7, 700, DateTimeKind.Local).AddTicks(5464), "JPXUF79F", 2m },
                    { new Guid("09b6acfe-b8a6-56b9-87b5-16ff9697ac77"), new Guid("9396046a-0e90-135a-e183-125b90ae0536"), 11.44m, new DateTime(2021, 2, 15, 15, 57, 33, 885, DateTimeKind.Local).AddTicks(1709), "JIN9DPCY", 6m },
                    { new Guid("0ab1f4d3-9815-6faf-2401-19877967eea4"), new Guid("d5c1bc86-519a-9714-6d84-1fc51d64763b"), 13.21m, new DateTime(2022, 7, 3, 14, 28, 48, 497, DateTimeKind.Local).AddTicks(1369), "FNCIUKUE", 7m },
                    { new Guid("0b5de4e5-448a-6ed2-84f8-a16da88e6027"), new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), 12.87m, new DateTime(2021, 1, 26, 17, 16, 7, 640, DateTimeKind.Local).AddTicks(5623), "VO1IS3B8", 5m },
                    { new Guid("0c5ca9b7-09a8-1521-16e2-4d1a26ccb9af"), new Guid("a6d590a8-097c-c634-9485-949a6f568c31"), 6.54m, new DateTime(2022, 6, 5, 11, 13, 1, 150, DateTimeKind.Local).AddTicks(292), "LVK1WOB0", 5m },
                    { new Guid("0d03dedc-0b3c-dd06-a4ad-b887ce318c9e"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 6.17m, new DateTime(2020, 2, 8, 1, 46, 54, 244, DateTimeKind.Local).AddTicks(2845), "3V4BN0DY", 3m },
                    { new Guid("0e62b578-5163-ed2f-6734-4f06ee4371da"), new Guid("91a2515b-1696-9cb2-8d9e-3d1597950190"), 12.65m, new DateTime(2021, 11, 19, 21, 5, 15, 589, DateTimeKind.Local).AddTicks(7569), "TA7F94Q6", 4m },
                    { new Guid("0f672d84-7150-02d6-122e-f91bf8dc5b4b"), new Guid("91a20c64-4651-d3c6-b899-e3c0de1049d9"), 6.19m, new DateTime(2020, 6, 18, 5, 29, 12, 225, DateTimeKind.Local).AddTicks(4726), "003VMH2C", 6m },
                    { new Guid("1052e367-2b59-0122-eb0d-7292ab5126ab"), new Guid("94150ed1-6351-a9f7-c213-68ba7ce9cde9"), 5.63m, new DateTime(2019, 9, 19, 11, 43, 21, 678, DateTimeKind.Local).AddTicks(962), "AM84YY8B", 5m },
                    { new Guid("105d3a5c-6218-46c3-2ffb-274985ebcf8f"), new Guid("a2a9059a-6a66-01df-ad40-5f14ae720c27"), 4.15m, new DateTime(2022, 2, 9, 5, 7, 56, 623, DateTimeKind.Local).AddTicks(2766), "Q9HKX4RQ", 6m },
                    { new Guid("109be119-c6b7-9804-8a2c-50d688fffaec"), new Guid("6ad37215-8fbb-04bb-2e76-5f3faddbc6b8"), 8.89m, new DateTime(2020, 7, 7, 4, 18, 54, 357, DateTimeKind.Local).AddTicks(6936), "M28HDXXI", 2m },
                    { new Guid("10bf9773-db4d-129e-fcd6-266ecc0899ff"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 10.69m, new DateTime(2020, 2, 27, 12, 41, 19, 84, DateTimeKind.Local).AddTicks(2133), "IRSDJR6Q", 6m },
                    { new Guid("1159c187-a36b-a048-96a4-ebdd69b9ca43"), new Guid("9854b33f-3fcc-2677-666f-4b61f39523fe"), 9.56m, new DateTime(2020, 7, 4, 8, 56, 42, 366, DateTimeKind.Local).AddTicks(1723), "M6CXUBPP", 7m },
                    { new Guid("123bc364-85a8-afd2-69b8-2121ff1da285"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 2.83m, new DateTime(2021, 6, 9, 18, 40, 45, 322, DateTimeKind.Local).AddTicks(4256), "3MQ3INDU", 6m },
                    { new Guid("141f9956-5bf3-23fc-7d89-84ea8d3b4eb4"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 5.19m, new DateTime(2020, 11, 21, 16, 31, 10, 194, DateTimeKind.Local).AddTicks(5659), "ZQ0FOIKU", 5m },
                    { new Guid("15142a6d-8faa-365b-8de7-834acedb0411"), new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), 7.48m, new DateTime(2020, 4, 24, 8, 45, 27, 972, DateTimeKind.Local).AddTicks(9317), "QFBN7P2W", 6m },
                    { new Guid("154c3db3-eeb9-284e-ff94-c52064def422"), new Guid("2f95afa4-bd69-9815-9eaa-659b1c016222"), 11.71m, new DateTime(2020, 6, 19, 6, 20, 18, 914, DateTimeKind.Local).AddTicks(2255), "C8HSNADA", 2m },
                    { new Guid("161a0370-970f-1ab6-062b-69b9cee99bed"), new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), 2.95m, new DateTime(2021, 7, 9, 4, 23, 15, 411, DateTimeKind.Local).AddTicks(6362), "2XLQC42G", 7m },
                    { new Guid("16d86df7-e70e-9427-0382-938dd61fd9eb"), new Guid("9854b33f-3fcc-2677-666f-4b61f39523fe"), 10.78m, new DateTime(2021, 8, 26, 0, 45, 16, 663, DateTimeKind.Local).AddTicks(1202), "2462OMP4", 2m },
                    { new Guid("1715a1b7-cbe8-35c6-20a1-a129b94089c9"), new Guid("1fa2b8ee-36bc-8b4a-51c2-0d142b45e1d3"), 10.28m, new DateTime(2021, 2, 15, 9, 28, 17, 507, DateTimeKind.Local).AddTicks(2265), "9FBOJ3GW", 2m },
                    { new Guid("19c4dff4-25c4-1c37-32d7-558f232fde1e"), new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), 14.78m, new DateTime(2022, 6, 21, 17, 5, 37, 421, DateTimeKind.Local).AddTicks(3180), "QP3ED4IG", 1m },
                    { new Guid("19eec7f2-723a-0e54-51ba-3a6c4e42a90b"), new Guid("e8a0ec4e-b058-b3de-38e1-6168297d8e51"), 8.41m, new DateTime(2020, 4, 13, 5, 50, 50, 387, DateTimeKind.Local).AddTicks(1614), "WY9R8WEQ", 1m },
                    { new Guid("1a19e764-5b95-a802-5556-a0fbc7fa2383"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 8.67m, new DateTime(2020, 12, 10, 1, 52, 26, 793, DateTimeKind.Local).AddTicks(1146), "92YPONJB", 6m },
                    { new Guid("1a21a509-8c3e-7974-0815-b20376c9fffd"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 7.08m, new DateTime(2020, 4, 5, 6, 42, 45, 919, DateTimeKind.Local).AddTicks(954), "J0A6JLTA", 7m },
                    { new Guid("1a340510-b3a6-75c0-8d2d-d42ff343414d"), new Guid("d2326bfa-651a-e8e2-1bb1-0f791e4190a4"), 11.48m, new DateTime(2020, 2, 24, 16, 37, 37, 779, DateTimeKind.Local).AddTicks(6309), "ZI75PCBC", 3m },
                    { new Guid("1a8522df-4a49-a31d-89cd-f514a51d7cb0"), new Guid("d2326bfa-651a-e8e2-1bb1-0f791e4190a4"), 2.58m, new DateTime(2020, 7, 14, 2, 23, 6, 66, DateTimeKind.Local).AddTicks(6571), "UAMJAOJU", 6m },
                    { new Guid("1b188b41-119c-edcb-26ec-f1bf1c77ec44"), new Guid("6986a5ce-6a96-6ca5-d425-7b6d6b6db77f"), 9.88m, new DateTime(2021, 2, 23, 2, 5, 7, 982, DateTimeKind.Local).AddTicks(3819), "DB9ZRZ4T", 3m },
                    { new Guid("1b261801-bd27-a134-0941-9f2fea95a8f9"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 1.84m, new DateTime(2020, 1, 15, 20, 12, 47, 642, DateTimeKind.Local).AddTicks(371), "T2XSPWGA", 3m },
                    { new Guid("1e7efe9e-0062-5f29-08ab-d6feb31a8a8a"), new Guid("91a20c64-4651-d3c6-b899-e3c0de1049d9"), 12.47m, new DateTime(2019, 10, 30, 23, 38, 25, 110, DateTimeKind.Local).AddTicks(3693), "2K5PV914", 8m },
                    { new Guid("1ee4c27e-c3b2-dbbb-4dd0-557b5d38feaa"), new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), 6.74m, new DateTime(2020, 1, 22, 9, 21, 7, 558, DateTimeKind.Local).AddTicks(8133), "4HOQDDV9", 5m },
                    { new Guid("1f05afa9-23c2-88ee-8707-4b47a4b20ca9"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 1.43m, new DateTime(2020, 1, 25, 11, 14, 56, 841, DateTimeKind.Local).AddTicks(4313), "GE2W7W1U", 8m },
                    { new Guid("1f2ccebe-0af8-7590-d043-2886a30008ea"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 13.69m, new DateTime(2019, 9, 6, 11, 0, 51, 834, DateTimeKind.Local).AddTicks(7950), "JEGFJ23D", 7m },
                    { new Guid("1fa440bd-857b-f04f-c4d9-45e8897a48a7"), new Guid("d11984aa-7de6-a910-e7bf-748495ac245c"), 3.47m, new DateTime(2020, 12, 7, 1, 54, 22, 259, DateTimeKind.Local).AddTicks(7801), "LOSRTCZR", 8m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("20672c23-82e8-5c91-7ef6-e4326ad35e48"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 3.76m, new DateTime(2022, 2, 3, 8, 39, 36, 831, DateTimeKind.Local).AddTicks(8740), "14ERVMZ1", 6m },
                    { new Guid("2184868b-10ca-a0c2-0134-b2269159601d"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 3.96m, new DateTime(2021, 2, 2, 14, 27, 25, 709, DateTimeKind.Local).AddTicks(4145), "IFN7BVIP", 5m },
                    { new Guid("21b1a465-edf2-857d-f278-cb8a4f60ddf9"), new Guid("26704dab-1edf-f36c-5319-da509200664a"), 9.81m, new DateTime(2021, 2, 22, 2, 6, 48, 731, DateTimeKind.Local).AddTicks(514), "XEQT4KBD", 3m },
                    { new Guid("221d499a-cb38-6d7e-b76e-12dc507fdd94"), new Guid("c9704a14-c2c9-ea82-8f75-6e990bb34c1d"), 14.18m, new DateTime(2019, 11, 15, 12, 14, 29, 740, DateTimeKind.Local).AddTicks(522), "3XOQFDTR", 6m },
                    { new Guid("2332a0db-0ea3-285f-2421-1abfdb22abe1"), new Guid("d5c1bc86-519a-9714-6d84-1fc51d64763b"), 13.98m, new DateTime(2022, 7, 11, 23, 10, 34, 328, DateTimeKind.Local).AddTicks(9518), "KOZD4RFM", 5m },
                    { new Guid("2442be5c-fa27-222b-5bbe-8f93b5420c6b"), new Guid("a96c98df-93fe-b3fa-46b2-b9b104498b1a"), 1.79m, new DateTime(2022, 8, 14, 11, 27, 36, 797, DateTimeKind.Local).AddTicks(5041), "RA3FMTLU", 3m },
                    { new Guid("25bc3015-b8cf-7333-7558-fe9d54cbdd28"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 8.87m, new DateTime(2022, 1, 1, 8, 11, 43, 906, DateTimeKind.Local).AddTicks(8333), "4F0CWPKE", 6m },
                    { new Guid("262626fb-2a09-95b1-cecc-318770c614ef"), new Guid("6e7a21e1-fc0a-88d4-d552-6fd9b35c5714"), 6.09m, new DateTime(2021, 7, 12, 3, 58, 44, 47, DateTimeKind.Local).AddTicks(8756), "7CPTZHBX", 8m },
                    { new Guid("284b448f-dc6c-f46b-b8c9-d7a0e5ee5149"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 1.59m, new DateTime(2022, 3, 15, 5, 58, 39, 894, DateTimeKind.Local).AddTicks(1277), "FG4VN31Z", 3m },
                    { new Guid("286c5725-678a-443c-c175-f7429f2c6570"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 6.06m, new DateTime(2022, 4, 19, 6, 13, 43, 697, DateTimeKind.Local).AddTicks(2437), "2AUZKLUM", 2m },
                    { new Guid("28a20ee5-42af-6acc-5138-e14f9cee5e30"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 10.13m, new DateTime(2019, 10, 19, 20, 41, 53, 441, DateTimeKind.Local).AddTicks(6542), "8RYMPSUH", 1m },
                    { new Guid("2921db89-b819-9db0-1023-ba84f10e790e"), new Guid("cf98d365-6753-2aec-f7f5-e258e49d94fa"), 9.05m, new DateTime(2022, 7, 28, 13, 23, 13, 273, DateTimeKind.Local).AddTicks(552), "SUX296OZ", 2m },
                    { new Guid("292aa08f-e8bc-317e-8112-270bb4f892f7"), new Guid("bf8b4143-4229-56a6-c4ba-8ab9fddc618e"), 13.85m, new DateTime(2022, 7, 29, 6, 28, 42, 519, DateTimeKind.Local).AddTicks(4698), "16ZWGMFX", 5m },
                    { new Guid("29dac86e-cda3-2c4f-8e3f-023653ca94b2"), new Guid("d5c1bc86-519a-9714-6d84-1fc51d64763b"), 4.69m, new DateTime(2020, 12, 1, 0, 46, 43, 756, DateTimeKind.Local).AddTicks(6918), "MIOK8NM8", 1m },
                    { new Guid("29ee9a01-dca7-16c9-af67-e573f5596951"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 12.22m, new DateTime(2019, 11, 19, 3, 5, 20, 918, DateTimeKind.Local).AddTicks(8399), "WQYOLB69", 5m },
                    { new Guid("2a33dfae-d25c-c59d-a76a-4e02268f3900"), new Guid("cf98d365-6753-2aec-f7f5-e258e49d94fa"), 11.42m, new DateTime(2019, 10, 12, 4, 7, 0, 768, DateTimeKind.Local).AddTicks(1861), "0SWWEV79", 7m },
                    { new Guid("2a72813e-704d-b1bf-67c4-f83668b38358"), new Guid("5b891b29-a6b0-05ae-9379-0ec129248c2d"), 13.46m, new DateTime(2020, 11, 25, 20, 14, 51, 536, DateTimeKind.Local).AddTicks(459), "WVFYHZ4M", 1m },
                    { new Guid("2b3c3303-2f62-a947-b33d-ea246528100a"), new Guid("734a75c1-16da-7247-5c5c-4c72f86ac6fc"), 7.93m, new DateTime(2019, 9, 1, 0, 53, 42, 239, DateTimeKind.Local).AddTicks(4542), "AF5GXQYL", 3m },
                    { new Guid("2c946018-8f43-c1ec-05a0-8e59da54113b"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 2.29m, new DateTime(2021, 3, 14, 21, 36, 43, 674, DateTimeKind.Local).AddTicks(3957), "97ZV5HOC", 3m },
                    { new Guid("2c9daa7e-4f1f-72bf-efbd-20e2ec6f648e"), new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), 2.01m, new DateTime(2019, 10, 2, 2, 32, 6, 335, DateTimeKind.Local).AddTicks(4879), "BY2JH7IR", 4m },
                    { new Guid("2ca27ab9-acd0-bf13-7440-68a72148cccc"), new Guid("36517d08-e560-3599-2714-a5fc615e4a39"), 6.61m, new DateTime(2021, 7, 13, 20, 33, 55, 5, DateTimeKind.Local).AddTicks(9018), "3E6GWQOO", 6m },
                    { new Guid("2cd80732-3396-879b-c0f1-8f95428e4e8b"), new Guid("2f95afa4-bd69-9815-9eaa-659b1c016222"), 14.91m, new DateTime(2019, 10, 27, 7, 51, 20, 556, DateTimeKind.Local).AddTicks(2943), "PRD6MUQS", 1m },
                    { new Guid("2d32918f-0f81-cac4-7eed-c49586804b12"), new Guid("7e53c27e-6f9f-2ed8-6e7e-8b029d209f6d"), 2.26m, new DateTime(2021, 8, 18, 0, 33, 10, 236, DateTimeKind.Local).AddTicks(2176), "EBP6ZMN8", 4m },
                    { new Guid("2d4021e4-eafd-c33a-2dd5-d659e8e8f435"), new Guid("9396046a-0e90-135a-e183-125b90ae0536"), 3.66m, new DateTime(2021, 7, 21, 0, 55, 58, 258, DateTimeKind.Local).AddTicks(2977), "AIPGXR33", 7m },
                    { new Guid("2e268a1d-13f3-566c-a3b4-1fdf1f270474"), new Guid("5b891b29-a6b0-05ae-9379-0ec129248c2d"), 7.09m, new DateTime(2021, 1, 4, 20, 37, 1, 476, DateTimeKind.Local).AddTicks(7165), "8XQJLP6L", 4m },
                    { new Guid("30d1cf8d-bd88-5604-9000-d740773e8331"), new Guid("54c23339-3659-4d0b-5bba-206f6d1ee736"), 12.30m, new DateTime(2019, 10, 25, 8, 9, 18, 932, DateTimeKind.Local).AddTicks(2842), "GP621GG6", 8m },
                    { new Guid("313e7300-7b9f-068e-946e-88cddf506e41"), new Guid("1fa2b8ee-36bc-8b4a-51c2-0d142b45e1d3"), 13.68m, new DateTime(2022, 1, 11, 7, 2, 54, 487, DateTimeKind.Local).AddTicks(9762), "IDJJ7UQC", 3m },
                    { new Guid("3148891a-b664-a08e-8f0f-38d8fe12ea39"), new Guid("7e53c27e-6f9f-2ed8-6e7e-8b029d209f6d"), 14.45m, new DateTime(2021, 12, 19, 2, 54, 32, 938, DateTimeKind.Local).AddTicks(7777), "EBVYJ0IK", 7m },
                    { new Guid("35edc8c0-9ca1-d812-c525-0c5c3fe35528"), new Guid("6986a5ce-6a96-6ca5-d425-7b6d6b6db77f"), 3.99m, new DateTime(2019, 10, 24, 19, 51, 16, 268, DateTimeKind.Local).AddTicks(3697), "TBFNTHLU", 1m },
                    { new Guid("369e03bd-61a6-f81f-f5ab-c3658a7b3735"), new Guid("a19c44b0-226c-9f61-8573-4fa1ffc22678"), 3.11m, new DateTime(2022, 7, 24, 2, 0, 48, 701, DateTimeKind.Local).AddTicks(1178), "ZCJD06K7", 1m },
                    { new Guid("37722a1a-c868-b47b-114f-d6cb0f2ff300"), new Guid("94150ed1-6351-a9f7-c213-68ba7ce9cde9"), 12.46m, new DateTime(2022, 4, 14, 17, 11, 28, 83, DateTimeKind.Local).AddTicks(7610), "OT1X771L", 6m },
                    { new Guid("37ca7270-9e94-7bd1-c311-4ab8f4f1ec3e"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 12.54m, new DateTime(2020, 2, 28, 5, 15, 23, 67, DateTimeKind.Local).AddTicks(113), "1I8UOKCW", 8m },
                    { new Guid("39208843-1666-bda7-d0c9-cf1bfdda6d02"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 11.18m, new DateTime(2022, 8, 14, 19, 21, 8, 767, DateTimeKind.Local).AddTicks(9876), "6JOI1459", 5m },
                    { new Guid("393a6783-8170-1f15-d492-04ec83f349e2"), new Guid("0956f0cb-5ce8-b9ee-4dd5-f89c30daefa3"), 13.29m, new DateTime(2021, 3, 5, 22, 45, 9, 974, DateTimeKind.Local).AddTicks(4185), "Q9ZYODFR", 8m },
                    { new Guid("3a996260-c26e-fb7b-647d-2a7968365e90"), new Guid("9854b33f-3fcc-2677-666f-4b61f39523fe"), 14.49m, new DateTime(2020, 6, 4, 0, 8, 32, 427, DateTimeKind.Local).AddTicks(6215), "0N6W39SY", 6m },
                    { new Guid("3ad2eeb5-9242-b85c-0f10-2ffc0c23b33f"), new Guid("734a75c1-16da-7247-5c5c-4c72f86ac6fc"), 9.04m, new DateTime(2019, 12, 15, 2, 35, 17, 493, DateTimeKind.Local).AddTicks(7434), "ESR6TVVR", 8m },
                    { new Guid("3b7598d5-9d4a-f2fc-ccc7-0beb877e1f7a"), new Guid("9854b33f-3fcc-2677-666f-4b61f39523fe"), 11.02m, new DateTime(2020, 2, 27, 23, 33, 52, 815, DateTimeKind.Local).AddTicks(9633), "6RAF0N5T", 6m },
                    { new Guid("3b78b939-8761-28b6-0d84-93431f224033"), new Guid("9a3be4e8-e1b2-0e1d-7387-de3f5a266b16"), 2.79m, new DateTime(2020, 6, 30, 20, 52, 2, 838, DateTimeKind.Local).AddTicks(5830), "B5DP3WIX", 5m },
                    { new Guid("3bad3465-3402-650b-d2db-67bdb1c74d07"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 14.16m, new DateTime(2021, 5, 7, 0, 35, 54, 369, DateTimeKind.Local).AddTicks(9848), "DORSTTSA", 3m },
                    { new Guid("3d3dbea7-d5cc-1495-d6d3-bbdede6f5ff2"), new Guid("d7d4e93a-b72b-f6f6-b28f-c11db84ff604"), 2.82m, new DateTime(2019, 10, 7, 16, 47, 41, 721, DateTimeKind.Local).AddTicks(5722), "X179RCC4", 2m },
                    { new Guid("3d745d66-e813-56bf-659c-5f89be5c55b8"), new Guid("5b891b29-a6b0-05ae-9379-0ec129248c2d"), 6.03m, new DateTime(2021, 4, 8, 22, 0, 54, 446, DateTimeKind.Local).AddTicks(6687), "BV2GP48R", 1m },
                    { new Guid("3e32b8ee-f645-dc4b-4e58-ca928d26ff8b"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 3.48m, new DateTime(2021, 2, 1, 11, 39, 27, 606, DateTimeKind.Local).AddTicks(9029), "86DH1V29", 6m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("416d043a-f05a-8084-15a4-b140409602ef"), new Guid("a96c98df-93fe-b3fa-46b2-b9b104498b1a"), 10.18m, new DateTime(2020, 10, 28, 14, 2, 57, 451, DateTimeKind.Local).AddTicks(3435), "V1SORY42", 1m },
                    { new Guid("4350733f-5a23-d6db-b007-b04b55c9e36a"), new Guid("0901014f-e3f9-d7d5-1747-25494defb678"), 9.51m, new DateTime(2021, 2, 18, 18, 14, 58, 504, DateTimeKind.Local).AddTicks(7306), "G731HU9F", 3m },
                    { new Guid("45329e8f-fa40-98da-8ad0-95317c9a0618"), new Guid("91a2515b-1696-9cb2-8d9e-3d1597950190"), 8.61m, new DateTime(2021, 4, 15, 8, 42, 24, 783, DateTimeKind.Local).AddTicks(3636), "GS9FM6MD", 7m },
                    { new Guid("45435fcf-3581-82ee-b975-c1ac39960982"), new Guid("6986a5ce-6a96-6ca5-d425-7b6d6b6db77f"), 4.90m, new DateTime(2022, 7, 29, 22, 3, 39, 175, DateTimeKind.Local).AddTicks(6861), "ZXP1B7SR", 4m },
                    { new Guid("461805d4-bcf9-fe0f-01ab-312ab35e78cc"), new Guid("c421493e-f49e-d350-2c25-c2046f9a46aa"), 7.15m, new DateTime(2020, 6, 5, 19, 51, 23, 611, DateTimeKind.Local).AddTicks(6389), "1D16HYIZ", 3m },
                    { new Guid("462fdbad-778f-a75a-36db-e537650dbaf1"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 13.81m, new DateTime(2022, 2, 25, 6, 13, 55, 321, DateTimeKind.Local).AddTicks(7945), "FN29WV8Z", 6m },
                    { new Guid("47658f64-e25b-62b6-e4a6-684bab12d57e"), new Guid("d2326bfa-651a-e8e2-1bb1-0f791e4190a4"), 11.18m, new DateTime(2021, 2, 22, 14, 42, 51, 208, DateTimeKind.Local).AddTicks(4024), "JHAKT1YG", 7m },
                    { new Guid("4a22e375-2fce-e6c4-2ff2-0945bf76640e"), new Guid("a19c44b0-226c-9f61-8573-4fa1ffc22678"), 2.17m, new DateTime(2021, 8, 19, 4, 25, 0, 481, DateTimeKind.Local).AddTicks(1518), "YMK3L578", 7m },
                    { new Guid("4b47bb92-3268-6ba8-615a-977d30b7abef"), new Guid("a19c44b0-226c-9f61-8573-4fa1ffc22678"), 13.42m, new DateTime(2021, 1, 27, 12, 39, 49, 937, DateTimeKind.Local).AddTicks(4578), "55UJ7CU3", 6m },
                    { new Guid("4c7e9282-7885-fa92-8d10-eea2879cda5d"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 9.59m, new DateTime(2019, 11, 3, 1, 8, 56, 728, DateTimeKind.Local).AddTicks(6890), "EO6LXC29", 7m },
                    { new Guid("4c8d82b2-d43a-f69a-1156-e066689459f3"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 2.64m, new DateTime(2021, 10, 17, 10, 15, 28, 0, DateTimeKind.Local).AddTicks(6606), "RYIFUJP2", 2m },
                    { new Guid("4df38631-437b-1604-d958-42c61170edc7"), new Guid("91a20c64-4651-d3c6-b899-e3c0de1049d9"), 14.52m, new DateTime(2022, 2, 20, 12, 45, 14, 277, DateTimeKind.Local).AddTicks(9365), "Y6PBK79K", 8m },
                    { new Guid("4edd383b-d201-a833-d39b-a4ab772b9288"), new Guid("6e7a21e1-fc0a-88d4-d552-6fd9b35c5714"), 12.51m, new DateTime(2022, 4, 6, 17, 54, 55, 602, DateTimeKind.Local).AddTicks(8229), "ZF4NHKGD", 3m },
                    { new Guid("509ab224-ea68-7f2e-6e1a-10a553fbdf43"), new Guid("da548aeb-7e89-dd5b-c1eb-a35703e0c154"), 8.38m, new DateTime(2021, 8, 25, 23, 8, 1, 619, DateTimeKind.Local).AddTicks(9633), "6QT91GFV", 8m },
                    { new Guid("5236ab81-6b08-0cbb-1cad-90e2b61626ad"), new Guid("91a20c64-4651-d3c6-b899-e3c0de1049d9"), 5.64m, new DateTime(2019, 12, 23, 3, 50, 27, 28, DateTimeKind.Local).AddTicks(3999), "9SYG3O2A", 5m },
                    { new Guid("55467f33-e920-85a2-ed3a-84ecab5cf692"), new Guid("1fa2b8ee-36bc-8b4a-51c2-0d142b45e1d3"), 6.22m, new DateTime(2021, 9, 5, 22, 33, 1, 746, DateTimeKind.Local).AddTicks(5385), "SRMO00WK", 5m },
                    { new Guid("56914d94-5cb5-8fa9-4b94-af8260b83323"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 11.69m, new DateTime(2020, 7, 26, 19, 20, 2, 755, DateTimeKind.Local).AddTicks(8774), "G59QFR9R", 7m },
                    { new Guid("587788ad-c965-4533-f1de-2f4498636b0e"), new Guid("9a3be4e8-e1b2-0e1d-7387-de3f5a266b16"), 3.15m, new DateTime(2021, 11, 3, 3, 54, 57, 981, DateTimeKind.Local).AddTicks(833), "CKAAEAYQ", 2m },
                    { new Guid("587a7c85-88e1-dd64-9066-13b53f80245a"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 8.00m, new DateTime(2020, 2, 14, 2, 38, 9, 465, DateTimeKind.Local).AddTicks(4913), "EO3Z7DX6", 6m },
                    { new Guid("5a5a8bd0-a7c5-b805-0ef3-c12c3e2f0c28"), new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), 5.39m, new DateTime(2020, 3, 9, 0, 2, 57, 222, DateTimeKind.Local).AddTicks(7199), "9G5W1NYC", 1m },
                    { new Guid("5ae4d9a9-1aab-f230-44dd-34f43f5bf338"), new Guid("e8a0ec4e-b058-b3de-38e1-6168297d8e51"), 14.47m, new DateTime(2022, 1, 17, 17, 56, 34, 591, DateTimeKind.Local).AddTicks(6032), "725NWKBX", 7m },
                    { new Guid("5b6a3ec6-9d8d-6fcd-a5e3-288ecffd52b6"), new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), 11.16m, new DateTime(2021, 5, 17, 14, 22, 31, 704, DateTimeKind.Local).AddTicks(3876), "Y8MHFCQW", 7m },
                    { new Guid("5c356d89-8f94-5988-b467-ad26c6862995"), new Guid("9396046a-0e90-135a-e183-125b90ae0536"), 7.22m, new DateTime(2020, 10, 8, 19, 14, 10, 293, DateTimeKind.Local).AddTicks(614), "OLH3PV4L", 7m },
                    { new Guid("5d85b8bc-0829-f456-259f-2458a42ca7a2"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 13.51m, new DateTime(2020, 2, 9, 21, 14, 9, 527, DateTimeKind.Local).AddTicks(4551), "HIN8X8KB", 8m },
                    { new Guid("5fb46e43-0bd5-ad47-e690-1ed180531d5f"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 7.75m, new DateTime(2021, 3, 24, 20, 9, 56, 961, DateTimeKind.Local).AddTicks(2607), "GVEQBXLX", 8m },
                    { new Guid("5fcfa809-643b-ddc1-f621-240f39dc52ed"), new Guid("a96c98df-93fe-b3fa-46b2-b9b104498b1a"), 8.98m, new DateTime(2020, 5, 14, 17, 47, 36, 612, DateTimeKind.Local).AddTicks(2428), "Y4FFXIVU", 1m },
                    { new Guid("61997005-ad59-ee4a-52ab-142ffe8927b6"), new Guid("c9704a14-c2c9-ea82-8f75-6e990bb34c1d"), 11.70m, new DateTime(2020, 6, 8, 17, 7, 53, 448, DateTimeKind.Local).AddTicks(2205), "GJXON8D0", 5m },
                    { new Guid("62d5a17f-d0a2-d7eb-968e-e241fd1d2ec0"), new Guid("d11984aa-7de6-a910-e7bf-748495ac245c"), 5.55m, new DateTime(2021, 4, 19, 16, 56, 31, 715, DateTimeKind.Local).AddTicks(1401), "OUFRG28O", 3m },
                    { new Guid("63d8d89c-6138-ae75-7ad4-7ba2e5866919"), new Guid("a96c98df-93fe-b3fa-46b2-b9b104498b1a"), 7.44m, new DateTime(2020, 10, 9, 2, 25, 44, 853, DateTimeKind.Local).AddTicks(4847), "HEF3N08F", 2m },
                    { new Guid("65a78668-cd93-5559-c9f2-77a33617ec41"), new Guid("cf98d365-6753-2aec-f7f5-e258e49d94fa"), 6.05m, new DateTime(2021, 6, 7, 6, 7, 12, 994, DateTimeKind.Local).AddTicks(9110), "TIDLQIPJ", 5m },
                    { new Guid("66a6023a-3cb2-f7b1-13eb-c2010ede71dc"), new Guid("5b891b29-a6b0-05ae-9379-0ec129248c2d"), 1.01m, new DateTime(2021, 11, 2, 1, 55, 50, 617, DateTimeKind.Local).AddTicks(3804), "H5XWKU89", 3m },
                    { new Guid("67a8db60-d29d-4338-2a5f-9407a1d4c378"), new Guid("c9704a14-c2c9-ea82-8f75-6e990bb34c1d"), 9.17m, new DateTime(2020, 6, 4, 16, 34, 14, 682, DateTimeKind.Local).AddTicks(1390), "T2LD94SB", 3m },
                    { new Guid("6a63b985-6e2b-9b0c-9942-52e2a8a14eb4"), new Guid("a2a9059a-6a66-01df-ad40-5f14ae720c27"), 7.06m, new DateTime(2020, 8, 13, 10, 15, 51, 183, DateTimeKind.Local).AddTicks(4460), "4HSW0ZEV", 3m },
                    { new Guid("6bb06e0c-1b46-d9c6-94fe-b19c153c6988"), new Guid("d418387b-096d-0f2a-2873-dc7d2fa1cb76"), 12.56m, new DateTime(2020, 5, 21, 22, 18, 50, 199, DateTimeKind.Local).AddTicks(2790), "UBD1T7JP", 1m },
                    { new Guid("6befb3be-9a86-a882-42f9-54ad707b778e"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 3.76m, new DateTime(2020, 6, 19, 16, 3, 59, 853, DateTimeKind.Local).AddTicks(427), "VIIZRALJ", 3m },
                    { new Guid("6c78a12d-8480-e551-6518-ef7206aa26d6"), new Guid("e8a0ec4e-b058-b3de-38e1-6168297d8e51"), 5.40m, new DateTime(2020, 4, 3, 6, 28, 5, 31, DateTimeKind.Local).AddTicks(5959), "KI84WHGQ", 7m },
                    { new Guid("6e0763e8-9bc0-8b0c-3cb5-e7461e4d17aa"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 9.15m, new DateTime(2020, 7, 20, 11, 42, 3, 246, DateTimeKind.Local).AddTicks(7219), "BHY3QAGQ", 7m },
                    { new Guid("6fbcc2be-eb28-8965-9d4c-89bf02984974"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 13.02m, new DateTime(2022, 7, 30, 23, 31, 58, 633, DateTimeKind.Local).AddTicks(9038), "4B6CMZQF", 3m },
                    { new Guid("6fbddf7b-42e9-a196-e108-bfd89189d5fd"), new Guid("9396046a-0e90-135a-e183-125b90ae0536"), 4.63m, new DateTime(2022, 7, 13, 23, 48, 58, 648, DateTimeKind.Local).AddTicks(3514), "D1UARAAR", 8m },
                    { new Guid("701f6cb1-f583-2147-5113-ebc5560bf00d"), new Guid("15c27c1e-70fe-8dcd-5735-eef3addf447e"), 12.11m, new DateTime(2021, 8, 12, 5, 40, 21, 153, DateTimeKind.Local).AddTicks(5129), "JMAKSLXW", 7m },
                    { new Guid("703842ab-25b9-d851-cb5e-a0f2dc905474"), new Guid("9396046a-0e90-135a-e183-125b90ae0536"), 5.91m, new DateTime(2022, 8, 20, 21, 29, 29, 33, DateTimeKind.Local).AddTicks(9350), "2ET0UTF3", 2m },
                    { new Guid("715ea0af-d019-298f-87ad-835fa8f842e6"), new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), 13.18m, new DateTime(2019, 11, 14, 6, 23, 30, 791, DateTimeKind.Local).AddTicks(8199), "00IFRPK5", 3m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("7197e640-5d7d-2e59-f6a3-791e3606a81c"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 14.14m, new DateTime(2020, 4, 30, 5, 24, 16, 850, DateTimeKind.Local).AddTicks(2434), "F8SZ9RZL", 7m },
                    { new Guid("7202e395-2a93-f076-6e34-49f00e047490"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 13.11m, new DateTime(2022, 1, 7, 21, 5, 4, 589, DateTimeKind.Local).AddTicks(2308), "GFL2C6CX", 2m },
                    { new Guid("723393f8-30f5-0918-08a1-e6ddde9e13e0"), new Guid("2b1fe78f-efbd-06b9-e126-3f3c8011c60b"), 8.38m, new DateTime(2022, 3, 6, 7, 17, 31, 397, DateTimeKind.Local).AddTicks(8762), "1S2JD4A7", 6m },
                    { new Guid("725e2aed-a1c3-a9f3-fa88-8b806719a3de"), new Guid("d5c1bc86-519a-9714-6d84-1fc51d64763b"), 8.62m, new DateTime(2022, 2, 11, 6, 35, 24, 423, DateTimeKind.Local).AddTicks(6953), "RLHP2XEZ", 3m },
                    { new Guid("729a191c-4ee3-c9b1-a941-8afceb3d7e68"), new Guid("d11984aa-7de6-a910-e7bf-748495ac245c"), 10.06m, new DateTime(2020, 8, 1, 7, 51, 0, 861, DateTimeKind.Local).AddTicks(1400), "51O7B19H", 6m },
                    { new Guid("729e2af6-7274-2f26-c7bf-fa3897ae0131"), new Guid("2f95afa4-bd69-9815-9eaa-659b1c016222"), 11.85m, new DateTime(2022, 7, 10, 8, 34, 50, 281, DateTimeKind.Local).AddTicks(9978), "Y1EGSO4Q", 8m },
                    { new Guid("735dffd0-be96-9a2c-56bc-50fafef193a5"), new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), 4.05m, new DateTime(2021, 5, 11, 17, 18, 25, 81, DateTimeKind.Local).AddTicks(5991), "ZO5AAMKS", 4m },
                    { new Guid("761b27f5-834a-6d57-e03e-6738f587b678"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 4.11m, new DateTime(2022, 1, 24, 5, 19, 23, 679, DateTimeKind.Local).AddTicks(583), "Z5RD6ETZ", 3m },
                    { new Guid("78216bde-ca23-52dc-c55e-a33a04c328f8"), new Guid("c9704a14-c2c9-ea82-8f75-6e990bb34c1d"), 3.00m, new DateTime(2022, 1, 13, 12, 43, 20, 563, DateTimeKind.Local).AddTicks(1040), "I3ZQ9ZB3", 2m },
                    { new Guid("78482f3c-c3a2-555c-a317-075a003868aa"), new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), 13.88m, new DateTime(2019, 11, 8, 13, 27, 48, 915, DateTimeKind.Local).AddTicks(3468), "SXGMYEYE", 5m },
                    { new Guid("7b09e9ad-e9e5-f655-dc59-e53a92a2c70f"), new Guid("54c23339-3659-4d0b-5bba-206f6d1ee736"), 9.88m, new DateTime(2020, 3, 25, 5, 35, 14, 203, DateTimeKind.Local).AddTicks(4083), "J4PAJ9DD", 3m },
                    { new Guid("7bd53064-b485-4d41-f99f-8ae3b16fadc0"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 9.86m, new DateTime(2021, 5, 15, 7, 49, 19, 80, DateTimeKind.Local).AddTicks(528), "D6LUZEKO", 8m },
                    { new Guid("7c71eaf9-8c0c-7d8c-e5af-91925a6103f9"), new Guid("7e53c27e-6f9f-2ed8-6e7e-8b029d209f6d"), 8.03m, new DateTime(2021, 8, 10, 0, 23, 35, 761, DateTimeKind.Local).AddTicks(3115), "WUL1H932", 7m },
                    { new Guid("7cf5668c-c7ea-9907-1072-c4dfd8e37cba"), new Guid("2939488a-ae74-b966-6ef3-e6fe369bd266"), 12.15m, new DateTime(2021, 11, 24, 1, 49, 45, 665, DateTimeKind.Local).AddTicks(692), "2SN4ZMMT", 8m },
                    { new Guid("7d2513b7-d4b4-2724-08ba-dcb131ac4eef"), new Guid("d2326bfa-651a-e8e2-1bb1-0f791e4190a4"), 5.34m, new DateTime(2021, 9, 27, 3, 58, 14, 424, DateTimeKind.Local).AddTicks(3466), "LMVTX5ZI", 2m },
                    { new Guid("7d82f7f4-bfa7-b993-2162-ddaea4894c41"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 11.52m, new DateTime(2022, 1, 12, 3, 13, 18, 289, DateTimeKind.Local).AddTicks(3877), "C9FLABDK", 6m },
                    { new Guid("7da1e9f3-8842-4feb-21a0-8cd88f0c8e07"), new Guid("9854b33f-3fcc-2677-666f-4b61f39523fe"), 4.89m, new DateTime(2021, 1, 14, 8, 22, 52, 821, DateTimeKind.Local).AddTicks(5513), "K08W33PX", 6m },
                    { new Guid("7e7205f7-69e8-a53e-29d0-ed1b6434e55a"), new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), 3.12m, new DateTime(2021, 6, 8, 6, 7, 36, 243, DateTimeKind.Local).AddTicks(8612), "FZYBKGFG", 7m },
                    { new Guid("7e7424b1-3e1c-25d5-f3e3-e9d348b64c3e"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 14.15m, new DateTime(2020, 1, 3, 16, 19, 53, 632, DateTimeKind.Local).AddTicks(1421), "BTXEWF3V", 7m },
                    { new Guid("7eab0e5f-76fb-a172-97cd-31803c89920a"), new Guid("a41af8f4-bbd6-73b1-4bd4-804185e52a21"), 9.20m, new DateTime(2021, 8, 13, 15, 26, 56, 917, DateTimeKind.Local).AddTicks(2408), "YAL2PLP6", 7m },
                    { new Guid("7eeb01fa-6b5f-f0b9-7218-41b41591eed7"), new Guid("a41af8f4-bbd6-73b1-4bd4-804185e52a21"), 12.15m, new DateTime(2020, 9, 10, 16, 18, 51, 601, DateTimeKind.Local).AddTicks(5134), "TU45OB4N", 7m },
                    { new Guid("804557b6-016c-acca-ebf0-9eee4c115737"), new Guid("d5c1bc86-519a-9714-6d84-1fc51d64763b"), 9.85m, new DateTime(2020, 10, 7, 12, 25, 18, 567, DateTimeKind.Local).AddTicks(7868), "WR9P4SBV", 6m },
                    { new Guid("80840434-080e-90ac-eee4-4f9a1fb2ebc1"), new Guid("0956f0cb-5ce8-b9ee-4dd5-f89c30daefa3"), 12.70m, new DateTime(2020, 2, 15, 17, 4, 36, 259, DateTimeKind.Local).AddTicks(5998), "9Q0DVEYT", 3m },
                    { new Guid("80a9845f-4369-0661-47a0-f48c773c45a5"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 8.52m, new DateTime(2022, 3, 21, 9, 1, 51, 941, DateTimeKind.Local).AddTicks(655), "I4I5EA5I", 5m },
                    { new Guid("80e9d98f-1867-f82e-e13e-7b5edc9271e7"), new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), 11.29m, new DateTime(2019, 12, 27, 20, 36, 31, 933, DateTimeKind.Local).AddTicks(5771), "L30J9DA0", 4m },
                    { new Guid("81ee301e-2160-bc7c-5802-b18a8320871f"), new Guid("a41af8f4-bbd6-73b1-4bd4-804185e52a21"), 2.03m, new DateTime(2021, 6, 12, 13, 33, 26, 315, DateTimeKind.Local).AddTicks(4527), "RZEMJQCK", 5m },
                    { new Guid("822cf9f1-a21f-2706-7308-2230dbf804c0"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 7.70m, new DateTime(2021, 12, 5, 6, 52, 32, 474, DateTimeKind.Local).AddTicks(5093), "YHMDPMZG", 6m },
                    { new Guid("82da8caa-0702-13c1-7822-ea93c8b181f1"), new Guid("26704dab-1edf-f36c-5319-da509200664a"), 6.73m, new DateTime(2020, 5, 17, 12, 42, 22, 187, DateTimeKind.Local).AddTicks(9905), "OHOW8FJU", 7m },
                    { new Guid("82fa4081-4f01-b59d-f46c-b427a6862c0d"), new Guid("a6d590a8-097c-c634-9485-949a6f568c31"), 2.45m, new DateTime(2022, 7, 7, 0, 45, 52, 548, DateTimeKind.Local).AddTicks(6511), "EQDOZAX3", 3m },
                    { new Guid("843d6100-6a00-f7fa-60bb-fe12a52abf90"), new Guid("6986a5ce-6a96-6ca5-d425-7b6d6b6db77f"), 2.74m, new DateTime(2021, 12, 6, 15, 16, 47, 440, DateTimeKind.Local).AddTicks(2532), "4GFX1DKO", 6m },
                    { new Guid("85392739-2961-4993-ebb6-04548c9be60a"), new Guid("a2a9059a-6a66-01df-ad40-5f14ae720c27"), 7.34m, new DateTime(2021, 9, 3, 14, 32, 26, 24, DateTimeKind.Local).AddTicks(7864), "D5CG8B9B", 3m },
                    { new Guid("8607f7e1-2ef5-9701-8cc7-fbed7d61b27b"), new Guid("2b1fe78f-efbd-06b9-e126-3f3c8011c60b"), 3.44m, new DateTime(2022, 1, 21, 9, 11, 46, 159, DateTimeKind.Local).AddTicks(3594), "A7X2RRQJ", 6m },
                    { new Guid("860c830f-0dc7-5a7b-1fdd-b792a2ed1759"), new Guid("a41af8f4-bbd6-73b1-4bd4-804185e52a21"), 14.19m, new DateTime(2022, 1, 11, 4, 17, 58, 878, DateTimeKind.Local).AddTicks(2532), "PDZWGJL1", 2m },
                    { new Guid("86eaef01-3358-4436-1350-cccce104a36f"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 6.44m, new DateTime(2020, 7, 20, 20, 18, 58, 606, DateTimeKind.Local).AddTicks(8804), "K73CUIDK", 1m },
                    { new Guid("873f1b69-30ff-6735-04f4-5ea596f32e64"), new Guid("9a3be4e8-e1b2-0e1d-7387-de3f5a266b16"), 7.56m, new DateTime(2019, 10, 10, 17, 19, 45, 306, DateTimeKind.Local).AddTicks(8624), "MCEIHSLW", 7m },
                    { new Guid("88ee273f-bcc4-ac0b-3eda-50924ff1ac18"), new Guid("734a75c1-16da-7247-5c5c-4c72f86ac6fc"), 1.89m, new DateTime(2020, 12, 31, 11, 29, 41, 465, DateTimeKind.Local).AddTicks(7572), "EO0XJDB9", 1m },
                    { new Guid("8c73ad6f-e4e3-4fbb-3b0d-c4f731e0724a"), new Guid("54c23339-3659-4d0b-5bba-206f6d1ee736"), 11.07m, new DateTime(2022, 6, 24, 0, 41, 11, 494, DateTimeKind.Local).AddTicks(5138), "6HMEN6RA", 6m },
                    { new Guid("8cb717d9-b3b0-98d3-df22-153ae190c19f"), new Guid("c421493e-f49e-d350-2c25-c2046f9a46aa"), 7.52m, new DateTime(2022, 7, 11, 18, 10, 8, 836, DateTimeKind.Local).AddTicks(9438), "F3EIIYUK", 5m },
                    { new Guid("8cc9e614-02d8-b172-1e93-f0125d8da48c"), new Guid("e8a0ec4e-b058-b3de-38e1-6168297d8e51"), 9.08m, new DateTime(2020, 7, 6, 0, 12, 57, 414, DateTimeKind.Local).AddTicks(9864), "QTTKV4JF", 6m },
                    { new Guid("8d3d6bc0-6062-25b5-0053-3e2be5d09706"), new Guid("91a20c64-4651-d3c6-b899-e3c0de1049d9"), 1.62m, new DateTime(2020, 8, 10, 7, 5, 9, 179, DateTimeKind.Local).AddTicks(8819), "7T4WS3RU", 7m },
                    { new Guid("8eaf19de-eef3-5339-1300-ff695f698dbc"), new Guid("a19c44b0-226c-9f61-8573-4fa1ffc22678"), 2.17m, new DateTime(2020, 2, 22, 8, 8, 59, 360, DateTimeKind.Local).AddTicks(4221), "ZEJARYOL", 6m },
                    { new Guid("8efb6839-0d3d-7bc3-ad2f-f7f2fe767896"), new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), 13.53m, new DateTime(2020, 3, 26, 23, 0, 3, 610, DateTimeKind.Local).AddTicks(7726), "EC9UUP9J", 3m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("91520aea-4b21-262c-bfac-ecaa330ecda5"), new Guid("a19c44b0-226c-9f61-8573-4fa1ffc22678"), 9.71m, new DateTime(2021, 12, 17, 9, 2, 30, 156, DateTimeKind.Local).AddTicks(1047), "AYOTUOXF", 2m },
                    { new Guid("91ebccf5-03f2-b045-cd87-4cb1e43916c3"), new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), 9.15m, new DateTime(2022, 7, 23, 11, 49, 53, 350, DateTimeKind.Local).AddTicks(1809), "BJEIZ1MG", 4m },
                    { new Guid("9230705a-7fc6-9805-9acc-62c0093fc5d5"), new Guid("f8ff4a6d-1ba1-4306-16a1-2eb98af936c8"), 7.25m, new DateTime(2020, 2, 15, 0, 31, 55, 669, DateTimeKind.Local).AddTicks(8985), "PRPFVOFV", 6m },
                    { new Guid("92bde5f0-9158-bb6f-2d35-5fd1671533ac"), new Guid("2f95afa4-bd69-9815-9eaa-659b1c016222"), 2.17m, new DateTime(2020, 8, 3, 16, 47, 33, 265, DateTimeKind.Local).AddTicks(3097), "62A66TND", 1m },
                    { new Guid("937a6636-a409-0ec2-3927-9bd0f8e14d6b"), new Guid("1fa2b8ee-36bc-8b4a-51c2-0d142b45e1d3"), 5.64m, new DateTime(2022, 4, 4, 23, 17, 22, 670, DateTimeKind.Local).AddTicks(8803), "EYCKBW1R", 2m },
                    { new Guid("95e2a428-1bd1-923d-fb75-252e46954bcb"), new Guid("2939488a-ae74-b966-6ef3-e6fe369bd266"), 6.95m, new DateTime(2021, 9, 24, 6, 5, 34, 608, DateTimeKind.Local).AddTicks(8691), "4Q0CGSJP", 2m },
                    { new Guid("96538143-83ca-6cf0-4fa1-32de8618508a"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 12.44m, new DateTime(2022, 3, 1, 8, 51, 35, 346, DateTimeKind.Local).AddTicks(3590), "A2JI256W", 6m },
                    { new Guid("987411a1-b19e-cf40-2e4f-314da892092f"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 8.30m, new DateTime(2020, 9, 17, 3, 52, 40, 714, DateTimeKind.Local).AddTicks(2838), "DAY8N3IU", 4m },
                    { new Guid("98bae347-aa29-769e-ed18-73eaf49c1d2d"), new Guid("91a20c64-4651-d3c6-b899-e3c0de1049d9"), 7.96m, new DateTime(2022, 4, 2, 22, 2, 15, 338, DateTimeKind.Local).AddTicks(6047), "20YR1FZA", 6m },
                    { new Guid("9bff59a2-d884-d4c7-6474-bf74d9481737"), new Guid("a6d590a8-097c-c634-9485-949a6f568c31"), 10.22m, new DateTime(2019, 12, 8, 20, 49, 46, 110, DateTimeKind.Local).AddTicks(5282), "9IVKQEVX", 3m },
                    { new Guid("9ddc6a81-cbc4-7b2e-f4e6-fa06e493bee4"), new Guid("0901014f-e3f9-d7d5-1747-25494defb678"), 11.46m, new DateTime(2022, 6, 28, 21, 13, 40, 128, DateTimeKind.Local).AddTicks(9131), "6SOVF2IN", 1m },
                    { new Guid("9de433e7-d9b7-5514-82b7-40e6ff9799d8"), new Guid("36517d08-e560-3599-2714-a5fc615e4a39"), 11.17m, new DateTime(2020, 11, 1, 6, 16, 43, 732, DateTimeKind.Local).AddTicks(2453), "VLLS5FMX", 6m },
                    { new Guid("9df714fe-28e4-785b-0363-c846fcc32edc"), new Guid("d2326bfa-651a-e8e2-1bb1-0f791e4190a4"), 6.72m, new DateTime(2021, 9, 29, 19, 3, 2, 326, DateTimeKind.Local).AddTicks(6930), "KXZ9FXVN", 3m },
                    { new Guid("9e92620a-3e68-2864-bfdb-4529c8eb174c"), new Guid("2b1fe78f-efbd-06b9-e126-3f3c8011c60b"), 10.19m, new DateTime(2021, 5, 16, 7, 45, 4, 418, DateTimeKind.Local).AddTicks(3734), "BIARYATU", 3m },
                    { new Guid("9eca191a-b42f-6668-ddfc-11f0db64c2a4"), new Guid("a2a9059a-6a66-01df-ad40-5f14ae720c27"), 3.31m, new DateTime(2020, 1, 7, 22, 52, 56, 754, DateTimeKind.Local).AddTicks(2242), "C14KOAQ4", 7m },
                    { new Guid("9f6cb035-703e-24de-d9e2-c8a112121691"), new Guid("f8ff4a6d-1ba1-4306-16a1-2eb98af936c8"), 12.83m, new DateTime(2021, 8, 22, 0, 56, 53, 21, DateTimeKind.Local).AddTicks(5529), "OOEZM6TC", 5m },
                    { new Guid("a09f2ac4-460b-9eac-d60e-4778f9db0dc8"), new Guid("c421493e-f49e-d350-2c25-c2046f9a46aa"), 7.11m, new DateTime(2021, 10, 5, 15, 45, 42, 733, DateTimeKind.Local).AddTicks(3710), "A8DOGGGF", 5m },
                    { new Guid("a22e0c3a-6c1f-b341-4120-3895490a5b54"), new Guid("d11984aa-7de6-a910-e7bf-748495ac245c"), 4.03m, new DateTime(2022, 7, 1, 11, 22, 56, 64, DateTimeKind.Local).AddTicks(7433), "5QMCABXK", 2m },
                    { new Guid("a2c67956-e756-9efb-7e90-3c26592bce00"), new Guid("734a75c1-16da-7247-5c5c-4c72f86ac6fc"), 2.39m, new DateTime(2020, 12, 14, 16, 11, 25, 341, DateTimeKind.Local).AddTicks(2470), "QOJC4WA9", 3m },
                    { new Guid("a358561c-be40-6315-801c-c90d5678004e"), new Guid("891dd4d6-4fd0-b1a3-f9d5-4691c506ab2b"), 2.27m, new DateTime(2020, 11, 28, 1, 2, 4, 831, DateTimeKind.Local).AddTicks(2781), "IF3P0PP3", 8m },
                    { new Guid("a367edb6-db77-cce0-d922-2357731e9e0f"), new Guid("9396046a-0e90-135a-e183-125b90ae0536"), 3.48m, new DateTime(2022, 7, 9, 3, 31, 28, 792, DateTimeKind.Local).AddTicks(9294), "V358YR32", 2m },
                    { new Guid("a38a2d0c-116d-6cab-25a6-11c7eb87e0b6"), new Guid("d2326bfa-651a-e8e2-1bb1-0f791e4190a4"), 10.58m, new DateTime(2021, 12, 30, 18, 49, 5, 150, DateTimeKind.Local).AddTicks(9224), "CQN7UX1K", 1m },
                    { new Guid("a4192916-4233-e7d7-766e-3605f7c81d38"), new Guid("6ad37215-8fbb-04bb-2e76-5f3faddbc6b8"), 5.88m, new DateTime(2022, 3, 4, 10, 32, 45, 564, DateTimeKind.Local).AddTicks(2959), "H31QFHQO", 1m },
                    { new Guid("a451859a-321a-44ac-3464-7713e3d20c89"), new Guid("6e7a21e1-fc0a-88d4-d552-6fd9b35c5714"), 1.10m, new DateTime(2022, 3, 23, 12, 38, 45, 297, DateTimeKind.Local).AddTicks(998), "9L9Z1EKE", 4m },
                    { new Guid("a4b16219-8563-dd85-b3b6-d9f4ff29b279"), new Guid("0eadcd5d-6da4-f8de-4ea2-c16e8f306978"), 3.44m, new DateTime(2020, 2, 10, 12, 35, 17, 57, DateTimeKind.Local).AddTicks(9786), "496S4PUG", 8m },
                    { new Guid("a58eb57d-9839-aa69-e4e9-8f2f0eefb0f5"), new Guid("5b17c841-1cbc-cf13-2d83-103fe90b6364"), 2.58m, new DateTime(2019, 10, 12, 1, 9, 4, 836, DateTimeKind.Local).AddTicks(8576), "O5MLSNUT", 6m },
                    { new Guid("a59a2176-a430-d05b-e317-4e93596a5527"), new Guid("d7d4e93a-b72b-f6f6-b28f-c11db84ff604"), 12.59m, new DateTime(2021, 11, 7, 2, 22, 41, 788, DateTimeKind.Local).AddTicks(5204), "3E2U6CUS", 7m },
                    { new Guid("a9258da5-72e6-b022-efdf-5c866698885e"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 13.57m, new DateTime(2020, 4, 7, 11, 51, 32, 874, DateTimeKind.Local).AddTicks(9471), "B1T6A26O", 3m },
                    { new Guid("aaaec7b7-77f6-1583-3292-097d5e8ffc0d"), new Guid("0b2fd3fc-f2e3-ca24-c396-5149135f89a7"), 3.54m, new DateTime(2020, 9, 18, 22, 44, 16, 975, DateTimeKind.Local).AddTicks(1886), "2Z8RBYQ2", 2m },
                    { new Guid("aabaf83b-7175-e392-975c-6f00977eff64"), new Guid("2939488a-ae74-b966-6ef3-e6fe369bd266"), 1.28m, new DateTime(2020, 10, 3, 1, 30, 27, 4, DateTimeKind.Local).AddTicks(6472), "ZP6FJNBW", 7m },
                    { new Guid("aac4e6fa-9a84-9b6f-c60c-01082792f495"), new Guid("9396046a-0e90-135a-e183-125b90ae0536"), 8.54m, new DateTime(2021, 6, 16, 0, 3, 46, 429, DateTimeKind.Local).AddTicks(5008), "99G59LKQ", 7m },
                    { new Guid("ab7e51f5-34ce-3652-7db0-710360e01e9f"), new Guid("15c27c1e-70fe-8dcd-5735-eef3addf447e"), 13.91m, new DateTime(2021, 4, 17, 3, 9, 44, 719, DateTimeKind.Local).AddTicks(4899), "8FQH90ON", 3m },
                    { new Guid("b0003fdd-4510-43ac-9cda-1a9617ba55b6"), new Guid("9396046a-0e90-135a-e183-125b90ae0536"), 12.48m, new DateTime(2019, 9, 4, 6, 2, 22, 179, DateTimeKind.Local).AddTicks(5873), "IWE7TE0E", 6m },
                    { new Guid("b0b2dd49-b33b-d89b-2b03-3e317724e581"), new Guid("6ad37215-8fbb-04bb-2e76-5f3faddbc6b8"), 2.58m, new DateTime(2022, 3, 26, 7, 27, 10, 385, DateTimeKind.Local).AddTicks(25), "IDP8D4PG", 4m },
                    { new Guid("b1b7684f-9642-31eb-39f5-93036878bb71"), new Guid("7e53c27e-6f9f-2ed8-6e7e-8b029d209f6d"), 12.00m, new DateTime(2021, 2, 26, 15, 13, 36, 686, DateTimeKind.Local).AddTicks(2754), "VXZ8SIZN", 4m },
                    { new Guid("b2196ee5-57c0-522b-5bb3-8229246c7abc"), new Guid("d11984aa-7de6-a910-e7bf-748495ac245c"), 2.74m, new DateTime(2020, 6, 22, 3, 2, 38, 50, DateTimeKind.Local).AddTicks(5875), "AJIU95RA", 1m },
                    { new Guid("b2995629-fc61-1b01-99fa-fe139dcac6a3"), new Guid("a6d590a8-097c-c634-9485-949a6f568c31"), 13.39m, new DateTime(2022, 1, 31, 4, 50, 42, 293, DateTimeKind.Local).AddTicks(3868), "9YTGR2W3", 5m },
                    { new Guid("b3c15ea9-5e2a-a71e-f1f3-6c9ec7aa76f1"), new Guid("6ad37215-8fbb-04bb-2e76-5f3faddbc6b8"), 4.60m, new DateTime(2021, 2, 7, 10, 43, 30, 189, DateTimeKind.Local).AddTicks(4316), "4KE89FV7", 3m },
                    { new Guid("b41c0cba-abf4-81aa-0a27-9fc517a7a217"), new Guid("e8a0ec4e-b058-b3de-38e1-6168297d8e51"), 14.80m, new DateTime(2022, 3, 5, 18, 41, 17, 251, DateTimeKind.Local).AddTicks(2532), "YNSXC6XH", 6m },
                    { new Guid("b4726b34-3ae7-f225-544b-bd1de83e74bb"), new Guid("f8ff4a6d-1ba1-4306-16a1-2eb98af936c8"), 8.68m, new DateTime(2021, 11, 20, 12, 40, 9, 916, DateTimeKind.Local).AddTicks(1751), "SOR88M81", 8m },
                    { new Guid("b6232985-9b12-2532-6811-3236320aaaf9"), new Guid("0eadcd5d-6da4-f8de-4ea2-c16e8f306978"), 9.59m, new DateTime(2021, 3, 31, 13, 2, 55, 804, DateTimeKind.Local).AddTicks(1603), "NDAPWWHP", 1m },
                    { new Guid("b8cf5fe9-bda3-ff3a-04e0-6219909e6cf1"), new Guid("bf8b4143-4229-56a6-c4ba-8ab9fddc618e"), 7.84m, new DateTime(2019, 9, 21, 7, 19, 40, 318, DateTimeKind.Local).AddTicks(894), "8FPBKGHE", 5m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("bb600ee0-68c6-baa3-7b4d-770dbc6913c7"), new Guid("91a20c64-4651-d3c6-b899-e3c0de1049d9"), 3.15m, new DateTime(2022, 6, 7, 15, 29, 47, 975, DateTimeKind.Local).AddTicks(5559), "F9P8A9OX", 1m },
                    { new Guid("bb89e49e-9d96-e0af-3921-5374a7af50b1"), new Guid("e8a0ec4e-b058-b3de-38e1-6168297d8e51"), 11.35m, new DateTime(2020, 12, 30, 18, 52, 44, 487, DateTimeKind.Local).AddTicks(8209), "6I9JJGVH", 5m },
                    { new Guid("bc7d2525-26f7-007d-4208-7b36bdd80901"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 3.76m, new DateTime(2020, 11, 18, 23, 0, 20, 468, DateTimeKind.Local).AddTicks(632), "EI3IW8P5", 5m },
                    { new Guid("bd2f31e9-2d52-3afb-8071-ec936ec79958"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 4.17m, new DateTime(2020, 12, 5, 0, 54, 22, 987, DateTimeKind.Local).AddTicks(755), "PUYXFB1F", 6m },
                    { new Guid("bd8b989e-7cf2-6fb5-c4e4-c1c896fea7b6"), new Guid("0901014f-e3f9-d7d5-1747-25494defb678"), 13.56m, new DateTime(2020, 3, 23, 20, 23, 49, 622, DateTimeKind.Local).AddTicks(3770), "8TTFB6F5", 2m },
                    { new Guid("bdf6ee13-95a0-e7e4-8ce9-0bd2631ce37e"), new Guid("a2a9059a-6a66-01df-ad40-5f14ae720c27"), 6.90m, new DateTime(2020, 6, 21, 13, 51, 7, 751, DateTimeKind.Local).AddTicks(4121), "CXB9IRES", 2m },
                    { new Guid("bdf9b576-2e9c-9b8a-92e5-e96c38cb6acb"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 4.76m, new DateTime(2022, 2, 14, 16, 46, 30, 224, DateTimeKind.Local).AddTicks(5705), "IDVCZGZL", 6m },
                    { new Guid("c06d549c-ba80-31be-8697-caecd6e564e5"), new Guid("6986a5ce-6a96-6ca5-d425-7b6d6b6db77f"), 5.59m, new DateTime(2020, 11, 2, 21, 35, 58, 933, DateTimeKind.Local).AddTicks(285), "ZAX6ISS6", 2m },
                    { new Guid("c189c43e-e088-1dcd-294e-93d046f3f8c3"), new Guid("15c27c1e-70fe-8dcd-5735-eef3addf447e"), 10.23m, new DateTime(2019, 9, 14, 7, 32, 53, 368, DateTimeKind.Local).AddTicks(3331), "IQD8SQGU", 6m },
                    { new Guid("c19a02d2-4fbb-b9d5-9c66-2e7dc21787a8"), new Guid("a41af8f4-bbd6-73b1-4bd4-804185e52a21"), 13.27m, new DateTime(2019, 9, 3, 14, 25, 53, 259, DateTimeKind.Local).AddTicks(402), "14FWUF4K", 3m },
                    { new Guid("c1a033cb-566b-363a-b451-03d723ab333d"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 11.90m, new DateTime(2021, 5, 8, 5, 28, 22, 930, DateTimeKind.Local).AddTicks(9591), "G553WBCP", 2m },
                    { new Guid("c2b62dc0-3123-c9e8-b963-bfabd2531be5"), new Guid("734a75c1-16da-7247-5c5c-4c72f86ac6fc"), 11.14m, new DateTime(2022, 5, 24, 5, 20, 53, 156, DateTimeKind.Local).AddTicks(7312), "T1I96E6I", 6m },
                    { new Guid("c2d6e800-e256-466a-0fea-a7e6224f44f4"), new Guid("d418387b-096d-0f2a-2873-dc7d2fa1cb76"), 3.94m, new DateTime(2020, 4, 6, 8, 29, 41, 72, DateTimeKind.Local).AddTicks(9572), "CYBYD436", 4m },
                    { new Guid("c30d0fea-1764-f6a7-bbbc-19055594f72d"), new Guid("2f95afa4-bd69-9815-9eaa-659b1c016222"), 5.73m, new DateTime(2022, 1, 4, 3, 58, 52, 537, DateTimeKind.Local).AddTicks(2773), "XVSAZEM4", 3m },
                    { new Guid("c32865b1-2d72-15dd-425f-0aaac2e79924"), new Guid("94150ed1-6351-a9f7-c213-68ba7ce9cde9"), 1.31m, new DateTime(2022, 4, 9, 22, 20, 47, 57, DateTimeKind.Local).AddTicks(1871), "JD7FHUMC", 8m },
                    { new Guid("c33b85cb-20f7-c3f2-6ea6-f6d217fdfc62"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 11.93m, new DateTime(2020, 6, 17, 17, 8, 37, 307, DateTimeKind.Local).AddTicks(5372), "XBVDBIQD", 6m },
                    { new Guid("c3fc3e1b-857e-5074-a911-b2bb64cc94cf"), new Guid("a96c98df-93fe-b3fa-46b2-b9b104498b1a"), 12.85m, new DateTime(2021, 9, 18, 7, 28, 58, 838, DateTimeKind.Local).AddTicks(284), "QD2N5B4E", 4m },
                    { new Guid("c5140f09-edb0-3432-29aa-fce3ca87dbca"), new Guid("d11984aa-7de6-a910-e7bf-748495ac245c"), 2.40m, new DateTime(2022, 8, 16, 19, 5, 1, 282, DateTimeKind.Local).AddTicks(2258), "ZH8QPWV9", 4m },
                    { new Guid("c7178071-1076-a520-e638-129bc2258fc1"), new Guid("d11984aa-7de6-a910-e7bf-748495ac245c"), 3.58m, new DateTime(2022, 2, 24, 6, 58, 15, 210, DateTimeKind.Local).AddTicks(1024), "3S4UVEJ4", 5m },
                    { new Guid("c79586bf-c8b4-edb9-1f28-8904c5dc34bf"), new Guid("15c27c1e-70fe-8dcd-5735-eef3addf447e"), 7.30m, new DateTime(2020, 2, 8, 3, 12, 22, 435, DateTimeKind.Local).AddTicks(6744), "93N5RPHB", 7m },
                    { new Guid("c7a69e5b-981f-50a7-105d-25e3f6a5c642"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 3.56m, new DateTime(2021, 9, 27, 16, 24, 0, 103, DateTimeKind.Local).AddTicks(6781), "021J92TO", 8m },
                    { new Guid("c7c29505-2928-f767-048e-94c0f7742246"), new Guid("0901014f-e3f9-d7d5-1747-25494defb678"), 7.00m, new DateTime(2020, 12, 9, 21, 28, 5, 371, DateTimeKind.Local).AddTicks(7197), "97U8NEAF", 1m },
                    { new Guid("ca25a11c-f885-7bad-7dd3-6727e393fb32"), new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), 12.77m, new DateTime(2020, 1, 14, 17, 11, 10, 21, DateTimeKind.Local).AddTicks(5932), "A5YRBLCH", 5m },
                    { new Guid("cb54336f-825a-c04a-7186-6bdc0f4aad51"), new Guid("c421493e-f49e-d350-2c25-c2046f9a46aa"), 4.73m, new DateTime(2021, 5, 8, 15, 22, 32, 879, DateTimeKind.Local).AddTicks(7697), "I5IDZMZH", 2m },
                    { new Guid("cb7893e3-2c58-0aa4-53e2-767ec570ad54"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 2.73m, new DateTime(2021, 3, 21, 4, 30, 18, 251, DateTimeKind.Local).AddTicks(5947), "ERNG6CCU", 4m },
                    { new Guid("cbae09ba-6477-1ff4-84c2-1bcf51f776ef"), new Guid("15c27c1e-70fe-8dcd-5735-eef3addf447e"), 11.87m, new DateTime(2021, 4, 19, 14, 39, 2, 138, DateTimeKind.Local).AddTicks(2869), "6RE9SS8P", 4m },
                    { new Guid("cc67dd98-d577-18bf-c343-87a37d990112"), new Guid("7e53c27e-6f9f-2ed8-6e7e-8b029d209f6d"), 11.08m, new DateTime(2021, 8, 7, 5, 11, 26, 501, DateTimeKind.Local).AddTicks(6568), "2QOLJUMT", 3m },
                    { new Guid("cc8e3682-3725-6972-4334-4160d3ef9d36"), new Guid("36517d08-e560-3599-2714-a5fc615e4a39"), 2.28m, new DateTime(2022, 3, 10, 6, 22, 3, 370, DateTimeKind.Local).AddTicks(1333), "W3RAAKBB", 6m },
                    { new Guid("cd016de5-6910-bb5c-54a7-fae0bc4b8e61"), new Guid("7e53c27e-6f9f-2ed8-6e7e-8b029d209f6d"), 5.79m, new DateTime(2020, 1, 8, 5, 41, 31, 753, DateTimeKind.Local).AddTicks(6982), "0UAKALHM", 7m },
                    { new Guid("cd48f92f-2447-6780-f717-c98d4a0f7652"), new Guid("e8a0ec4e-b058-b3de-38e1-6168297d8e51"), 10.51m, new DateTime(2020, 2, 14, 13, 26, 17, 456, DateTimeKind.Local).AddTicks(8905), "98W0NM9P", 7m },
                    { new Guid("cdd84651-dda2-11f2-ac79-5b752477ca1a"), new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), 4.53m, new DateTime(2020, 5, 21, 3, 19, 47, 578, DateTimeKind.Local).AddTicks(8858), "AUY4Y71F", 4m },
                    { new Guid("ce177102-8180-0035-b366-26264c146151"), new Guid("da548aeb-7e89-dd5b-c1eb-a35703e0c154"), 9.85m, new DateTime(2020, 5, 4, 3, 1, 14, 701, DateTimeKind.Local).AddTicks(2557), "6LGPP41B", 1m },
                    { new Guid("ce78daef-ce83-97e1-9632-89519a0b5720"), new Guid("91a2515b-1696-9cb2-8d9e-3d1597950190"), 9.12m, new DateTime(2021, 10, 27, 0, 27, 59, 606, DateTimeKind.Local).AddTicks(6890), "1D4U22X0", 2m },
                    { new Guid("d1f14e74-a0cd-2409-0375-811993948b26"), new Guid("e8a0ec4e-b058-b3de-38e1-6168297d8e51"), 10.80m, new DateTime(2022, 6, 20, 6, 17, 56, 554, DateTimeKind.Local).AddTicks(9949), "G1LBL1NS", 3m },
                    { new Guid("d24851f5-f41d-0fc2-dca2-6e8edce62f8a"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 12.69m, new DateTime(2021, 10, 2, 20, 36, 27, 543, DateTimeKind.Local).AddTicks(9092), "9HE1UQBK", 3m },
                    { new Guid("d2e35863-87b4-1949-9f19-37d040cc9454"), new Guid("0eadcd5d-6da4-f8de-4ea2-c16e8f306978"), 10.64m, new DateTime(2022, 2, 26, 9, 56, 19, 28, DateTimeKind.Local).AddTicks(4724), "8MD4GOOQ", 6m },
                    { new Guid("d4176d29-d4a8-3d96-b0df-734572714aaf"), new Guid("9396046a-0e90-135a-e183-125b90ae0536"), 9.79m, new DateTime(2020, 10, 9, 4, 22, 9, 706, DateTimeKind.Local).AddTicks(5402), "WWCTWU34", 7m },
                    { new Guid("d4dd67dd-9cb2-ed25-0b6e-9ea6fd7ffa16"), new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), 12.61m, new DateTime(2021, 6, 25, 19, 43, 24, 463, DateTimeKind.Local).AddTicks(4580), "QRQOUT4R", 1m },
                    { new Guid("d4f73f25-02d0-a0b8-cc2c-de9ef7aefa81"), new Guid("6986a5ce-6a96-6ca5-d425-7b6d6b6db77f"), 12.29m, new DateTime(2020, 10, 1, 5, 12, 31, 852, DateTimeKind.Local).AddTicks(6206), "Z4BITAIZ", 2m },
                    { new Guid("d68ef772-4e19-5dbe-930d-8557888838b2"), new Guid("d11984aa-7de6-a910-e7bf-748495ac245c"), 10.38m, new DateTime(2021, 11, 22, 13, 41, 45, 612, DateTimeKind.Local).AddTicks(4648), "Q1ANKFY8", 6m },
                    { new Guid("d784d757-3265-587f-931f-031cda0e4c65"), new Guid("96af2292-2b68-b3ae-f9a9-64c81a69ea71"), 6.50m, new DateTime(2020, 11, 7, 9, 27, 3, 73, DateTimeKind.Local).AddTicks(5505), "1LTX8NDT", 5m },
                    { new Guid("d7d99b54-6d8b-d2ce-4efb-756c99c8fe45"), new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), 3.13m, new DateTime(2021, 1, 16, 23, 13, 7, 58, DateTimeKind.Local).AddTicks(1952), "I4K9TR3Y", 6m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("d834800c-d56c-115f-4255-733307a2cbe1"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 10.05m, new DateTime(2021, 11, 15, 5, 12, 15, 301, DateTimeKind.Local).AddTicks(7389), "LZV8UNTA", 3m },
                    { new Guid("d967fbb2-58fe-e537-e833-ea4dcf1118a3"), new Guid("2939488a-ae74-b966-6ef3-e6fe369bd266"), 8.11m, new DateTime(2021, 4, 29, 18, 7, 37, 338, DateTimeKind.Local).AddTicks(1028), "DV8T17L8", 5m },
                    { new Guid("da26c428-a7f0-f17a-266c-e538acf5b342"), new Guid("0eadcd5d-6da4-f8de-4ea2-c16e8f306978"), 6.61m, new DateTime(2021, 9, 10, 23, 14, 8, 546, DateTimeKind.Local).AddTicks(6241), "3OZX9LPM", 7m },
                    { new Guid("da2c5a47-c790-51a4-4409-235df23f5897"), new Guid("a96c98df-93fe-b3fa-46b2-b9b104498b1a"), 7.44m, new DateTime(2022, 8, 20, 5, 50, 48, 382, DateTimeKind.Local).AddTicks(3393), "AENMFRGO", 2m },
                    { new Guid("dc4707ef-04e2-45b5-95d5-03d3ecdc0541"), new Guid("99a092be-5230-b97c-a7af-aeb73220150d"), 1.81m, new DateTime(2020, 12, 26, 16, 43, 9, 571, DateTimeKind.Local).AddTicks(2094), "BIDL8TJL", 2m },
                    { new Guid("dc591a7c-b96a-4fb9-34d5-c62dde5fcf48"), new Guid("a19c44b0-226c-9f61-8573-4fa1ffc22678"), 11.53m, new DateTime(2020, 9, 1, 19, 35, 3, 593, DateTimeKind.Local).AddTicks(5899), "GRS6Q045", 2m },
                    { new Guid("dd3de8c8-819c-583e-bf0e-402cff3c9d5d"), new Guid("bf8b4143-4229-56a6-c4ba-8ab9fddc618e"), 7.47m, new DateTime(2021, 7, 4, 7, 23, 38, 797, DateTimeKind.Local).AddTicks(62), "7KC6RGY7", 8m },
                    { new Guid("dd7e5707-f562-aef1-e8d5-4445668fce74"), new Guid("6ad37215-8fbb-04bb-2e76-5f3faddbc6b8"), 3.36m, new DateTime(2020, 6, 16, 10, 12, 1, 717, DateTimeKind.Local).AddTicks(2095), "A4UTH51D", 7m },
                    { new Guid("de1d714f-16fa-81c4-85ee-f683e105480d"), new Guid("15c27c1e-70fe-8dcd-5735-eef3addf447e"), 5.46m, new DateTime(2022, 2, 2, 11, 20, 55, 789, DateTimeKind.Local).AddTicks(2405), "2T5V9V3T", 7m },
                    { new Guid("de32c901-5587-f624-af5a-286f8904404b"), new Guid("d418387b-096d-0f2a-2873-dc7d2fa1cb76"), 14.03m, new DateTime(2021, 9, 9, 4, 52, 58, 462, DateTimeKind.Local).AddTicks(1791), "H4X7ZOL2", 2m },
                    { new Guid("ded43e8d-9ff9-acd6-9f15-28b39af76948"), new Guid("36517d08-e560-3599-2714-a5fc615e4a39"), 5.07m, new DateTime(2020, 7, 30, 16, 17, 4, 268, DateTimeKind.Local).AddTicks(3984), "KRTC2H6L", 5m },
                    { new Guid("df866c28-8f5e-e6cf-68f0-c6d2d0a6c9f7"), new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), 8.73m, new DateTime(2022, 5, 5, 18, 37, 16, 797, DateTimeKind.Local).AddTicks(8582), "WDKPEOWB", 2m },
                    { new Guid("e0b99729-5fef-d972-a9a4-4137fcefbaf6"), new Guid("91a2515b-1696-9cb2-8d9e-3d1597950190"), 10.69m, new DateTime(2021, 12, 26, 10, 57, 51, 281, DateTimeKind.Local).AddTicks(420), "E7T0CJW5", 5m },
                    { new Guid("e1bd727c-4281-9090-e9b2-b141438c4e05"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 4.22m, new DateTime(2020, 7, 16, 19, 14, 10, 132, DateTimeKind.Local).AddTicks(3842), "LWAN4U5Y", 6m },
                    { new Guid("e1e51c62-b227-9dc5-404e-0a5cdbca4d7f"), new Guid("d7d4e93a-b72b-f6f6-b28f-c11db84ff604"), 4.40m, new DateTime(2019, 8, 27, 3, 4, 46, 809, DateTimeKind.Local).AddTicks(8309), "6XNICZW5", 4m },
                    { new Guid("e3505afe-7f92-e221-f762-4395da7fe733"), new Guid("2b1fe78f-efbd-06b9-e126-3f3c8011c60b"), 2.56m, new DateTime(2020, 10, 13, 16, 42, 36, 93, DateTimeKind.Local).AddTicks(6892), "57J5Y7GR", 4m },
                    { new Guid("e464ecac-d982-b30d-9637-28f161550cef"), new Guid("7e53c27e-6f9f-2ed8-6e7e-8b029d209f6d"), 6.69m, new DateTime(2020, 6, 8, 6, 47, 29, 622, DateTimeKind.Local).AddTicks(563), "CZD7P8VC", 6m },
                    { new Guid("e5038962-4c3e-f216-fe01-cbe009177c91"), new Guid("a96c98df-93fe-b3fa-46b2-b9b104498b1a"), 13.61m, new DateTime(2021, 1, 19, 15, 42, 21, 720, DateTimeKind.Local).AddTicks(9928), "XXPP3L3C", 7m },
                    { new Guid("e58765bd-f048-22e7-5492-b1ea5b6bc5b7"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 3.33m, new DateTime(2020, 12, 20, 4, 48, 14, 431, DateTimeKind.Local).AddTicks(5549), "MC4PRYV4", 4m },
                    { new Guid("e58ac020-a256-645e-e479-b1b77505ec8f"), new Guid("71d76637-13c4-63f9-fd21-c9264e844d6d"), 12.00m, new DateTime(2022, 8, 2, 22, 46, 12, 823, DateTimeKind.Local).AddTicks(9120), "62G5GN3D", 5m },
                    { new Guid("e5a584d9-59c4-bdf0-9f0d-b3994aed3e81"), new Guid("9a3be4e8-e1b2-0e1d-7387-de3f5a266b16"), 14.33m, new DateTime(2022, 8, 15, 12, 53, 38, 447, DateTimeKind.Local).AddTicks(7200), "TVAQJPCV", 7m },
                    { new Guid("e7516716-4dfd-bb52-10b5-8e067bc43c06"), new Guid("734a75c1-16da-7247-5c5c-4c72f86ac6fc"), 9.38m, new DateTime(2020, 8, 12, 20, 13, 47, 328, DateTimeKind.Local).AddTicks(1260), "3PUCVKKO", 6m },
                    { new Guid("e86b72ad-a584-d318-2830-db121e52eadc"), new Guid("9a3be4e8-e1b2-0e1d-7387-de3f5a266b16"), 12.89m, new DateTime(2021, 8, 3, 10, 33, 40, 778, DateTimeKind.Local).AddTicks(3976), "ORRFHHLL", 2m },
                    { new Guid("ea25a0cd-c85f-cccd-4ba5-6cea135a0edc"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 3.18m, new DateTime(2019, 10, 27, 9, 26, 36, 223, DateTimeKind.Local).AddTicks(5374), "KPPMQQXI", 4m },
                    { new Guid("ea7888ee-1683-f9e6-8ce1-7d3e011a2fb6"), new Guid("6e7a21e1-fc0a-88d4-d552-6fd9b35c5714"), 7.96m, new DateTime(2022, 2, 13, 19, 16, 11, 341, DateTimeKind.Local).AddTicks(1745), "AP8YIHRM", 8m },
                    { new Guid("eaa5b3de-7f40-f339-a43a-8d4900ebd596"), new Guid("d9d20721-10ab-5f8e-69fd-76037439c7eb"), 10.24m, new DateTime(2020, 7, 21, 21, 45, 44, 524, DateTimeKind.Local).AddTicks(1682), "E9N8YAK1", 3m },
                    { new Guid("eab6a14a-da5a-7eae-7eff-fddb89da5f8c"), new Guid("6ad37215-8fbb-04bb-2e76-5f3faddbc6b8"), 4.38m, new DateTime(2021, 12, 31, 16, 41, 54, 647, DateTimeKind.Local).AddTicks(4281), "3HP3OH3J", 5m },
                    { new Guid("ec03df5c-ca9f-34ac-4ba7-a96fd069d203"), new Guid("96af2292-2b68-b3ae-f9a9-64c81a69ea71"), 7.62m, new DateTime(2021, 7, 30, 1, 21, 32, 575, DateTimeKind.Local).AddTicks(9736), "9SBSXNCX", 8m },
                    { new Guid("ed187ede-7389-bfa3-8795-c2539f81a73e"), new Guid("15c27c1e-70fe-8dcd-5735-eef3addf447e"), 12.88m, new DateTime(2022, 6, 29, 21, 42, 23, 279, DateTimeKind.Local).AddTicks(6806), "27KQSMKA", 2m },
                    { new Guid("ed2f8783-400c-c6fd-2a83-e62de059005d"), new Guid("126bd4dc-d93e-302a-be9a-69cc0551774f"), 3.89m, new DateTime(2020, 7, 31, 15, 36, 56, 263, DateTimeKind.Local).AddTicks(7153), "XF20SIBB", 8m },
                    { new Guid("ee46f386-8db4-9b3e-707f-35ec59323a5f"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 1.71m, new DateTime(2021, 8, 25, 18, 51, 1, 792, DateTimeKind.Local).AddTicks(9887), "V3BUZMS1", 1m },
                    { new Guid("eea60e42-daea-1691-9a1b-8accd67060e6"), new Guid("94150ed1-6351-a9f7-c213-68ba7ce9cde9"), 8.96m, new DateTime(2021, 12, 14, 5, 44, 16, 136, DateTimeKind.Local).AddTicks(6739), "11DXF5BO", 5m },
                    { new Guid("ef09ddfc-66c0-ada5-d2d7-e37560e06adc"), new Guid("94150ed1-6351-a9f7-c213-68ba7ce9cde9"), 10.26m, new DateTime(2021, 1, 20, 8, 21, 4, 582, DateTimeKind.Local).AddTicks(9647), "3CGK7Y5R", 1m },
                    { new Guid("ef70201e-e2fd-dd5d-38b6-c51846d72008"), new Guid("2b1fe78f-efbd-06b9-e126-3f3c8011c60b"), 4.36m, new DateTime(2019, 12, 14, 14, 36, 29, 114, DateTimeKind.Local).AddTicks(2876), "MHPW5UI7", 2m },
                    { new Guid("ef950f57-0a01-844e-1d5a-c1e8c7fcc033"), new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), 13.67m, new DateTime(2019, 10, 31, 14, 33, 14, 894, DateTimeKind.Local).AddTicks(7295), "3AP3YL0D", 6m },
                    { new Guid("f2b83d8a-bd53-ef34-37b9-7bb571c1a283"), new Guid("d7d4e93a-b72b-f6f6-b28f-c11db84ff604"), 8.03m, new DateTime(2020, 12, 8, 0, 28, 12, 306, DateTimeKind.Local).AddTicks(196), "6ROWURRB", 5m },
                    { new Guid("f3592185-77e9-d5a2-7c4d-568de72a5cea"), new Guid("0eadcd5d-6da4-f8de-4ea2-c16e8f306978"), 8.50m, new DateTime(2021, 2, 27, 8, 57, 8, 605, DateTimeKind.Local).AddTicks(3243), "TKH3JO8Y", 8m },
                    { new Guid("f3beb5fd-d539-0d62-d119-22fe472564b8"), new Guid("2f95afa4-bd69-9815-9eaa-659b1c016222"), 1.85m, new DateTime(2021, 9, 24, 9, 36, 50, 130, DateTimeKind.Local).AddTicks(4299), "JXA6IYJR", 6m },
                    { new Guid("f5db49cf-e401-ec74-73f2-8066dba264ab"), new Guid("8e8f7a87-eaa3-0af8-9864-e061eacdac6f"), 14.44m, new DateTime(2021, 9, 9, 3, 5, 5, 718, DateTimeKind.Local).AddTicks(99), "UDJKAFGC", 5m },
                    { new Guid("f74a7df7-9584-b36f-a834-a4b397cfd399"), new Guid("6ad37215-8fbb-04bb-2e76-5f3faddbc6b8"), 2.27m, new DateTime(2021, 10, 19, 17, 21, 1, 225, DateTimeKind.Local).AddTicks(4703), "BC4VOTMH", 2m },
                    { new Guid("f803ff70-23f6-6c7c-f06a-5d6a2d85e27e"), new Guid("da548aeb-7e89-dd5b-c1eb-a35703e0c154"), 6.72m, new DateTime(2021, 10, 5, 18, 45, 11, 280, DateTimeKind.Local).AddTicks(1859), "NIS0Z3I9", 3m },
                    { new Guid("f85ac6fb-b946-d1a4-8a0e-ce21c5499ce7"), new Guid("6986a5ce-6a96-6ca5-d425-7b6d6b6db77f"), 10.06m, new DateTime(2020, 7, 26, 5, 2, 38, 349, DateTimeKind.Local).AddTicks(8157), "URGJF4Q3", 5m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CustomerId", "GrossValue", "InvoiceDate", "InvoiceNumber", "NetValue" },
                values: new object[,]
                {
                    { new Guid("f8a463ae-7359-c1d2-f4de-6ed428159211"), new Guid("a2a9059a-6a66-01df-ad40-5f14ae720c27"), 10.20m, new DateTime(2020, 8, 9, 11, 24, 40, 203, DateTimeKind.Local).AddTicks(1064), "XDVQMI1Q", 8m },
                    { new Guid("fa55fc19-0740-91b9-e4b5-5b240ce37be1"), new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), 11.18m, new DateTime(2019, 11, 9, 7, 24, 56, 51, DateTimeKind.Local).AddTicks(1314), "9SXNREGU", 5m },
                    { new Guid("fbd8ee34-8998-89d6-d1df-c9541fe12c12"), new Guid("cf98d365-6753-2aec-f7f5-e258e49d94fa"), 12.66m, new DateTime(2020, 9, 29, 16, 15, 46, 969, DateTimeKind.Local).AddTicks(3936), "34NFFG9V", 4m },
                    { new Guid("fd5a2eef-dbeb-daeb-947d-9c7eb2302d51"), new Guid("d7d4e93a-b72b-f6f6-b28f-c11db84ff604"), 9.02m, new DateTime(2022, 5, 5, 23, 6, 0, 317, DateTimeKind.Local).AddTicks(212), "UIEUA01O", 3m },
                    { new Guid("fe40a3c0-f6bb-9e78-0ad1-a66593c473fa"), new Guid("65032340-13eb-624e-a876-5fd2018fa3e1"), 13.69m, new DateTime(2021, 6, 15, 21, 37, 43, 200, DateTimeKind.Local).AddTicks(1299), "UJMHDG3I", 3m },
                    { new Guid("ff0832b1-00b5-7863-6324-6cd33e1dcf4d"), new Guid("9854b33f-3fcc-2677-666f-4b61f39523fe"), 1.24m, new DateTime(2022, 4, 21, 7, 41, 23, 580, DateTimeKind.Local).AddTicks(1338), "ZHNZFHRH", 4m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
