namespace portal.Models.Output
{
    using portal.Models.Business;

    public class TaskGetOutputViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Frequency Frequency { get; set; }
    }
}
