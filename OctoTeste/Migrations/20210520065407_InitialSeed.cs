using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OctoTeste.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cep", "Cpf", "Endereco", "Nome", "Numero", "Telefone", "dataNascimento", "tipoEndereco", "tipoTelefone" },
                values: new object[,]
                {
                    { new Guid("60dab023-cd94-4f1c-9494-cbea49a9ac93"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("ebcf0934-e9d1-4245-849e-d03bae4d12ea"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("1b4d7197-7f18-4a2a-8cc8-319db764ca43"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("09ed0a5c-c864-407f-8a97-cf785c743c05"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("4889865e-8495-4744-b0a7-7089da4c7fcd"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("b1b4ac51-9242-4626-af79-8543995b8583"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("d1af9b41-edb2-4e36-86ad-e917a2df83ae"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("d5721dff-d2d7-4d63-becb-c7346a6985d8"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("0b070c10-85d8-42e3-ac20-73f31bdea9f1"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("be994dc0-f8f0-4d50-9e9d-f386d43bdf28"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("6ef79089-e4ba-49be-a21d-9ca857113aa9"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("b64565cc-622d-47bf-95c3-a943ab36b682"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("e7e3aa47-74d7-4647-9af4-703473978222"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("98cd273d-9ab2-4bbf-a181-1eb2f4f5c92c"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("05a2b9f9-548e-4568-b6f9-7213eca65f6d"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("dfa22849-aa89-4489-96cd-76e7847c71c3"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("3840e792-a06e-46a7-a508-9256770d96de"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("b3f56188-0e37-4320-8564-e7e32aa9e170"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("3157e2c5-a180-4d94-a8b3-6578930f0edb"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("70fc4c9a-0ef2-4330-90fa-514056be55d8"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("79ed0424-a9ce-4aee-9c5e-cbe396d2adee"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("3d9b2151-9213-489c-85be-62cac8186501"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("2a4f399f-5eef-4aee-8786-da83443be27c"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("d8727424-3ecc-4f2d-b4ba-9c41ffb44b17"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("c1de88f5-ebcc-4b6a-96cb-9c4227e48321"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("87f5d0a6-3c87-4790-b6a8-31da9e971741"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("7370b3f5-2122-410a-914a-7843f9cef7c2"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("979ff656-4597-4f65-95b0-019d2fcaeaa7"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("0b00db0b-0a99-4641-a309-79f7104c0b90"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("cc665f4e-876e-4942-9c15-876b372fc004"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("400da8db-e06a-46fe-844b-350854f154c4"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("f69077fd-76d8-4524-ad00-eeace6ef7cbf"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("b640cc5f-2073-49e2-a51d-ed8e577f7a81"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("643f9c93-fb87-49bb-9359-4cce2b6812e8"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("5fa7a9af-e98f-4f55-bf3c-b560cf099c0c"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("6719ae21-0d8b-4471-ab78-fb934739e9ec"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("8409b947-45f5-4b42-9d92-3fc8825252b6"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("8a5ad4aa-0557-4331-9dbe-9ed308d97ac4"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("d941d382-8079-477a-86c1-7a80afbf0ddd"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("a53d0bd6-cb0c-423a-bbee-afad6632d66d"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("b71ce95b-dcbf-46d2-9cde-7533a9a7bf8b"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("d89338d7-3cac-4a64-b6f6-a624185ed3c1"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Cep", "Cpf", "Endereco", "Nome", "Numero", "Telefone", "dataNascimento", "tipoEndereco", "tipoTelefone" },
                values: new object[,]
                {
                    { new Guid("43ce4ba1-8968-44a6-bfe8-8a88d19ebd15"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("226394b5-d71b-4585-85b0-626fb9e98c28"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("04cb7e46-3b58-43f6-9891-69becb9de08c"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("0618ca70-e1bd-4a48-9674-c0073041d482"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("65ea3300-f6cd-4aa5-b6ba-3cd9406fd544"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("65af0f71-f833-42ad-9b51-ffdffe8802cc"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("c080b7ef-d06d-4919-837c-5ea09c5dd6f9"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("648d3e4e-3743-432b-8df2-d73f2f0010c1"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("e51d378d-38be-4e80-bf18-248073dd057e"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("5b4b7fa2-7ecf-4329-a4a0-9c9ed616adba"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("869d0a3f-37dd-4a2e-907c-f149633eece8"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("b6086964-cf0d-4700-ba64-787bfffdfa30"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("105a9986-8a02-46d2-bc30-1157f746df6d"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("e2a068b4-d737-49f0-ad50-9d5d80876949"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("b50a9717-4467-4834-849a-069fca17227a"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("6627f7ba-7272-4fdd-9151-e3498fefbe08"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("13d786b3-2b7c-4bb3-a2c1-a96950e7f438"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("5f7c252f-361d-4323-a16d-d834392a8336"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("fdbd8d55-0937-437c-8929-e2c22de425c9"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("915949af-cb91-49f9-affb-c7381c8a9b67"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("e5244be0-2d32-4c86-8a5d-4eb7d5d5303c"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("69b0bf9f-1142-43e3-9e22-79b1b3a80be8"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("059bd883-60c7-4030-b027-eba4b4ba4f66"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("a05b6f83-d756-49ae-83e1-0bbc9acb38e3"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("f5fad52a-8654-4fd3-bd9a-a397fbfd7d7c"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("136412fa-f031-4da2-a8f4-95b13b992b95"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("bd24f1c6-9137-4af4-b061-83d7abb11333"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("79840674-bc1a-43ec-9796-cf5534851b4c"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("2b229819-1c1a-43b6-90aa-6eb1be4fef4a"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" },
                    { new Guid("1453dfa6-ccf2-4a3f-863e-02b9e72a8608"), "29031-843", "371.920.561-46", "Rua Dezessete de Dezembro", "Renato", 872, "(27) 99345-4790", "08/03/1995", "Cobrança", "Celular" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("04cb7e46-3b58-43f6-9891-69becb9de08c"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("059bd883-60c7-4030-b027-eba4b4ba4f66"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("05a2b9f9-548e-4568-b6f9-7213eca65f6d"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("0618ca70-e1bd-4a48-9674-c0073041d482"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("09ed0a5c-c864-407f-8a97-cf785c743c05"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("0b00db0b-0a99-4641-a309-79f7104c0b90"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("0b070c10-85d8-42e3-ac20-73f31bdea9f1"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("105a9986-8a02-46d2-bc30-1157f746df6d"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("136412fa-f031-4da2-a8f4-95b13b992b95"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("13d786b3-2b7c-4bb3-a2c1-a96950e7f438"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("1453dfa6-ccf2-4a3f-863e-02b9e72a8608"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("1b4d7197-7f18-4a2a-8cc8-319db764ca43"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("226394b5-d71b-4585-85b0-626fb9e98c28"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("2a4f399f-5eef-4aee-8786-da83443be27c"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("2b229819-1c1a-43b6-90aa-6eb1be4fef4a"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("3157e2c5-a180-4d94-a8b3-6578930f0edb"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("3840e792-a06e-46a7-a508-9256770d96de"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("3d9b2151-9213-489c-85be-62cac8186501"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("400da8db-e06a-46fe-844b-350854f154c4"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("43ce4ba1-8968-44a6-bfe8-8a88d19ebd15"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("4889865e-8495-4744-b0a7-7089da4c7fcd"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("5b4b7fa2-7ecf-4329-a4a0-9c9ed616adba"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("5f7c252f-361d-4323-a16d-d834392a8336"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("5fa7a9af-e98f-4f55-bf3c-b560cf099c0c"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("60dab023-cd94-4f1c-9494-cbea49a9ac93"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("643f9c93-fb87-49bb-9359-4cce2b6812e8"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("648d3e4e-3743-432b-8df2-d73f2f0010c1"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("65af0f71-f833-42ad-9b51-ffdffe8802cc"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("65ea3300-f6cd-4aa5-b6ba-3cd9406fd544"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("6627f7ba-7272-4fdd-9151-e3498fefbe08"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("6719ae21-0d8b-4471-ab78-fb934739e9ec"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("69b0bf9f-1142-43e3-9e22-79b1b3a80be8"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("6ef79089-e4ba-49be-a21d-9ca857113aa9"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("70fc4c9a-0ef2-4330-90fa-514056be55d8"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("7370b3f5-2122-410a-914a-7843f9cef7c2"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("79840674-bc1a-43ec-9796-cf5534851b4c"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("79ed0424-a9ce-4aee-9c5e-cbe396d2adee"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("8409b947-45f5-4b42-9d92-3fc8825252b6"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("869d0a3f-37dd-4a2e-907c-f149633eece8"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("87f5d0a6-3c87-4790-b6a8-31da9e971741"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("8a5ad4aa-0557-4331-9dbe-9ed308d97ac4"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("915949af-cb91-49f9-affb-c7381c8a9b67"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("979ff656-4597-4f65-95b0-019d2fcaeaa7"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("98cd273d-9ab2-4bbf-a181-1eb2f4f5c92c"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("a05b6f83-d756-49ae-83e1-0bbc9acb38e3"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("a53d0bd6-cb0c-423a-bbee-afad6632d66d"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("b1b4ac51-9242-4626-af79-8543995b8583"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("b3f56188-0e37-4320-8564-e7e32aa9e170"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("b50a9717-4467-4834-849a-069fca17227a"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("b6086964-cf0d-4700-ba64-787bfffdfa30"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("b640cc5f-2073-49e2-a51d-ed8e577f7a81"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("b64565cc-622d-47bf-95c3-a943ab36b682"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("b71ce95b-dcbf-46d2-9cde-7533a9a7bf8b"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("bd24f1c6-9137-4af4-b061-83d7abb11333"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("be994dc0-f8f0-4d50-9e9d-f386d43bdf28"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("c080b7ef-d06d-4919-837c-5ea09c5dd6f9"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("c1de88f5-ebcc-4b6a-96cb-9c4227e48321"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("cc665f4e-876e-4942-9c15-876b372fc004"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("d1af9b41-edb2-4e36-86ad-e917a2df83ae"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("d5721dff-d2d7-4d63-becb-c7346a6985d8"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("d8727424-3ecc-4f2d-b4ba-9c41ffb44b17"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("d89338d7-3cac-4a64-b6f6-a624185ed3c1"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("d941d382-8079-477a-86c1-7a80afbf0ddd"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("dfa22849-aa89-4489-96cd-76e7847c71c3"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("e2a068b4-d737-49f0-ad50-9d5d80876949"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("e51d378d-38be-4e80-bf18-248073dd057e"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("e5244be0-2d32-4c86-8a5d-4eb7d5d5303c"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("e7e3aa47-74d7-4647-9af4-703473978222"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("ebcf0934-e9d1-4245-849e-d03bae4d12ea"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("f5fad52a-8654-4fd3-bd9a-a397fbfd7d7c"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("f69077fd-76d8-4524-ad00-eeace6ef7cbf"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("fdbd8d55-0937-437c-8929-e2c22de425c9"));

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
