
using System;

namespace Hospitaal
{
	public class Especialista : persona_general, funcionesAd
	{
    private string cetificacionEspecifica;
    public string CertificacionEspecifica {get{return CertificacionEspecifica;}set{cetificacionEspecifica=value;}}
    
    public Especialista(string nombre, int identificacion, string especialidad, string certificacionEspecifica) 
        : base(nombre, identificacion, especialidad)
    {
        CertificacionEspecifica = certificacionEspecifica;
    }

 
    public void RecetarMedicamentos()
    {
        Console.WriteLine("El especialista está recetando medicamentos como especialista.");
    }

    public void ParticiparEnCirugia()
    {
        Console.WriteLine("El especialista está participando en una cirugía especializada.");
    }

  
    public override void AtenderPaciente()
    {
        Console.WriteLine("El especialista está atendiendo a un paciente especializado.");
    }

    public override void AdministrarMedicamentos()
    {
        Console.WriteLine("El especialista está administrando medicamentos específicos.");
    }

	}
}
