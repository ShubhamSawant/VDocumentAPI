using System.Web;
using System.Web.Mvc;

namespace mock_survey_web_v_doc_api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
