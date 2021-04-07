using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace VeterinarskaRadnjaWeb
{
    public partial class MainPage : System.Web.UI.Page
    {
        private List<DataLayer.Models.KorisnikLjubimac> listaKorisnikLjubimac;
        protected void Page_Load(object sender, EventArgs e)
        {
            listaKorisnikLjubimac = new List<DataLayer.Models.KorisnikLjubimac>();
            initTable();
        }
        private void initTable()
        {
            tableResult.Rows.Clear();
            TableHeaderRow thr = new TableHeaderRow();
            TableHeaderCell thIme = new TableHeaderCell();
            TableHeaderCell thPrezime = new TableHeaderCell();
            TableHeaderCell thLjubimac = new TableHeaderCell();
            thIme.Text = "Ime";
            thr.Cells.Add(thIme);
            thPrezime.Text = "Prezime";
            thr.Cells.Add(thPrezime);
            thLjubimac.Text = "Ime Ljubimca";
            thr.Cells.Add(thLjubimac);
            tableResult.Rows.Add(thr);
        }
        protected void btnPretrazi_Click(object sender, EventArgs e)
        {
            initTable();
            foreach (var i in DataLayer.DbManager.getInstance()
                .getKorisnikLjubimac(txtSearch.Text, cbImeKorisnika.Checked, cbPrezimeKorisnika.Checked, cbNazivLjubimca.Checked))
            {
                TableRow tableRow = new TableRow();
                TableCell tableCellIme = new TableCell();
                TableCell tableCellPrezime = new TableCell();
                TableCell tableCellLjubimac = new TableCell();
                tableCellIme.Text = i.Ime;
                tableRow.Cells.Add(tableCellIme);
                tableCellPrezime.Text = i.Prezime;
                tableRow.Cells.Add(tableCellPrezime);
                tableCellLjubimac.Text = i.Ljubimac;
                tableRow.Cells.Add(tableCellLjubimac);
                tableResult.Rows.Add(tableRow);
            }
        }
    }
}