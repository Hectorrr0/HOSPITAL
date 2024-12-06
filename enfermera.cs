
using System;

namespace Hospitaal
{
	public class Enfermera : persona_general
	{
    
	private string turno;
    public string Turno {get{return turno;}set{turno=value;}}

    public Enfermera(string nombre, int identificacion, string especialidad, string turno) 
        : base(nombre, identificacion, especialidad)
    {
        Turno = turno;
    }

    
    public override void AtenderPaciente()
    {
        Console.WriteLine("la enfermera está atendiendo a un paciente.");
    }

    public override void AdministrarMedicamentos()
    {
        Console.WriteLine("la enfermera está administrando medicamentos.");
    }
    
    public void ParticiparEnCirugia()
    {
        Console.WriteLine("la enfermera está participando en una cirugía.");
    }
}
	
}
