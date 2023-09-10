using interface_sugarcane_to_SAP.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace interface_sugarcane_to_SAP.Controllers
{

    [Route("api/getpostsql")]
    [ApiController]
    public class SugarcaneController:Controller
    {
        private readonly HttpContext _context;
        private ISelecttableRepository _data;
        //private readonly IHostingEnvironment _hostingEnvironment;
        public SugarcaneController(IHttpContextAccessor httpContextAccessor, ISelecttableRepository data)
        {
            //_hostingEnvironment = hostingEnvironment;
            _context = httpContextAccessor.HttpContext;
            _data = data;


        }
        [HttpGet]
        public IActionResult Show()
        {
            return View(_data.Loadgetpostsql());
      

        }




    }
}
