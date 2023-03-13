namespace MarkNet.Core.Models.SystemLogs
{
    public class DatePagedParameter : DateRangedParameter
    {
        public int Offset { get; set; }
        public int Limit { get; set; }
    }
}
