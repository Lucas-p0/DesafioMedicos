using System;
using System.Collections.Generic;
using System.IO;
using DesafioMedico.Modelos;
using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

string caminhoArquivo = @"DesafioMedico.xls";

try
{
    List<ConsultaMedica> consultas = LerConsultasExcel(caminhoArquivo);

    // Convertendo a lista de consultas para JSON
    string json = JsonConvert.SerializeObject(consultas, Formatting.Indented);

    // Imprimindo o JSON
    Console.WriteLine(json);
}
catch (Exception ex)
{
    Console.WriteLine($"Deu erro aqui: {ex.Message}");
}

List<ConsultaMedica> LerConsultasExcel(string caminhoArquivo)
{
    List<ConsultaMedica> consultas = new();

    try
    {
        using (FileStream fileStream = new FileStream(caminhoArquivo, FileMode.Open, FileAccess.Read))
        {
            IWorkbook workbook = new HSSFWorkbook(fileStream);
            ISheet sheet = workbook.GetSheetAt(0);

            for (int rowIndex = 1; rowIndex <= sheet.LastRowNum; rowIndex++)
            {
                IRow row = sheet.GetRow(rowIndex);
                if (row != null)
                {
                    DateTime dataConsulta = row.GetCell(0).DateCellValue;
                    string horaConsulta = row.GetCell(1).StringCellValue;
                    string nomePaciente = row.GetCell(2).StringCellValue;
                    long cpf = (long)row.GetCell(3).NumericCellValue;
                    string rua = row.GetCell(4).StringCellValue;
                    string cidade = row.GetCell(5).StringCellValue;
                    string estado = row.GetCell(6).StringCellValue;
                    string especialidade = row.GetCell(7).StringCellValue;
                    string nomeMedico = row.GetCell(8).StringCellValue;
                    bool particular = row.GetCell(9).StringCellValue.Equals("Sim", StringComparison.OrdinalIgnoreCase);
                    long numeroCarteirinha = (long)row.GetCell(10).NumericCellValue;

                    ConsultaMedica consulta = new(dataConsulta, horaConsulta, nomePaciente, cpf, rua, cidade, estado, especialidade, nomeMedico, particular, numeroCarteirinha);
                    consultas.Add(consulta);
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro na leitura do Excel: {ex.Message}");
    }

    return consultas;
}

