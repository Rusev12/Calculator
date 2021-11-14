using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalaryCalculator.Controllers
{
    public class DateRangeFilterAttribute : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
           
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            
        }
    }
}