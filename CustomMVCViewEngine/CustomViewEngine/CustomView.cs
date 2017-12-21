using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace CustomMVCViewEngine.CustomViewEngine
{
    public class CustomView : IView
    {
        public void Render(ViewContext viewContext, TextWriter textWriter)
        {
            // The viewContext object contains the information 
            // that is part of the model and to be displayed on the view
            var modelData = viewContext.ViewData.Model;

            // typecast the data to which ever format required.
            // an IEnumberable<T> type is being used for simplicity.
            var data = modelData as List<string>;

            // generate the html which is to be displayed on the view
            // we use the textWriter for this purpose.
            textWriter.Write("<table border=1><tr><th>Data</th></tr>");

            foreach(var item in data)
            {
                textWriter.Write("<tr><td>" + item + "</td></tr>");
            }

            textWriter.Write("</table>");
        }
    }
}