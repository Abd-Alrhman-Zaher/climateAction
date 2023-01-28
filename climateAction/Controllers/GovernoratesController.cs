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
    public class GovernoratesController : ControllerBase
    {
        IGeneric<Governorates> generic;
        public GovernoratesController(IGeneric<Governorates> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(Governorates governorates)
        {
            generic.insert(governorates);
        }
        [HttpGet]
        public List<Governorates> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public Governorates loadByid(int id)
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
        public void update(Governorates c)
        {
            generic.update(c);
        }
    }
}
