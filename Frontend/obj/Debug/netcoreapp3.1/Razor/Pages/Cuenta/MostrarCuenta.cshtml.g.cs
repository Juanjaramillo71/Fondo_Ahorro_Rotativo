#pragma checksum "D:\Proyectos VSC\Proyectos Secundarios\Fondo_Ahorro_App\frontend\Pages\Cuenta\MostrarCuenta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "282111636d6c7d601e85b37d885523eb9f7ada1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Frontend.Pages.Cuenta.Pages_Cuenta_MostrarCuenta), @"mvc.1.0.razor-page", @"/Pages/Cuenta/MostrarCuenta.cshtml")]
namespace Frontend.Pages.Cuenta
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
#line 1 "D:\Proyectos VSC\Proyectos Secundarios\Fondo_Ahorro_App\frontend\Pages\_ViewImports.cshtml"
using Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282111636d6c7d601e85b37d885523eb9f7ada1b", @"/Pages/Cuenta/MostrarCuenta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1864ae33000be3f3b251118b425f84120520c9fe", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Cuenta_MostrarCuenta : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Cliente/CrearCliente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"justify-content-center text-center\">\r\n    <h1> Tu Cuenta Fidalia</h1>\r\n    <br>\r\n</div>\r\n<div>\r\n\r\n<div class=\"container\">\r\n  <div class=\"card\" style=\"width: 300px; margin: 20px auto;\">\r\n    <div class=\"card-header\">\r\n      <h1>");
#nullable restore
#line 15 "D:\Proyectos VSC\Proyectos Secundarios\Fondo_Ahorro_App\frontend\Pages\Cuenta\MostrarCuenta.cshtml"
     Write(Model.Cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n    </div>\r\n    <div class=\"card-body\">        \r\n      <table class=\"table\">\r\n        <tr>\r\n          <td height=\"10px\"> CuentaId</td>\r\n          <td>");
#nullable restore
#line 21 "D:\Proyectos VSC\Proyectos Secundarios\Fondo_Ahorro_App\frontend\Pages\Cuenta\MostrarCuenta.cshtml"
         Write(Model.Cliente.Cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>
        <tr>
          <td height=""10px"">Titular</td>
          <td> 0 </td>
        </tr>
        <tr>
          <td height=""10px"">Ahorro</td>
          <td> 0 </td>
        </tr>
        <tr>
          <td height=""10px"">Intereses</td>
          <td>$ 0</td>
        </tr>
        <tr>
          <td height=""10px"">Saldo Total</td>
          <td>$ 0</td>
        </tr>
      </table>
    </div>
  </div>
</div>
</div>
<div class=""justify-content-center text-center"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "282111636d6c7d601e85b37d885523eb9f7ada1b4785", async() => {
                WriteLiteral("Regalizar Pago");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Frontend.Pages.MostrarCuentaModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.MostrarCuentaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Frontend.Pages.MostrarCuentaModel>)PageContext?.ViewData;
        public Frontend.Pages.MostrarCuentaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
