using Microsoft.EntityFrameworkCore.Migrations;

namespace unicformatos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inscripcion",
                columns: table => new
                {
                    Matricula = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Licenciatura = table.Column<string>(nullable: true),
                    Semestre = table.Column<string>(nullable: true),
                    Generacion = table.Column<long>(nullable: false),
                    Personal_Nombre = table.Column<string>(nullable: true),
                    Personal_ApPaterno = table.Column<string>(nullable: true),
                    Personal_ApMaterno = table.Column<string>(nullable: true),
                    Personal_Nacionalidad = table.Column<string>(nullable: true),
                    Personal_LugarNacimiento = table.Column<string>(nullable: true),
                    Personal_Contacto_TelParticular = table.Column<string>(nullable: true),
                    Personal_Contacto_TelCelular = table.Column<string>(nullable: true),
                    Personal_Contacto_Email = table.Column<string>(nullable: true),
                    Personal_FechaNacimiento_Year = table.Column<long>(nullable: true),
                    Personal_FechaNacimiento_Month = table.Column<long>(nullable: true),
                    Personal_FechaNacimiento_Day = table.Column<long>(nullable: true),
                    Domicilio_Calle = table.Column<string>(nullable: true),
                    Domicilio_Numero = table.Column<long>(nullable: true),
                    Domicilio_Colonia = table.Column<string>(nullable: true),
                    Domicilio_Municipio = table.Column<string>(nullable: true),
                    Domicilio_Poblacion = table.Column<string>(nullable: true),
                    Domicilio_Cp = table.Column<long>(nullable: true),
                    Domicilio_Estado = table.Column<string>(nullable: true),
                    Padre_Contacto_TelParticular = table.Column<string>(nullable: true),
                    Padre_Contacto_TelCelular = table.Column<string>(nullable: true),
                    Padre_Contacto_Email = table.Column<string>(nullable: true),
                    Padre_Parentesco = table.Column<string>(nullable: true),
                    Padre_Nombre = table.Column<string>(nullable: true),
                    Padre_Domicilio = table.Column<string>(nullable: true),
                    Padre_Empresa = table.Column<string>(nullable: true),
                    Madre_Contacto_TelParticular = table.Column<string>(nullable: true),
                    Madre_Contacto_TelCelular = table.Column<string>(nullable: true),
                    Madre_Contacto_Email = table.Column<string>(nullable: true),
                    Madre_Parentesco = table.Column<string>(nullable: true),
                    Madre_Nombre = table.Column<string>(nullable: true),
                    Madre_Domicilio = table.Column<string>(nullable: true),
                    Madre_Empresa = table.Column<string>(nullable: true),
                    Emergencia_Contacto_Contacto_TelParticular = table.Column<string>(nullable: true),
                    Emergencia_Contacto_Contacto_TelCelular = table.Column<string>(nullable: true),
                    Emergencia_Contacto_Contacto_Email = table.Column<string>(nullable: true),
                    Emergencia_Contacto_Parentesco = table.Column<string>(nullable: true),
                    Emergencia_Contacto_Nombre = table.Column<string>(nullable: true),
                    Emergencia_Contacto_Domicilio = table.Column<string>(nullable: true),
                    Emergencia_Contacto_Empresa = table.Column<string>(nullable: true),
                    Emergencia_TipoSangre = table.Column<string>(nullable: true),
                    Trabajo_Nombre = table.Column<string>(nullable: true),
                    Trabajo_Telefono = table.Column<string>(nullable: true),
                    Trabajo_Domicilio_Calle = table.Column<string>(nullable: true),
                    Trabajo_Domicilio_Numero = table.Column<long>(nullable: true),
                    Trabajo_Domicilio_Colonia = table.Column<string>(nullable: true),
                    Trabajo_Domicilio_Municipio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inscripcion", x => x.Matricula);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inscripcion");
        }
    }
}
