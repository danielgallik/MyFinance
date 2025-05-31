namespace MyFinance.Models
{
    public class SankeyDataModel
    {
        public string[] NodeLabels { get; set; }
        public string[] NodeColors { get; set; }
        public int[] LinkSource { get; set; }
        public int[] LinkTarget { get; set; }
        public int[] LinkValue { get; set; }
    }
}