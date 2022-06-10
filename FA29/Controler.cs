using ClosedXML.Excel;
using System.IO;
using System.Windows.Forms;

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

        static public void CreateArchive(IXLWorksheet ws, string Destinatario, string Gestor, string FilCnpj, string NumberFa, string Datalib)
        {
            #region Bordas
            ws.Cells().Style.Border.LeftBorderColor = XLColor.Black;
            ws.Cells().Style.Border.RightBorderColor = XLColor.Black;
            ws.Cells().Style.Border.TopBorderColor = XLColor.Black;

            Border(ws, "A1", "A40").LeftBorder = XLBorderStyleValues.Thin;

            Border(ws, "R1", "R40").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "A6", "A29").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "H6", "H29").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "I6", "I29").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "J6", "J29").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "J4", "J5").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "K6", "K29").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "L6", "L30").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "M1", "M3").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "M31", "M35").RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "K38", "K40").RightBorder = XLBorderStyleValues.Thin;

            ws.Cells("K30").Style.Border.RightBorder = XLBorderStyleValues.Thin;

            Border(ws, "A40", "R40").BottomBorder = XLBorderStyleValues.Thin;

            Border(ws, "A1", "R1").TopBorder = XLBorderStyleValues.Thin;

            Border(ws, "A4", "R4").TopBorder = XLBorderStyleValues.Thin;

            Border(ws, "A6", "R6").TopBorder = XLBorderStyleValues.Thin;

            Border(ws, "A7", "R7").TopBorder = XLBorderStyleValues.Thin;

            Border(ws, "A36", "R36").TopBorder = XLBorderStyleValues.Thin;

            Border(ws, "A30", "K30").TopBorder = XLBorderStyleValues.Thin;

            Border(ws, "A31", "R31").TopBorder = XLBorderStyleValues.Thin;

            Border(ws, "A38", "R38").TopBorder = XLBorderStyleValues.Thin;

            Border(ws, $"A{8}", $"R{29}").TopBorder = XLBorderStyleValues.Thin;
            Border(ws, $"A{8}", $"R{29}").TopBorderColor = XLColor.FromArgb(217, 217, 217);

            #endregion

            #region Conteudos
            string LogoSgi = Application.StartupPath + @"\Src\LogoSgi.png";
            string LogoTriunfo = Application.StartupPath + @"\Src\LogoTriunfo.png";

            ws.AddPicture(LogoSgi)
                .MoveTo(ws.Cell("M2"))
                .Scale(.29);

            ws.AddPicture(LogoTriunfo)
                .MoveTo(ws.Cell("A2")).
                Scale(.31);
                

            ws.Cell("C2").Value = "    FA.29R00  -   MOVIMENTAÇÃO DE PATRIMÔNIO";

            ws.Cell("O2").Value = "N.º:";

            ws.Cell("P2").Value = $"{NumberFa}/2022";

            ws.Cell("A4").Value = "ORIGEM:";
            ws.Cell("B4").Value = "LOCAL/ ENC.ADMINISTRATIVO";
            ws.Cell("A5").Value = "Matriz - Departamento de TI";

            ws.Cell("K4").Value = "Destinatário:";
            ws.Cell("L4").Value = Destinatario;
            ws.Cell("K5").Value = "Filial:";
            ws.Cell("L5").Value = FilCnpj;

            ws.Cell("A6").Value = "Item";
            ws.Cell("D6").Value = "Descrição do Patrimonio";
            ws.Cell("I6").Value = "Unid";
            ws.Cell("J6").Value = "Quant.";
            ws.Cell("K6").Value = "Valor Unit";
            ws.Cell("L6").Value = "Valor Total";
            ws.Cell("O6").Value = "Aplicação Previsória";

            ws.Cell("F30").Value = "Valor Total";
            ws.Cell("L30").FormulaA1 = "=Sum(L7:L29)";

            ws.Cell("A31").Value = "Tipo de Movimentação";
            ws.Cell("E33").Value = "Transferencia";
            ws.Cell("E34").Value = "Venda";
            ws.Cell("E35").Value = "Furto";
            ws.Cell("L33").Value = "Descarte";
            ws.Cell("L34").Value = "Doação";
            ws.Cell("L35").Value = "Outro";

            ws.Cell("D33").Value = "□";
            ws.Cell("D34").Value = "□";
            ws.Cell("D35").Value = "□";
            ws.Cell("K33").Value = "□";
            ws.Cell("K34").Value = "□";
            ws.Cell("K35").Value = "□";

            ws.Cell("N31").Value = "Veiculo de transporte:";
            ws.Cell("N33").Value = "       Placa n°_________";

            ws.Cell("A36").Value = "Responsável pelo Transporte:";
            ws.Cell("E36").Value = "Próprio";
            ws.Cell("D36").Value = "□";
            ws.Cell("E37").Value = "Contratado";
            ws.Cell("D37").Value = "□";
            ws.Cell("J36").Value = "Nome Completo:";
            ws.Cell("J37").Value = "Assinatura:";

            ws.Cell("A38").Value = "Liberações Envio / Data:";
            ws.Cell("E38").Value = "'" + Datalib;
            ws.Cell("A40").Value = "Gerente de TI";
            ws.Cell("A39").Value = "_________________________";
            ws.Cell("F40").Value = "Auxiliar Administrativo";
            ws.Cell("F39").Value = "_________________________";

            ws.Cell("L40").Value = Destinatario;
            ws.Cell("L39").Value = "_________________________";
            ws.Cell("O40").Value = Gestor;
            ws.Cell("O39").Value = "_________________________";
            #endregion

            #region Alinhamento
            ws.Cells("D1,D36,D37,K4,K5,J36,J37,O2,D33:D35,K33:K35").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
            ws.Cells("D6,L4,L5,A38").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
            ws.Cells("A6:L29,A39:R40,Q30").Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

            ws.Cells("A4,B4,K4:L5,A5,A36,A38").Style.Alignment.Vertical = XLAlignmentVerticalValues.Top;
            ws.Cells("F2,A39:R40,A6:R6").Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            #endregion

            #region Dimensionamento
            ws.Rows().Height = 13;
            ws.Rows("28,29,32").Height = 0;
            ws.Row(1).Height = 3;
            ws.Rows("4,5,6,37,39,40").Height = 20;
            ws.Row(36).Height = 25;
            ws.Rows("2,38").Height = 30;

            ws.Column(1).Width = 7.8;
            ws.Columns("3, 7, 8").Width = 0;
            ws.Columns(11, 12).Width = 10.5;
            #endregion

            #region Fonte
            ws.Cells("N31:N33").Style.Font.FontColor = XLColor.Red;
            ws.Cells("C2,O2,P2").Style.Font.FontSize = 16;
            ws.Cells("A40:R40,D33:D35,K33:K35").Style.Font.FontSize = 14;
            ws.Cells("B7:B26,M7:M26").Style.Font.FontSize = 9;
            ws.Cells("C2,O2,P2").Style.Font.Bold = true;
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
            Select(ws, "A40", "E40").Row(1).Merge();
            Select(ws, "F40", "K40").Row(1).Merge();
            Select(ws, "L40", "N40").Row(1).Merge();
            Select(ws, "O40", "R40").Row(1).Merge();

            Select(ws, "A39", "E39").Row(1).Merge();
            Select(ws, "F39", "K39").Row(1).Merge();
            Select(ws, "L39", "N39").Row(1).Merge();
            Select(ws, "O39", "R39").Row(1).Merge();

            Select(ws, "Q30", "R30").Row(1).Merge();

            Select(ws, "M30", "R30").Row(1).Merge();

            for (int i = 7; i < 29; i++)
            {
                Select(ws, $"B{i}", $"H{i}").Row(1).Merge();
                Select(ws, $"M{i}", $"R{i}").Row(1).Merge();
            }
            #endregion

            #region Formulas e Data Types

            ws.Cells("L30,K7:L26").Style.NumberFormat.Format = "R$ #,##0.00";

            #endregion
        }



    }
}
