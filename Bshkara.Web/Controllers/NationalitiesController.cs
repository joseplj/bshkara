﻿using System.Web.Mvc;
using Bshkara.Core.Entities;
using Bshkara.Core.Services;
using Bshkara.Web.Controllers.Bases;
using Bshkara.Web.Services;
using Bshkara.Web.ViewModels;

namespace Bshkara.Web.Controllers
{
    [Authorize]
    public class NationalitiesController :
        BaseCRUDController<NationalityEntity, NationalitiesViewModel, NationalitiesService>
    {
        public NationalitiesController(IUnitOfWork unitOfWork, NationalitiesService service)
            : base(unitOfWork, service)
        {
        }
    }
}