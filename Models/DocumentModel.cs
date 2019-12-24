namespace mock_survey_web_v_doc_api.Models
{
    public class DocumentModel : Status
    {
        public string documentId { get; set; }
        public string originalFileName { get; set; }
        public string originalFileExtension { get; set; }
        public int? uploadedBy { get; set; }
    }

    public class Status
    {
        public const string Completed = "Completed";
        public const string Failed = "Failed";
        public const string Uploading = "Uploading";
    }
}