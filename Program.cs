using DesafioMedico.Filtro;
using DesafioMedico.Modelos;

using System.Text.Json;

using (HttpClient client = new())
{
    string URL_API = "https://github.com/Lucas-p0/DesafioMedicos/blob/main/DesafioMedico.json";

    try
    {
        string response = await client.GetStringAsync(URL_API);
        var resultadoExcel = JsonSerializer.Deserialize<List<ConsultaMedica>>(response);

        Console.WriteLine(resultadoExcel);

        LinqFilter.FiltraPacientesPorConsulta(resultadoExcel);

    }
    catch (Exception ex)
    {
        Console.WriteLine("Deu erro aqui : " + ex.Message);

    }
}