namespace ActionsAndModel.Models
{
    public class JobApplication
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public string Sex { get; set; }

        public string Experience { get; set; }
        public bool TermsAccepted { get; set; }
    }
}
