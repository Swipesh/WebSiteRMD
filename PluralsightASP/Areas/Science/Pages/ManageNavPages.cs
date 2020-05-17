using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PluralsightASP.Areas.Science.Pages
{
    public static class ManageNavPages
    {
        public static string About => "About";

        public static string Participants => "Participants";

        public static string Materials => "Materials";
        /*public static string UsersManagement => "UsersManagement";
        public static string RolesManagement => "RolesManagement";
        public static string FilesUpload => "FilesUpload";*/
        


        public static string AboutNavClass(ViewContext viewContext) => PageNavClass(viewContext, About);

        public static string ParticipantsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Participants);

        public static string MaterialsNavClass(ViewContext viewContext) => PageNavClass(viewContext, Materials);
        /*public static string UsersManagementNavClass(ViewContext viewContext) => PageNavClass(viewContext, UsersManagement);
        public static string RolesManagementNavClass(ViewContext viewContext) => PageNavClass(viewContext, RolesManagement);
        public static string FilesUploadNavClass(ViewContext viewContext) => PageNavClass(viewContext, FilesUpload);*/

        //todo: Сделать работу с файлами
        

        private static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string
                ?? System.IO.Path.GetFileNameWithoutExtension(viewContext.ActionDescriptor.DisplayName);
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : null;
        }
    }
}
