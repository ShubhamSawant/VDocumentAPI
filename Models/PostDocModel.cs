namespace mock_survey_web_v_doc_api.Models
{
    public class PostDocModel
    {
        public string DocumentId { get; set; }
        public string OriginalFileName { get; set; }
        public string OriginalFileExtension { get; set; }
        public int? UploadedBy { get; set; }
        public string AssessmentId { get; set; }
        public string ChapterId { get; set; }
    }
}