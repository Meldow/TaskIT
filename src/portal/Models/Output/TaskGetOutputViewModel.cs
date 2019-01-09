namespace portal.Models.Output
{
    using portal.Models.Business;

    public class TaskGetOutputViewModel : OutputViewModel
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Frequency Frequency { get; set; }
    }
}
