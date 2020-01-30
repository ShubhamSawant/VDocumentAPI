using mock_survey_web_v_doc_api.Models;
using System;
using System.Net;
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

        [Route("api/Document/GetDoc/{documentId}")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetDocumentByID(string documentId)
        {
            try
            {
                if (documentId != null)
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync("https://gh52mhpfue.execute-api.us-east-1.amazonaws.com/Prod/documents/" + documentId);
                        return response;
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "error while Vdoc Api");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPost]
        public async Task<HttpResponseMessage> PostDocument(PostDocModel postReq)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.PostAsJsonAsync("https://gh52mhpfue.execute-api.us-east-1.amazonaws.com/Prod/documents", postReq);
                    return response;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpPut]
        public async Task<string> PutDucument(PutDocModel putReq)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    {
                        var response = await client.PutAsJsonAsync(putReq.PreSignedURL, "sdk");
                        var resultResponse = response.StatusCode.ToString();
                        return resultResponse;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [Route("api/Document/DeleteDoc/{documentId}")]
        [HttpDelete]
        public async Task<HttpResponseMessage> DeleteDocument(string documentId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    {
                        var response = await client.DeleteAsync("https://gh52mhpfue.execute-api.us-east-1.amazonaws.com/Prod/documents/" + documentId);

                        return response;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            };

        }

        [Route("api/Document/GetAllDocs")]
        [HttpGet]
        public async Task<HttpResponseMessage> GetAllDocsByParentRecId([FromUri]string parentRecordId)
        {
            try
            {
                if (parentRecordId != null)
                {
                    using (var client = new HttpClient())
                    {
                        var response = await client.GetAsync("https://gh52mhpfue.execute-api.us-east-1.amazonaws.com/Prod/documents?parentRecordId=" + parentRecordId);
                        return response;
                    }
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "error while Vdoc Api");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
