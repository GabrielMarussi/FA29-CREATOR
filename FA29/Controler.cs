using ClosedXML.Excel;
using System.IO;
using System.Windows.Forms;

namespace FA29
{
    class Controler
    {

        static private int Item = 1;
        static private int Line = 7;

        static private IXLRange Select(IXLWorksheet ws, string Init, string Fim) => ws.Range(ws.Cell(Init).Address, ws.Cell(Fim).Address);

        static public void AddLine(IXLWorksheet ws, string Descricao, string Quantidade, string ValorUnit, string AplicacaoPrev)
        {
            ws.Cell($"B{Line}").Value = Item++;
            ws.Cell($"C{Line}").Value = Descricao;
            ws.Cell($"I{Line}").Value = "Unid";
            ws.Cell($"J{Line}").Value = Quantidade;
            ws.Cell($"K{Line}").Value = ValorUnit;
            ws.Cell($"L{Line}").FormulaA1 = $"=Product(K{Line},J{Line})";
            ws.Cell($"M{Line++}").Value = AplicacaoPrev;


        }

        static public void CreateArchive(bool Cnpj, IXLWorksheet ws, string Destinatario, string FilCnpj, string NumberFa, string Datalib)
        {
            if (Cnpj)
            {
                ws.Cell("K5").Value = "Cnpj:";
                ws.Cell("L5").Value = FilCnpj;

                Select(ws, "L39", "N39").Row(1).Merge();
                Select(ws, "L40", "N40").Row(1).Merge();
            }
            else
            {
                ws.Cell("K5").Value = "Filial:";
                ws.Cell("L5").Value = FilCnpj;
                ws.Cell("O40").Value = FilCnpj.Substring(0, 3) == "001" ? "Gerente" : "Gestor Contrato";
                ws.Cell("O39").Value = "_________________________";

                Select(ws, "L39", "N39").Row(1).Merge();
                Select(ws, "O39", "R39").Row(1).Merge();
                Select(ws, "L40", "N40").Row(1).Merge();
                Select(ws, "O40", "R40").Row(1).Merge();
            }

            #region Bordas
            const string LeftBorder = "A1:A40";
            const string RightBorder = "R1:R40,B6:B29,C6:C29,H6:H29,I6:I29,J6:J29,J4:J5,K6:K29,L6:L30,M1:M3,M31:M35,K38:K40,K30";
            const string BottomBorder = "A40:R40";
            const string TopBorder = "A1:R1,A4:R4,A6:R6,A7:R7,A36:R36,A30:K30,A31:R31,A38:R38,A8:R29,L30:R30";

            ws.Cells().Style.Border.LeftBorderColor = XLColor.Black;
            ws.Cells().Style.Border.RightBorderColor = XLColor.Black;
            ws.Cells().Style.Border.TopBorderColor = XLColor.Black;

            ws.Cells(LeftBorder).Style.Border.LeftBorder = XLBorderStyleValues.Thin;

            ws.Cells(RightBorder).Style.Border.RightBorder = XLBorderStyleValues.Thin;

            ws.Cells(BottomBorder).Style.Border.BottomBorder = XLBorderStyleValues.Thin;

            ws.Cells(TopBorder).Style.Border.TopBorder = XLBorderStyleValues.Thin;

            ws.Cells("A8:R29,L30:R30").Style.Border.TopBorderColor = XLColor.FromArgb(217, 217, 217);

            #endregion

            #region Conteudos
            string LogoSgi = Application.StartupPath + @"\Src\LogoSgi.png";
            string LogoTriunfo = Application.StartupPath + @"\Src\LogoTriunfo.png";

            ws.AddPicture(LogoSgi)
                .MoveTo(ws.Cell("M2"))
                .Scale(.29);

            ws.AddPicture(LogoTriunfo)
                .MoveTo(ws.Cell("B2")).
                Scale(.31);
                

            ws.Cell("C2").Value = "FA.29R00  -   MOVIMENTAÇÃO DE PATRIMÔNIO";

            ws.Cell("O2").Value = "N.º:";

            ws.Cell("P2").Value = $"{NumberFa}/2022";

            ws.Cell("B4").Value = "ORIGEM: Matriz";
            ws.Cell("B5").Value = "Departamento de TI / Mauricio Meter";

            ws.Cell("K4").Value = "Destinatário:";
            ws.Cell("L4").Value = Destinatario;

            ws.Cell("B6").Value = "Item";
            ws.Cell("C6").Value = "Descrição do Patrimonio";
            ws.Cell("I6").Value = "Unid";
            ws.Cell("J6").Value = "Quant.";
            ws.Cell("K6").Value = "Valor Unit";
            ws.Cell("L6").Value = "Valor Total";
            ws.Cell("M6").Value = "Aplicação Previsória";

            ws.Cell("F30").Value = "Valor Total";
            ws.Cell("L30").FormulaA1 = "=Sum(L7:L29)";

            ws.Cell("B31").Value = "Tipo de Movimentação";
            ws.Cell("F33").Value = "Transferencia";
            ws.Cell("F34").Value = "Venda";
            ws.Cell("F35").Value = "Furto";
            ws.Cell("L33").Value = "Descarte";
            ws.Cell("L34").Value = "Doação";
            ws.Cell("L35").Value = "Outro";

            ws.Cell("E33").Value = "□";
            ws.Cell("E34").Value = "□";
            ws.Cell("E35").Value = "□";
            ws.Cell("K33").Value = "□";
            ws.Cell("K34").Value = "□";
            ws.Cell("K35").Value = "□";

            ws.Cell("N31").Value = "Veiculo de transporte:";
            ws.Cell("N33").Value = "       Placa n°_________";

            ws.Cell("A36").Value = "Responsável pelo Transporte:";
            ws.Cell("F36").Value = "Próprio";
            ws.Cell("E36").Value = "□";
            ws.Cell("F37").Value = "Contratado";
            ws.Cell("E37").Value = "□";
            ws.Cell("K36").Value = "Nome Completo:";
            ws.Cell("K37").Value = "Assinatura:";

            ws.Cell("B38").Value = "Liberações Envio / Data:";
            ws.Cell("E38").Value = "'" + Datalib;
            ws.Cell("L38").Value = "Recebimento / Data:"; 
            ws.Cell("A40").Value = "Gerente de TI";
            ws.Cell("A39").Value = "____________________";
            ws.Cell("E40").Value = "Coordenador de TI";
            ws.Cell("E39").Value = "____________________";
            ws.Cell("J40").Value = "Auxiliar Adm.";
            ws.Cell("J39").Value = "____________________";

            ws.Cell("L40").Value = Destinatario;
            ws.Cell("L39").Value = "_________________________";

            #endregion

            #region Alinhamento
            ws.Cells("D1,K4,K5,J36,J37,O2,E33:E37,K33:K35").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            ws.Cells("A38,D6,E38,L4,L5,L38").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            ws.Cells("C2,M6,A6:L29,A39:R40,Q30").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cells("B4,B5,B36,B38,C4,E38,K4:L5,L38").Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;
            ws.Cells("A39,F2,B39:R40,B6:R6").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            #endregion

            #region Dimensionamento
            ws.Rows().Height = 13;
            ws.Rows("28,29,32").Height = 0;
            ws.Row(1).Height = 3;
            ws.Rows("4,5,6,37,39,40").Height = 20;
            ws.Row(36).Height = 25;
            ws.Rows("2,38").Height = 30;

            ws.Columns("2").Width = 4;
            ws.Columns("3").Width = 7.29;
            ws.Columns("4").Width = 7.71;
            ws.Columns("6").Width = 5.71;
            ws.Columns("9").Width = 4.86;
            ws.Columns("11,12").Width = 12.71;
            ws.Columns("1, 7, 8").Width = 0;
            #endregion

            #region Fonte
            ws.Cells("N31:N33").Style.Font.FontColor = XLColor.Red;
            ws.Cells("C2,O2,P2").Style.Font.FontSize = 16;
            ws.Cells("A40:R40,E33:E37,K33:K35").Style.Font.FontSize = 14;
            ws.Cells("B31,A36").Style.Font.FontSize = 9 ;
            ws.Cells("B7:B26,M7:M26").Style.Font.FontSize = 10;
            ws.Cells("C2,L30,O2,P2").Style.Font.Bold = true;
            #endregion

            #region Config de Impressão
            ws.PageSetup.AdjustTo(98);
            ws.PageSetup.PageOrientation = XLPageOrientation.Landscape;
            ws.PageSetup.PaperSize = XLPaperSize.A4Paper;

            ws.PageSetup.Margins.Top = 0;
            ws.PageSetup.Margins.Bottom = 0;
            ws.PageSetup.Margins.Left = 0;
            ws.PageSetup.Margins.Right = 0;
            ws.PageSetup.Margins.Footer = 0;
            ws.PageSetup.Margins.Header = 0;

            ws.PageSetup.CenterHorizontally = true;
            ws.PageSetup.CenterVertically = true;
            #endregion

            #region Mesclagem

            Select(ws, "C2", "L2").Row(1).Merge();

            Select(ws, "A40", "D40").Row(1).Merge();
            Select(ws, "E40", "I40").Row(1).Merge();
            Select(ws, "J40", "K40").Row(1).Merge();
            Select(ws, "L40", "N40").Row(1).Merge();
            Select(ws, "O40", "R40").Row(1).Merge();

            Select(ws, "A39", "D39").Row(1).Merge();
            Select(ws, "E39", "I39").Row(1).Merge();
            Select(ws, "J39", "K39").Row(1).Merge();

            Select(ws, "Q30", "R30").Row(1).Merge();

            Select(ws, "M30", "R30").Row(1).Merge();

            Select(ws, "M6", "R6").Row(1).Merge();
            Select(ws, "C6", "H6").Row(1).Merge();

            for (int i = 7; i < 29; i++)
            {
                Select(ws, $"C{i}", $"H{i}").Row(1).Merge();
                Select(ws, $"M{i}", $"R{i}").Row(1).Merge();
            }
            #endregion

            #region Formulas e Data Types

            ws.Cells("L30,K7:L26").Style.NumberFormat.Format = "R$ ###,##0.00";
            ws.Cell("P2").Style.NumberFormat.Format = "####/2022";

            #endregion
        }



    }
}
