
using System;

namespace Hospitaal
{

	 public abstract class persona_general
	{
	 	protected string nombre, especialidad;
	 	protected int identificacion;
	 	public string Nombre {get{return nombre;}set{nombre=value;}}
    	public int Identificacion {get{return identificacion;}set{identificacion=value;}}
    	public string Especialidad {get{return especialidad;}set{especialidad=value;}}
    	
    	
    	public persona_general()
    	{
        	Nombre = "desconocido";
        	Identificacion = 00000000;
        	Especialidad = "desconocido";
    	}

    	
    	public persona_general(string nombre, int identificacion, string especialidad)
    	{
        	Nombre = nombre;
        	Identificacion = identificacion;
        	Especialidad = especialidad;
    	}

    	
    	public virtual void AtenderPaciente()
    	{
    		Console.WriteLine("Atendiendo paciente");
    	}
    	public virtual void AdministrarMedicamentos()
    	{
    		Console.WriteLine("Administrando medicamento");
    	}
    

    	public void ObtenerInformacion()
    	{
        	Console.WriteLine("Nombre:"+ nombre);
        	Console.WriteLine("Identificacion:" + identificacion);
        	Console.WriteLine("Especialidad:" + especialidad);
    	}
	}
}
