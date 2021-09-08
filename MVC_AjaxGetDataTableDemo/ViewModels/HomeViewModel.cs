using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MVC_AjaxGetDataTableDemo.ViewModels
{
    /// <summary>
    /// Home View Model
    /// </summary>
    public class HomeViewModel
    {
        public string IsSuccess { get; set; }
        public DataTable Students { get; set; }
    }
}