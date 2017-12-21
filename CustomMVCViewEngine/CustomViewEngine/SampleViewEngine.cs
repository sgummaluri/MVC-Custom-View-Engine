using System.Web.Mvc;

namespace CustomMVCViewEngine.CustomViewEngine
{
    public class SampleViewEngine : IViewEngine
    {
        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string partialViewName, bool useCache)
        {
            throw new System.NotImplementedException();
        }

        public ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            if (viewName.Equals("CustomView"))
                return new ViewEngineResult(new CustomView(), this);
            else
                return new ViewEngineResult(new string[] { "Hello world!" });
        }

        public void ReleaseView(ControllerContext controllerContext, IView view)
        {

        }
    }
}