using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RealEstate.Core.Assets;
using RealEstate.Infra;

namespace RealEstate.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : ControllerBase
    {
        private readonly ILogger<AssetController> _logger;
        private readonly IEntityLoader<Asset> _loader;

        public AssetController(ILogger<AssetController> logger, IEntityLoader<Asset> loader)
        {
            _logger = logger;
            _loader = loader;
        }

        [HttpGet]
        public IEnumerable<Asset> Get()
        {
            return _loader.LoadAll();
        }
    }
}
