#pragma checksum "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "906130f0591e13f09e8dc5ee168eac2cc3355224"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_patches), @"mvc.1.0.view", @"/Views/Home/patches.cshtml")]
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
#nullable restore
#line 1 "C:\Users\FPCC\source\repos\Patches\Patches\Views\_ViewImports.cshtml"
using Patches;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\FPCC\source\repos\Patches\Patches\Views\_ViewImports.cshtml"
using Patches.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\FPCC\source\repos\Patches\Patches\Views\_ViewImports.cshtml"
using Patches.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"906130f0591e13f09e8dc5ee168eac2cc3355224", @"/Views/Home/patches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"990961b62ecabdbf2691166db10aaec653f38c1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_patches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OfficehHierarchyViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"card-deck\">\r\n    <h1 class=\"display-4\">AU For Medical Science</h1>\r\n    <p>\r\n        Patches\r\n    </p>\r\n    <div>\r\n        <div class=\"input-group\">\r\n            -->\r\n");
            WriteLiteral("            <center>\r\n                <input type=\"button\" class=\"btn btn-group\" value=\"إضافة جديد\"");
            BeginWriteAttribute("onclick", "\r\n                       onclick=\"", 510, "\"", 599, 3);
            WriteAttributeValue("", 544, "window.location.href=\'", 544, 22, true);
#nullable restore
#line 22 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
WriteAttributeValue("", 566, Url.Action("AddPatch", "Home" ), 566, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 598, "\'", 598, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n");
            WriteLiteral("            </center>\r\n\r\n        </div>\r\n\r\n        <!--<form method=\"get\">\r\n");
            WriteLiteral("    <!--<div class=\"input-group-append\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Search</button>\r\n            </div>\r\n\r\n        </div>\r\n    </form>-->\r\n");
            WriteLiteral("\r\n        <div style=\"font-family:Arial\">\r\n            <h2>Patches List</h2>\r\n            <center>\r\n                <p>\r\n");
#nullable restore
#line 44 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                     using (@Html.BeginForm("Index1", "Home", FormMethod.Get))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <b>Search By:</b>\r\n");
#nullable restore
#line 47 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.RadioButton("searchBy", "Building", true));

#line default
#line hidden
#nullable disable
            WriteLiteral("Building");
#nullable restore
#line 48 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.RadioButton("searchBy", "Patch"));

#line default
#line hidden
#nullable disable
            WriteLiteral("Patch");
            WriteLiteral("<br />\r\n");
#nullable restore
#line 49 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.TextBox("search"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"submit\" class=\"btn btn-primary\" value=\"search\" />\r\n");
#nullable restore
#line 50 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n            </center>\r\n            <table class=\"table\">\r\n                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 57 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.DisplayNameFor(model => model.patch.PatchNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 60 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.DisplayNameFor(model => model.patch.PatchSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 63 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.DisplayNameFor(model => model.patch.BoxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 66 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.DisplayNameFor(model => model.patch.Office.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 69 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.DisplayNameFor(model => model.patch.Office.OfficeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 72 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.DisplayNameFor(model => model.dept.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 75 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.DisplayNameFor(model => model.floor.FloorNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 78 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.DisplayNameFor(model => model.building.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 81 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                   Write(Html.DisplayNameFor(model => model.patch.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>Action</th>\r\n                </tr>\r\n");
#nullable restore
#line 85 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                 if (Model.Count() == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"4\">\r\n                            No records match search criteria\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 92 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                }
                else
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 99 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.DisplayFor(modelItem => item.patch.PatchNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 102 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.DisplayFor(modelItem => item.patch.PatchSlot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 105 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.DisplayFor(modelItem => item.patch.BoxNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 108 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.DisplayFor(modelItem => item.patch.Office.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 111 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.DisplayFor(modelItem => item.patch.Office.OfficeNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 114 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.DisplayFor(modelItem => item.dept.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 117 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.DisplayFor(modelItem => item.floor.FloorNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 120 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.DisplayFor(modelItem => item.building.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 123 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.DisplayFor(modelItem => item.patch.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 126 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.patch.Idpatches }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 127 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.patch.Idpatches }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 128 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.patch.Idpatches }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 131 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\r\n        </div>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 144 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
         if (Model == null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p><em>Not Found...</em></p>\r\n");
#nullable restore
#line 147 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <thead>
                    <tr>
                        <th>رقم الباتش</th>
                        <th>منفذ باتش</th>
                        <th>رقم البوكس</th>
                        <th>اسم المكتب</th>
                        <th>رقم المكتب</th>
                        <th>القسم</th>
                        <th>المنسوب</th>
                        <th>المبنى</th>
                        <th>ملاحظات</th>
                    </tr>
                </thead>
                <tbody>

");
#nullable restore
#line 166 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 169 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                           Write(item.patch.Idpatches);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 170 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                           Write(item.patch.PatchSlot);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 171 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                           Write(item.patch.BoxNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 172 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                           Write(item.patch.Office.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 173 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                           Write(item.patch.Office.Idoffice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 174 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                           Write(item.dept.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 175 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                           Write(item.floor.Idfloors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 176 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                           Write(item.building.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 177 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                           Write(item.patch.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 179 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
#nullable restore
#line 182 "C:\Users\FPCC\source\repos\Patches\Patches\Views\Home\patches.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OfficehHierarchyViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591