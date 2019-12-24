using mock_survey_web_v_doc_api.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace mock_survey_web_v_doc_api.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class DocumentController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GetDocument()
        {
            return null;
        }

        [HttpGet]
        public IHttpActionResult GetDocumentByID(int documentId)
        {
            try
            {
                if (Convert.ToBoolean(documentId))
                {
                    return null;
                }
                else
                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostDocument()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    PostDocModel postDoc = new PostDocModel
                    {
                        DocumentId = "sdfdg",
                        OriginalFileName = "dsfsdg",
                        OriginalFileExtension = "pdf",
                        UploadedBy = 10,
                        AssessmentId = "assessment-101010",
                        ChapterId = "EP-101",
                    };
                    //var request = client.GetAsync("https://bngeg46vkf.execute-api.us-east-1.amazonaws.com/Prod/documents");
                    //var content = new StringContent(postDoc.ToString(), Encoding.UTF8, "application/json");
                    var response = await client.PostAsJsonAsync("https://bngeg46vkf.execute-api.us-east-1.amazonaws.com/Prod/documents", postDoc);
                    return response;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public async Task<HttpResponseMessage> PutDucument()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    {
                        PutDocModel putDoc = new PutDocModel
                        {
                            PreSignedURL = "https://vdocument-ad-test-stage.s3.amazonaws.com/2019/12/02/f753a075-7e5b-4f9b-a55d-8e8112fcf54d?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=ASIAWD2F5YAJSXZR6WR2%2F20191224%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20191224T084843Z&X-Amz-Expires=300&X-Amz-Security-Token=IQoJb3JpZ2luX2VjENn%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaCXVzLWVhc3QtMSJHMEUCIQClMOrhWmt3CHlsEDkBDMlcXPAH0Us5FKqA4DcmDMGQ9QIgckPenKZXeKUn1Rlzl6NCspePQ7ziYAs4o%2FxzNNT%2F6qMq7gEIQhACGgw0MjA1MTY1NzcyOTkiDIqQk9eRhfX7j%2FmvUirLAecUUXfTii9ihqBFtK1YBmJ%2Fku44T0sQeZIzjYXUPWoSaqX6P7ZV4DnqXGexPiF9C7m3SKv%2FujM27VL4gKwoLM0zKLLwDmlyFtxt%2BJAyRhcBkPp9ptTWLDkmalhmAJWJ2Nd%2BTYhhppDaZe3XSHREYpZogg59u6s9gPpjxsqvtenrDXpVfU65RnXFMvf8P6Ml1tB7kJ39JLigz8gZ908A1XfE%2B6jE08GsA%2BHH1t4LvBxC4dYgs%2FWPH%2BulcfKWmC11GaSZRG%2FvSzNUSBn%2FMKmah%2FAFOuABHvqlcwfmOQrE%2BeSrvl8tsgA9cGNoOnOhMTZJzK4tvcYXRsk%2FF32HgpjAyJRDwkY%2BlHeUescd9S5p6wqIGp%2FpcfpGfWfAJu2qXXR3UbFXYIDsQ6gvWzZ1e9n5xwaAMP4eA%2ByUaXayWOtWMl1g3IW3CK3c%2FViBG1vAOpHOoTWmeSIifmea4GiBtrFpR%2BXanZ7%2BXIwJNRRVHXJGqeOLSeiJzs9qqcnPRefv%2FFYn%2B%2B9wFroLrAR68e7yXmQge%2B8s3O236w5ZFpnkxzmKoB3xDl%2BwCHdjSPeJPF3656okdwXjsKk%3D&X-Amz-Signature=01b573b97b644fea6a05bc69665d5f35d813dd776e51697dadb378395034d383&X-Amz-SignedHeaders=host",
                            RequestId = "e93d4556-19fa-4ebc-af38-6b2dd46d77e3",
                        };
                        var response = await client.PutAsJsonAsync(putDoc.PreSignedURL, "dgthg");
                        return response;
                    }
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
