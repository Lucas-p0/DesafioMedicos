public class Medico
{
    public string NomeMedico { get; protected set; }
    public List<string> Especialidades { get; protected set; }

    public Medico(string nomeMedico, List<string> especialidades)
    {
        NomeMedico = nomeMedico;
        Especialidades = especialidades;
    }
}