#pragma checksum "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\CalculadoraComisiones\VerOperaciones.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81d5c995802f73e02f40dbae0369f2b718cb0bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalculadoraComisiones_VerOperaciones), @"mvc.1.0.view", @"/Views/CalculadoraComisiones/VerOperaciones.cshtml")]
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
#line 1 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\_ViewImports.cshtml"
using TPInvestigacion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\_ViewImports.cshtml"
using TPInvestigacion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81d5c995802f73e02f40dbae0369f2b718cb0bca", @"/Views/CalculadoraComisiones/VerOperaciones.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f27e352428b0a353aa474618be43e0ab30b7b1dc", @"/Views/_ViewImports.cshtml")]
    public class Views_CalculadoraComisiones_VerOperaciones : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entidades.Operacion>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\CalculadoraComisiones\VerOperaciones.cshtml"
  
    ViewBag.Title = "VerOperaciones";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>VerOperaciones</h2>\r\n<table>\r\n    <tr>\r\n        <td>IdComision</td>\r\n        <td>Capital</td>\r\n        <td>Plazo</td>\r\n        <td>Comision</td>\r\n        <td>=</td>\r\n        <td>Ganancia</td>\r\n    </tr>\r\n    \r\n");
#nullable restore
#line 17 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\CalculadoraComisiones\VerOperaciones.cshtml"
         foreach (var operacion in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 20 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\CalculadoraComisiones\VerOperaciones.cshtml"
       Write(operacion.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\CalculadoraComisiones\VerOperaciones.cshtml"
       Write(operacion.Capital);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\CalculadoraComisiones\VerOperaciones.cshtml"
       Write(operacion.Meses);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\CalculadoraComisiones\VerOperaciones.cshtml"
       Write(operacion.CalcularComision());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>=</td>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\CalculadoraComisiones\VerOperaciones.cshtml"
       Write(operacion.GananciaTotal());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 27 "C:\Users\julia\Desktop\UnitTestingAndICNetCore\TPInvestigacion\Views\CalculadoraComisiones\VerOperaciones.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entidades.Operacion>> Html { get; private set; }
    }
}
#pragma warning restore 1591
