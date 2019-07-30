using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Repositories.System;

namespace Test1.Filters
{
    public class SystemDbAttribute :ActionFilterAttribute
    {
        private readonly SystemRepository systemRepository;

        public SystemDbAttribute(SystemRepository systemRepository) {
            this.systemRepository = systemRepository;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //context.HttpContext.User.Identity
        }

    }
}
