#pragma checksum "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Steps\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b10011f443a4d9506aee0eaae25ab524b26b475a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HRMSApplication.Pages.Setup.Steps.Pages_Setup_Steps_Delete), @"mvc.1.0.razor-page", @"/Pages/Setup/Steps/Delete.cshtml")]
namespace HRMSApplication.Pages.Setup.Steps
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
#line 2 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Steps\Delete.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b10011f443a4d9506aee0eaae25ab524b26b475a", @"/Pages/Setup/Steps/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17bba0893f36791b8953b3bf144a7917db44c7b5", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Setup_Steps_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Arise Olatunbosun\Desktop\HRMSApplication\Pages\Setup\Steps\Delete.cshtml"
  
	string ID = Request.Query["ID"];


 try
    {
        string connectionString = "Data Source=LAPTOP-HTBOKT77;Initial Catalog=HRMS5DBBk;User ID=Arise;Password=2004Bos16..";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string sql = "DELETE FROM HRSteps WHERE ID=@ID";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@ID", ID);
                command.ExecuteNonQuery();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

    Response.Redirect("/Setup/Steps/Index");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n}\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Setup_Steps_Delete> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Setup_Steps_Delete> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Setup_Steps_Delete>)PageContext?.ViewData;
        public Pages_Setup_Steps_Delete Model => ViewData.Model;
    }
}
#pragma warning restore 1591
