namespace DataLayer.Models
{
    public class Korisnik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Lozinka { get; set; }
        public string Tip { get; set; }
        public string BrTelefona { get; set; }
        public int VetID { get; set; }
    }
}
