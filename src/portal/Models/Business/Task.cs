namespace portal.Models.Business
{
    public class Task : IBusinessModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Frequency Frequency { get; set; }
    }
}
