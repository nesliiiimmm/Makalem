#pragma checksum "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "636351fa501094d142015e3a1c95e8ed1409c02d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\_ViewImports.cshtml"
using Makalem;

#line default
#line hidden
#line 2 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\_ViewImports.cshtml"
using Makalem.Models;

#line default
#line hidden
#line 1 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
using Makalem.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"636351fa501094d142015e3a1c95e8ed1409c02d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2977efaf0c374908c4f72cb10eeb94392950b40d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IEnumerable<Kategori>, IEnumerable<Makale>,IEnumerable<MakaleKategori>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/portfolio/image-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info pg2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(114, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(161, 387, true);
            WriteLiteral(@"
<!-- Jumbotron Section Start -->
<section class=""jumbotron"">
    <div class=""container"">
        <!-- Row Start -->
        <div class=""row"">
            <div class=""col-md-12 inner-contant"" data-aos=""zoom-in"" data-aos-duration=""500"">
                <h1>Hello! we are YCNB</h1>
                <h3>Article System</h3>
                <p>Read & Write Articles... </p><br />

");
            EndContext();
#line 18 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                 using (Html.BeginForm())
                {

#line default
#line hidden
            BeginContext(610, 860, true);
            WriteLiteral(@"                    <center>
                        <div class=""col-sm-12"">
                            <div id=""custom-search-input"">
                                <div class=""input-group col-sm-12"">
                                    <input type=""text"" class=""form-control input-lg"" placeholder=""Makale Ara..."" name=""searchstring"" />
                                    <span class=""input-group-btn"">
                                        <button class=""btn btn-success btn-lg "" type=""submit"">
                                            <i class=""glyphicon glyphicon-search""></i>
                                        </button>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </center>
                    <br />
");
            EndContext();
#line 35 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1489, 467, true);
            WriteLiteral(@"
            </div>
        </div>
        <!-- Row Ended -->
    </div>
</section>
<!-- Jumbotron Section Ended -->
<!-- Portfolio Section Start -->

<section class=""portfolio"">
    <!-- Container-fluid Start -->
    <div class=""container-fluid"">
        <div class=""row"" style=""z-index: 999; position: relative; margin-top: -107px;padding-bottom: 60px;"">
            <button class=""active btn btn-default filter-button"" data-filter=""all"">All</button>
");
            EndContext();
#line 50 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
             foreach (var kategori in Model.Item1)
            {

#line default
#line hidden
            BeginContext(2023, 74, true);
            WriteLiteral("                <button class=\"btn btn-default filter-button\" data-filter=");
            EndContext();
            BeginContext(2098, 11, false);
#line 52 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                                                                     Write(kategori.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2109, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2111, 12, false);
#line 52 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                                                                                  Write(kategori.Adi);

#line default
#line hidden
            EndContext();
            BeginContext(2123, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 53 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2149, 176, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <!-- Row Start -->\r\n        <div class=\"row\">\r\n            <!-- Main_portfolio_content Start -->\r\n            <div class=\"main_portfolio_content\">\r\n");
            EndContext();
#line 61 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                 foreach (var makale in Model.Item2)
                {
                    

#line default
#line hidden
#line 63 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                     if(makale.DurumTipi  != false){
                  

#line default
#line hidden
            BeginContext(2472, 24, true);
            WriteLiteral("                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2496, "\"", 2624, 8);
            WriteAttributeValue("", 2504, "gallery_product", 2504, 15, true);
            WriteAttributeValue(" ", 2519, "col-md-3", 2520, 9, true);
            WriteAttributeValue(" ", 2528, "col-sm-4", 2529, 9, true);
            WriteAttributeValue(" ", 2537, "col-xs-6", 2538, 9, true);
            WriteAttributeValue(" ", 2546, "filter", 2547, 7, true);
#line 65 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 2553, Model.Item3.FirstOrDefault(x=>x.MakaleId == makale.Id), 2554, 57, false);

#line default
#line hidden
            WriteAttributeValue("", 2611, ".KategoriId", 2611, 11, true);
            WriteAttributeValue("  ", 2622, "", 2624, 2, true);
            EndWriteAttribute();
            BeginContext(2625, 62, true);
            WriteLiteral(">\r\n                        <div>\r\n                            ");
            EndContext();
            BeginContext(2687, 710, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3edb16e35774145b9c6ce4322497175", async() => {
                BeginContext(2763, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2797, 81, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bf497906d20848378fa4d813c90e6bbb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2878, 266, true);
                WriteLiteral(@"
                                <div class=""portfolio_images_overlay text-center"">
                                    <h6>
                                        <br>
                                        <span>
                                            ");
                EndContext();
                BeginContext(3145, 13, false);
#line 73 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                                       Write(makale.Baslik);

#line default
#line hidden
                EndContext();
                BeginContext(3158, 235, true);
                WriteLiteral(" - <i class=\"fa fa-comment\" aria-hidden=\"true\" style=\"color: white;\"></i>\r\n                                        </span>\r\n                                    </h6>\r\n                                </div>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                                                                                WriteLiteral(makale.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3397, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 80 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#line 80 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                     
                }

#line default
#line hidden
            BeginContext(3501, 88, true);
            WriteLiteral("                <p style=\"font-size:40px; color:white; text-align:center;\"><br /><br /> ");
            EndContext();
            BeginContext(3590, 18, false);
#line 82 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                                                                                   Write(ViewData["search"]);

#line default
#line hidden
            EndContext();
            BeginContext(3608, 379, true);
            WriteLiteral(@"<br /><br /></p>
            </div>
            <!-- Main_portfolio_content Ended -->
        </div>
        <!-- Row Ended -->
    </div>
    <!-- Container-fluid Ended -->
</section>
<!-- Portfolio Section Ended -->
<!-- Contact Section Start -->
<section id=""services"">
    <!-- Container Start -->
    <div class=""container"">

        <!-- First Row Start -->
");
            EndContext();
            BeginContext(4484, 494, true);
            WriteLiteral(@"        <!-- First Row Ended -->
        <!-- Second Row Start -->
        <div class=""row service-2"">
            <div class=""col-md-12"" data-aos=""fade-up"" data-aos-duration=""500"">
                <h2>Hangi Alanda Araştırma yapmak istiyorsunuz ?</h2>
                <p>Birçok alanda Makaleler araştırılmak için sizi bekliyorr..</p>
            </div>
        </div>
        <!-- Second Row Ended -->

        <div class=""service-3"" data-aos=""fade-right"" data-aos-duration=""500"">

");
            EndContext();
#line 118 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
             foreach (var item in Model.Item1)
            {

#line default
#line hidden
            BeginContext(5041, 226, true);
            WriteLiteral("                <div class=\"col-xs-12 col-sm-4 col-md-4\">\r\n                    <div class=\"col-1\">\r\n                        <span class=\"icon\"><i class=\"fa fa-check\" aria-hidden=\"true\"></i></span>\r\n                        <h5>");
            EndContext();
            BeginContext(5268, 8, false);
#line 123 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                       Write(item.Adi);

#line default
#line hidden
            EndContext();
            BeginContext(5276, 59, true);
            WriteLiteral("</h5>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 126 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(5350, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(8625, 39, true);
            WriteLiteral("\r\n            <!-- Third Row Ended-->\r\n");
            EndContext();
            BeginContext(8688, 363, true);
            WriteLiteral(@"        </div>
        <!-- Container Ended -->
</section>
<!-- Contact Section Ended -->
<!-- Blog Section Start -->
<section id=""blog"">
    <div class=""container"">
        <h3 class=""margin"" data-aos=""fade-up"" data-aos-duration=""500"">Son Eklenen makalelere bir göz atınn...</h3><br>
        <div class=""row"" style=""margin-bottom: 97px;"">
            
");
            EndContext();
#line 204 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                 for (int i = 0; i < 3; i++)
                {

#line default
#line hidden
            BeginContext(9116, 187, true);
            WriteLiteral("                    <div class=\"col-xs-12 col-sm-12 col-md-4\">\r\n                        <div class=\"post1\" data-aos=\"zoom-in-right\" data-aos-duration=\"1000\">\r\n                            ");
            EndContext();
            BeginContext(9303, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "526f99a7f2b44f46ad2dd35ff0925cc6", async() => {
                BeginContext(9459, 53, false);
#line 208 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                                                                                                                                                                                  Write(Model.Item2.ElementAt(Model.Item2.Count()-i-1).Baslik);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 208 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"
                                                                                WriteLiteral(Model.Item2.ElementAt(Model.Item2.Count()-i-1).Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9516, 130, true);
            WriteLiteral("\r\n                            <a href=\"blog-page.html\"><h2></h2></a>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 212 "C:\Users\Neslihan Ak\Desktop\PROJECT\Makalem\Makalem\Views\Home\Index.cshtml"

                }

#line default
#line hidden
            BeginContext(9667, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(10969, 67, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!-- Blog Section Ended -->");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IEnumerable<Kategori>, IEnumerable<Makale>,IEnumerable<MakaleKategori>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
