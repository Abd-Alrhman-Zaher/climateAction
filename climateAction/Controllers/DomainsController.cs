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
    public class DomainsController : ControllerBase
    {
        IGeneric<Domains> generic;
        public DomainsController(IGeneric<Domains> _generic)
        {
            generic = _generic;
        }
        [HttpPost]
        public void save(Domains domains)
        {
            generic.insert(domains);
        }
        [HttpGet]
        public List<Domains> load()
        {
            return generic.loadAll();
        }
        [HttpGet]
        [Route("getByid")]
        public Domains loadByid(int id)
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
        public void update(Domains d)
        {
            generic.update(d);
        }
    }
}
