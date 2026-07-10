using Microsoft.AspNetCore.Mvc.Filters;
using System.IO;

namespace Lab3_CustomModel_Filter.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            File.WriteAllText("ErrorLog.txt", context.Exception.Message);

            context.ExceptionHandled = true;
        }
    }
}