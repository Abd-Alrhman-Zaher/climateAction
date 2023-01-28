using climateAction.data;
using climateAction.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace climateAction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilitiesController : ControllerBase
    {
        IGeneric<Facilities> generic;
        public FacilitiesController(IGeneric<Facilities> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(Facilities answers)
        {
            generic.insert(answers);
        }
        [HttpGet]
        public List<Facilities> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public Facilities loadByid(int id)
        {
            return generic.loadId(id);
        }
        [HttpGet]
        [Route("delete")]
        public void delete(int id)
        {
            generic.Delete(id);
        }
        [HttpPost]
        [Route("update")]
        public void update(Facilities c)
        {
            generic.update(c);
        }
    }
}
