using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicAngular.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    zipcode = table.Column<string>(type: "varchar(255)", nullable: true),
                    country = table.Column<string>(type: "varchar(255)", nullable: true),
                    region = table.Column<string>(type: "varchar(255)", nullable: true),
                    locality = table.Column<string>(type: "varchar(255)", nullable: true),
                    street = table.Column<string>(type: "varchar(255)", nullable: true),
                    house = table.Column<string>(type: "varchar(255)", nullable: true),
                    apartment = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    patient_id = table.Column<int>(type: "INTEGER", nullable: false),
                    schedule_id = table.Column<int>(type: "INTEGER", nullable: false),
                    is_patient_visited = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    setting_id = table.Column<int>(type: "INTEGER", nullable: false),
                    doc_id = table.Column<int>(type: "INTEGER", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    data_appointment = table.Column<DateTime>(type: "timestamp", nullable: false),
                    start_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    duration = table.Column<int>(type: "integer", nullable: false),
                    qty_appointments = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    first_name = table.Column<string>(type: "timestamp", nullable: true),
                    middle_name = table.Column<string>(type: "timestamp", nullable: true),
                    last_name = table.Column<string>(type: "timestamp", nullable: true),
                    phone = table.Column<string>(type: "varchar(255)", nullable: true),
                    email = table.Column<string>(type: "varchar(255)", nullable: true),
                    address_id = table.Column<int>(type: "INTEGER", nullable: false),
                    birthday = table.Column<DateTime>(type: "timestamp", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contacts_Addresses_address_id",
                        column: x => x.address_id,
                        principalTable: "Addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Docs",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    contact_id = table.Column<int>(type: "INTEGER", nullable: false),
                    speciality = table.Column<string>(type: "varchar(255)", nullable: true),
                    office = table.Column<string>(type: "varchar(255)", nullable: true),
                    hired_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docs", x => x.id);
                    table.ForeignKey(
                        name: "FK_Docs_Contacts_contact_id",
                        column: x => x.contact_id,
                        principalTable: "Contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    contact_id = table.Column<int>(type: "integer", nullable: false),
                    medical_history = table.Column<string>(type: "varchar(255)", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.id);
                    table.ForeignKey(
                        name: "FK_Patients_Contacts_contact_id",
                        column: x => x.contact_id,
                        principalTable: "Contacts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_address_id",
                table: "Contacts",
                column: "address_id");

            migrationBuilder.CreateIndex(
                name: "IX_Docs_contact_id",
                table: "Docs",
                column: "contact_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Patients_contact_id",
                table: "Patients",
                column: "contact_id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Docs");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
