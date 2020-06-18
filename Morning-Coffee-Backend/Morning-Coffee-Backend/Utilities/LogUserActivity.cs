using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Morning_Coffee_Backend.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Morning_Coffee_Backend.Data.Interfaces;

namespace Morning_Coffee_Backend.Utilities
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            var userId = int.Parse(resultContext.HttpContext.User
                .FindFirst(ClaimTypes.NameIdentifier).Value);

            var repo = resultContext.HttpContext.RequestServices.GetService<ICoffeeRepository>();

            var user = await repo.GetUser(userId, true);

            user.LastActive = DateTime.Now;

            await repo.SaveAll();
        }
    }
}

