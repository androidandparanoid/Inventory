#pragma checksum "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f84105ce192e6ff97edf30a9a9c7a4cc88430fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Inventory.Pages.Warranty.Pages_Warranty_WarrantyDetails), @"mvc.1.0.razor-page", @"/Pages/Warranty/WarrantyDetails.cshtml")]
namespace Inventory.Pages.Warranty
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
#line 1 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\_ViewImports.cshtml"
using Inventory;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{searchQuery?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f84105ce192e6ff97edf30a9a9c7a4cc88430fd2", @"/Pages/Warranty/WarrantyDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc4c5ed31820425d5cf502ec8126d736b9edb9e9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Warranty_WarrantyDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./WarrantyInformation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
  
    ViewData["Title"] = "WarrantyDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""container"">
        <div class=""col-md alert alert-heading "">
            <div class=""row justify-content-center"">
                <h2 class=""my-1"">
                    <small><span class=""fas fa-edit text-primary""></span>&nbsp;Warranty Results for:</small>
                    ");
#nullable restore
#line 12 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
               Write(Model.SearchQuery);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </h2>\r\n            </div>\r\n        </div>\r\n        <br />\r\n        <div class=\"col-md\">\r\n\r\n");
#nullable restore
#line 20 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
             foreach (var warranty in Model.WarrantyInformation)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col-md\">\r\n                        <h5 class=\"my-1\">\r\n                            <small>Serial Number:</small>\r\n                            ");
#nullable restore
#line 26 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                       Write(warranty.AssetTag);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                        <h5 class=\"my-1\">\r\n                            <small>Model:</small>\r\n                            ");
#nullable restore
#line 30 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                       Write(warranty.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                        <h5 class=\"my-1\">\r\n                            <small>Model Family:</small>\r\n                            ");
#nullable restore
#line 34 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                       Write(warranty.ModelFamily);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                        <h5 class=\"my-1\">\r\n                            <small>Product ID:</small>\r\n                            ");
#nullable restore
#line 38 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                       Write(warranty.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                    </div>\r\n                    <div class=\"col-md\">\r\n                        <h5 class=\"my-1\">\r\n                            <small>Warranty Start Date:</small>\r\n                            ");
#nullable restore
#line 44 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                       Write(warranty.WarrantyStartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                        <h5 class=\"my-1\">\r\n                            <small>Warranty End Date</small>\r\n                            ");
#nullable restore
#line 48 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                       Write(warranty.WarrantyEndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                        <h5 class=\"my-1\">\r\n                            <small>Scan Date:</small>\r\n                            ");
#nullable restore
#line 52 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                       Write(warranty.ScanDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                        <h5");
            BeginWriteAttribute("class", " class=\"", 2097, "\"", 2702, 2);
            WriteAttributeValue("", 2105, "my-1", 2105, 4, true);
            WriteAttributeValue(" ", 2109, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#nullable restore
#line 54 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                                         switch (warranty.Status.ToString())
                                {
                                    case "VALID":

#line default
#line hidden
#nullable disable
                WriteLiteral(" text-success ");
#nullable restore
#line 56 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                                                                            
                                    break;
                                    case "WARNING": 

#line default
#line hidden
#nullable disable
                WriteLiteral(" text-warning ");
#nullable restore
#line 58 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                                                                               
                                    break;
                                    case "EXPIRED": 

#line default
#line hidden
#nullable disable
                WriteLiteral(" text-danger ");
#nullable restore
#line 60 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                                                                              
                                    break;
                                    default: 

#line default
#line hidden
#nullable disable
                WriteLiteral(" text-info ");
#nullable restore
#line 62 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                                                                     
                                    break;
                                }

#line default
#line hidden
#nullable disable
                PopWriter();
            }
            ), 2110, 592, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <small>Status:</small>\r\n                            ");
#nullable restore
#line 66 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"
                       Write(warranty.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h5>\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n");
#nullable restore
#line 71 "D:\Users\rperez\Box\ASP\DEVRepos\Inventory\Inventory.WebUI\Pages\Warranty\WarrantyDetails.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n            <br />\r\n            <div class=\"col-md\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f84105ce192e6ff97edf30a9a9c7a4cc88430fd211387", async() => {
                WriteLiteral("Warranty Information");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inventory.WebUI.Pages.Warranty.WarrantyDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inventory.WebUI.Pages.Warranty.WarrantyDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inventory.WebUI.Pages.Warranty.WarrantyDetailsModel>)PageContext?.ViewData;
        public Inventory.WebUI.Pages.Warranty.WarrantyDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591