using Microsoft.Office.Interop.Excel;
using System;
using ClosedXML.Excel;
using System.Diagnostics;

namespace FA29
{
    class Controler
    {

        static private int Item = 1;
        static private int Line = 7;

        static private IXLBorder Border(IXLWorksheet ws, string Init, string Fim) => ws.Range(ws.Cell(Init).Address, ws.Cell(Fim).Address).Style.Border;

        static private IXLRange Select(IXLWorksheet ws, string Init, string Fim) => ws.Range(ws.Cell(Init).Address, ws.Cell(Fim).Address);

        static public void AddLine(IXLWorksheet ws, string Descricao, string Quantidade, string ValorUnit, string AplicacaoPrev)
        {
            ws.Cell($"A{Line}").Value = Item++;
            ws.Cell($"B{Line}").Value = Descricao;
            ws.Cell($"I{Line}").Value = "Unid";
            ws.Cell($"J{Line}").Value = Quantidade;
            ws.Cell($"K{Line}").Value = ValorUnit;
            ws.Cell($"L{Line}").FormulaA1 = $"=Product(K{Line},J{Line})";
            ws.Cell($"M{Line++}").Value = AplicacaoPrev;
        }

        static public void CreateArchive(IXLWorksheet ws, string Destinatario, string Gestor, string FilCnpj, string NumberFa)
        {
            #region Bordas
            Border(ws, "A1", "A40").LeftBorder = XLBorderStyleValues.Thin;
            Border(ws, "A1", "A40").LeftBorderColor = XLColor.Black;

            Border(ws, "R1", "R40").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "R1", "R40").RightBorderColor = XLColor.Black;

            Border(ws, "A6", "A29").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "A6", "A29").RightBorderColor = XLColor.Black;

            Border(ws, "H6", "H29").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "H6", "H29").RightBorderColor = XLColor.Black;

            Border(ws, "I6", "I29").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "I6", "I29").RightBorderColor = XLColor.Black;

            Border(ws, "J6", "J29").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "J6", "J29").RightBorderColor = XLColor.Black;

            Border(ws, "K6", "K29").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "K6", "K29").RightBorderColor = XLColor.Black;

            Border(ws, "L6", "L29").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "L6", "L29").RightBorderColor = XLColor.Black;

            Border(ws, "M1", "M3").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "M1", "M3").RightBorderColor = XLColor.Black;

            Border(ws, "M31", "M35").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "M31", "M35").RightBorderColor = XLColor.Black;

            Border(ws, "I38", "I40").RightBorder = XLBorderStyleValues.Thin;
            Border(ws, "I38", "I40").RightBorderColor = XLColor.Black;

            Border(ws, "A40", "R40").BottomBorder = XLBorderStyleValues.Thin;
            Border(ws, "A40", "R40").BottomBorderColor = XLColor.Black;

            Border(ws, "A1", "R1").TopBorder = XLBorderStyleValues.Thin;
            Border(ws, "A1", "R1").TopBorderColor = XLColor.Black;

            Border(ws, "A4", "R4").TopBorder = XLBorderStyleValues.Thin;
            Border(ws, "A4", "R4").TopBorderColor = XLColor.Black;

            Border(ws, "A36", "R36").TopBorder = XLBorderStyleValues.Thin;
            Border(ws, "A36", "R36").TopBorderColor = XLColor.Black;

            Border(ws, "A38", "R38").TopBorder = XLBorderStyleValues.Thin;
            Border(ws, "A38", "R38").TopBorderColor = XLColor.Black;

            ws.Cell("P30").Style.Border.RightBorder = XLBorderStyleValues.Thin;
            ws.Cell("P30").Style.Border.RightBorderColor = XLColor.Black;

            for (int i = 6; i < 32; i++)
            {
                Border(ws, $"A{i}", $"R{i}").TopBorder = XLBorderStyleValues.Thin;
                Border(ws, $"A{i}", $"R{i}").TopBorderColor = XLColor.Black;
            }
            #endregion

            #region Conteudos
            ws.Cell("D2").Value = "    FA.29R00  -   MOVIMENTAÇÃO DE PATRIMÔNIO";

            ws.Cell("O2").Value = "N.º:";

            ws.Cell("P2").Value = $"{NumberFa}/2022";

            ws.Cell("A4").Value = "Origem:";
            ws.Cell("B4").Value = "LOCAL/ ENC.ADMINISTRATIVO";
            ws.Cell("A5").Value = "Matriz - Departamento de TI";

            ws.Cell("K4").Value = "Destinatário:";
            ws.Cell("L4").Value = Destinatario;
            ws.Cell("K5").Value = "Filial:";
            ws.Cell("L5").Value = FilCnpj;

            ws.Cell("A6").Value = "Item";
            ws.Cell("E6").Value = "Descrição do Patrimonio";
            ws.Cell("I6").Value = "Unid";
            ws.Cell("J6").Value = "Quant.";
            ws.Cell("K6").Value = "Valor Unit";
            ws.Cell("L6").Value = "Valor Total";
            ws.Cell("O6").Value = "Aplicação Previsória";
            ws.Cell("H30").Value = "Valor Total";
            ws.Cell("Q30").FormulaA1 = "=Sum(L7:L29)";

            ws.Cell("A31").Value = "Tipo de Movimentação";
            ws.Cell("D33").Value = "Transferencia";
            ws.Cell("D34").Value = "Venda";
            ws.Cell("D35").Value = "Furto";
            ws.Cell("J33").Value = "Descarte";
            ws.Cell("J34").Value = "Doação";
            ws.Cell("J35").Value = "Outro";

            ws.Cell("N31").Value = "Veiculo de transporte:";
            ws.Cell("N33").Value = "       Placa n°_________";

            ws.Cell("A36").Value = "Responsável pelo Transporte:";
            ws.Cell("E36").Value = "Próprio";
            ws.Cell("E37").Value = "Contratado";
            ws.Cell("I36").Value = "Nome Completo:";
            ws.Cell("I37").Value = "Assinatura:";

            ws.Cell("A38").Value = "Liberações Envio / Data:";
            ws.Cell("D40").Value = "Gerente de TI";
            ws.Cell("F40").Value = "Auxiliar Administrativo";

            ws.Cell("L40").Value = Destinatario;
            ws.Cell("O40").Value = Gestor;
            #endregion

            #region Formatações
            ws.Cells("D2,O2,P2").Style.Font.Bold = true;
            ws.Cells("O2,P2").Style.Font.FontSize = 16;

            ws.Cells("N31:N33").Style.Font.FontColor = XLColor.Red;

            ws.Row(2).Height = 20;
            ws.Row(4).Height = 25;
            ws.Row(5).Height = 25;
            ws.Row(36).Height = 25;

            ws.Column(11).Width = 13;
            ws.Column(12).Width = 11;

            for (int i = 7; i < 29; i++)
            {
                Select(ws, $"B{i}", $"H{i}").Row(1).Merge();
                Select(ws, $"M{i}", $"R{i}").Row(1).Merge();
            }
            #endregion
        }



    }
}
