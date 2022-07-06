using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberDinner.Api.Filter
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            var errorResult = new { error = "An error occured while processing your request." };

            context.Result = new ObjectResult(errorResult)
            {
                StatusCode = 500
            };

            context.ExceptionHandled = true;

        }
    }
}