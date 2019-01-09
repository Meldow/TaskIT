namespace portal.Models.Repository
{
    public class Task : IDataModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Frequency Frequency { get; set; }
    }
}
