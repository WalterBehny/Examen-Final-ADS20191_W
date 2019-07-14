namespace FinalADS.Application.Accounts.ViewModels
{
    public class AccountDto
    {
        public long id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Institucion { get; set; }
        public int Nroarticulos { get; set; }

        public AccountDto()
        {
        }
    }
}
