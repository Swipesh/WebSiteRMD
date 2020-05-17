using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PluralsightASP.Areas.Identity.Pages.Account.Manage
{
    public static class ManageNavPages
    {
        public static string Index => "Index";

        public static string Email => "Email";

        public static string ChangePassword => "ChangePassword";
        public static string UsersManagement => "UsersManagement";
        public static string RolesManagement => "RolesManagement";
        public static string Files => "Files";
        


        public static string IndexNavClass(ViewContext viewContext) => PageNavClass(viewContext, Index);

        public static string EmailNavClass(ViewContext viewContext) => PageNavClass(viewContext, Email);

        public static string ChangePasswordNavClass(ViewContext viewContext) => PageNavClass(viewContext, ChangePassword);
        public static string UsersManagementNavClass(ViewContext viewContext) => PageNavClass(viewContext, UsersManagement);
        public static string RolesManagementNavClass(ViewContext viewContext) => PageNavClass(viewContext, RolesManagement);
        public static string FilesNavClass(ViewContext viewContext) => PageNavClass(viewContext, Files);

        //todo: Сделать работу с файлами
        

        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}
