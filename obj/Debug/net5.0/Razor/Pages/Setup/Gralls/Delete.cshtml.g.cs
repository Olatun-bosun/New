#pragma checksum "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bffa31b1f9d2f3a34ba2e9b8161041924ca6422"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HRMSApplication.Pages.Setup.Gralls.Pages_Setup_Gralls_Delete), @"mvc.1.0.razor-page", @"/Pages/Setup/Gralls/Delete.cshtml")]
namespace HRMSApplication.Pages.Setup.Gralls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\_ViewImports.cshtml"
using HRMSApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Delete.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bffa31b1f9d2f3a34ba2e9b8161041924ca6422", @"/Pages/Setup/Gralls/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bba0893f36791b8953b3bf144a7917db44c7b5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Setup_Gralls_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Gralls\Delete.cshtml"
  
	string HID = Request.Query["HID"];


 try
    {
        string connectionString = "Data Source=LAPTOP-HTBOKT77;Initial Catalog=HRMS5DBBk;User ID=Arise;Password=2004Bos16..";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            //// delete the book image from /images/books/
            //string sqlSelect = "SELECT image_filename FROM books WHERE id=@id";
            //using (SqlCommand command = new SqlCommand(sqlSelect, connection))
            //{
            //    command.Parameters.AddWithValue("@id", id);
            //    using (SqlDataReader reader = command.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            string imageFileName = reader.GetString(0);
            //            string imageFolder = webHostEnvironment.WebRootPath + "/images/books/";
            //            string imageFullPath = System.IO.Path.Combine(imageFolder, imageFileName);
            //            System.IO.File.Delete(imageFullPath);
            //            Console.WriteLine("Delete Image " + imageFullPath);
            //        }
            //    }
            //}

            // delete the book from the database
            string sql = "DELETE FROM HPayAllowance WHERE HID=@HID";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@HID", HID);
                command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Response.Redirect("/Setup/Gralls/Index");

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Setup_Gralls_Delete> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Setup_Gralls_Delete> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Setup_Gralls_Delete>)PageContext?.ViewData;
        public Pages_Setup_Gralls_Delete Model => ViewData.Model;
    }
}
#pragma warning restore 1591
