using IFEN.CSharp.TestePratico.Data;
using Microsoft.AspNetCore.Mvc;

namespace IFEN.CSharp.TestePratico.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected internal IDataContext DataContext
        {
            get { return HttpContext.RequestServices.GetService<IDataContext>(); }
        }
    }
}
