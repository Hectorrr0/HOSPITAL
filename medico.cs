
using System;

namespace Hospitaal
{
		public class medico : persona_general, funcionesAd
		{
		private string areaDeEspecializacion;
    	public string AreaDeEspecializacion {get{return especialidad;}set{especialidad=value;}}

    	public medico(string nombre, int identificacion, string especialidad) 
        	: base(nombre, identificacion, especialidad)
    	{
        	AreaDeEspecializacion = areaDeEspecializacion;
    	}
    
    
    	public void RecetarMedicamentos()
    	{
        	Console.WriteLine("El medico esta recetando medicamentos.");
    	}

    	public void ParticiparEnCirugia()
    	{
        	Console.WriteLine("El medico esta participando en una cirugía.");
    	}

    	public override void AtenderPaciente()
    	{
        	Console.WriteLine("EL medico sta atendiendo a un paciente.");
    	}

    	public override void AdministrarMedicamentos()
    	{
        	Console.WriteLine("El medico está administrando medicamentos.");
    	}
	}
		
}
