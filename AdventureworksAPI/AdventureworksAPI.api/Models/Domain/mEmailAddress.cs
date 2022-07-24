namespace AdventureworksAPI.api.Models.Domain
{
    public class mEmailAddress
    {
        public int BusinessEntityID { get; set; }
        public int EmailAddressID { get; set; }

        public string? EmailAddress { get; set; }

        public Guid rowguid { get; set; }

        public DateTime ModifiedDate { get; set; }



    }
}

