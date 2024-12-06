
using System;

namespace Hospitaal
{

	public class paramedico : persona_general
	{
	private string certificacion;
    public string Certificacion {get{return certificacion;}set{certificacion=value;}}

    public paramedico(string nombre, int identificacion, string especialidad, string Certificacion) 
        : base(nombre, identificacion, especialidad)
    {
        Certificacion = certificacion;
    }

    
    public override void AtenderPaciente()
    {
        Console.WriteLine("El paramedico está atendiendo a un paciente.");
    }

    public override void AdministrarMedicamentos()
    {
        Console.WriteLine("El paramedico está administrando medicamentos.");
    }

	}
}
