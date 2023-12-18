using System.Linq;
using DesafioMedico.Modelos;


namespace DesafioMedico.Filtro
{
    public class LinqFilter
    {
        public static void FiltraPacientesPorConsulta(List<ConsultaMedica> consultas)
        {
            var todasAsConsultas = consultas.OrderBy(consulta => consulta.NomeMedico).Select(consultaMedica => consultaMedica).Distinct().ToList();
            foreach (var consulta in todasAsConsultas)
            {
                Console.WriteLine($"{consulta}");
            }
        }


    }
}

