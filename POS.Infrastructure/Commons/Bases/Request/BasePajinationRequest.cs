namespace POS.Infrastructure.Commons.Bases.Request
{

    //Esto nos va servir para los litados de datos 
    public class BasePajinationRequest
    {
        public int NumPage { get; set; } = 1;

        public int NumRecordPage { get; set; } = 10;

        private readonly int NumMaxRecordPage = 50;

        public string Order { get; set; } = "asc";
        public string? Sort { get; set; } = null;

        public int Records
        {
            get => NumRecordPage;
            set
            {
                NumRecordPage = value > NumMaxRecordPage ? NumMaxRecordPage : value;
            }
        }
    }
}
