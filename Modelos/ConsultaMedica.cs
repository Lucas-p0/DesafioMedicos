using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace DesafioMedico.Modelos;

public class ConsultaMedica
{
    [JsonPropertyName("DataConsulta")]
    public string? DataConsulta { get; protected set; }

    [JsonPropertyName("HoraDaConsulta")]
    public string? HoraDaConsulta { get; protected set; }

    [JsonPropertyName("NomePaciente")]
    public string? NomePaciente { get; protected set; }

    [JsonPropertyName("NumeroTelefone")]
    public string? NumeroTelefone { get; protected set; }

    [JsonPropertyName("Cpf")]
    public string Cpf { get; protected set; }

    [JsonPropertyName("Rua")]
    public string? Rua { get; protected set; }

    [JsonPropertyName("Cidade")]
    public string? Cidade { get; protected set; }

    [JsonPropertyName("Estado")]
    public string? Estado { get; protected set; }

    [JsonPropertyName("Especialidade")]
    public string? Especialidade { get; protected set; }

    [JsonPropertyName("NomeMedico")]
    public string? NomeMedico { get; protected set; }

    [JsonPropertyName("Particular")]
    public string? Particular { get; protected set; }

    [JsonPropertyName("NumeroDaCarteirinha")]
    public string? NumeroDaCarteirinha { get; protected set; }

    [JsonPropertyName("ValorDaConsulta")]
    public string? ValorDaConsulta { get; protected set; }


    // public ConsultaMedica(DateTime dataConsulta, string horaConsulta, string nomePaciente, long cpf, string rua, string cidade, string estado, string especialidade, string nomeMedico, bool particular, long numeroDaCarteirinha)
    // {
    //     SetDataConsulta(dataConsulta);
    //     HoraDaConsulta = horaConsulta;
    //     NomePaciente = nomePaciente;
    //     Cpf = cpf;
    //     Rua = rua;
    //     Cidade = cidade;
    //     Estado = estado;
    //     Especialidade = especialidade;
    //     NomeMedico = nomeMedico;
    //     Particular = particular;
    //     NumeroDaCarteirinha = numeroDaCarteirinha;
    // }
    // public void SetDataConsulta(DateTime dataConsulta)
    // {
    //     if (dataConsulta < DateTime.Now)
    //     {
    //         System.Console.WriteLine($"A data da consulta deve ser menor que a data {dataConsulta}");
    //     }
    //     DataConsulta = dataConsulta;
    // }
}

