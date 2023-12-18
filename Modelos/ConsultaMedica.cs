namespace DesafioMedico.Modelos;

public class ConsultaMedica
{
    public DateTime DataConsulta { get; protected set; }
    public string HoraDaConsulta { get; protected set; }
    public string NomePaciente { get; protected set; }
    public string? NumeroTelefone { get; protected set; }
    public long Cpf { get; protected set; }
    public string Rua { get; protected set; }
    public string Cidade { get; protected set; }
    public string Estado { get; protected set; }
    public string Especialidade { get; protected set; }
    public string NomeMedico { get; protected set; }
    public bool Particular { get; protected set; }
    public long NumeroDaCarteirinha { get; protected set; }

    public ConsultaMedica(DateTime dataConsulta, string horaConsulta, string nomePaciente, long cpf, string rua, string cidade, string estado, string especialidade, string nomeMedico, bool particular, long numeroDaCarteirinha)
    {
        SetDataConsulta(dataConsulta);
        HoraDaConsulta = horaConsulta;
        NomePaciente = nomePaciente;
        Cpf = cpf;
        Rua = rua;
        Cidade = cidade;
        Estado = estado;
        Especialidade = especialidade;
        NomeMedico = nomeMedico;
        Particular = particular;
        NumeroDaCarteirinha = numeroDaCarteirinha;
    }
    public void SetDataConsulta(DateTime dataConsulta)
    {
        if (dataConsulta < DateTime.Now)
        {
            System.Console.WriteLine($"A data da consulta deve ser menor que a data {dataConsulta}");
        }
        DataConsulta = dataConsulta;
    }
}

