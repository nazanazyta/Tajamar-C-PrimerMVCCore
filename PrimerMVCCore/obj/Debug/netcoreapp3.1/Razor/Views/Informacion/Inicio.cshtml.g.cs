#pragma checksum "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "183a7de6c09f861cdd81fc4d1397e75b02a8efbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Informacion_Inicio), @"mvc.1.0.view", @"/Views/Informacion/Inicio.cshtml")]
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
#line 1 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\_ViewImports.cshtml"
using PrimerMVCCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\_ViewImports.cshtml"
using PrimerMVCCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"183a7de6c09f861cdd81fc4d1397e75b02a8efbc", @"/Views/Informacion/Inicio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f61d98149400cbbfbd45cd38f4ece6ff526f8329", @"/Views/_ViewImports.cshtml")]
    public class Views_Informacion_Inicio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Persona>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\nDECLARACIÓN DE VARIABLES EN RAZOR:\r\n");
#nullable restore
#line 5 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
  
    int numero = 14;
    String texto = "Soy en texto en RAZOR";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:red\">\r\n    Su nombre es ");
#nullable restore
#line 11 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
            Write(ViewData["Nombre"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" y su edad es ");
#nullable restore
#line 11 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
                                             Write(ViewBag.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n\r\nDIBUJAR VARIABLES\r\n<h2 style=\"color:blue\">");
#nullable restore
#line 15 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
                  Write(texto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\nCÓDIGO LÓGICO\r\n");
#nullable restore
#line 18 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
 if (numero > 0)
{
    //CÓDIGO DE SERVIDOR
    //EN EL MOMENTO EN QUE INCLUIMOS CARATERES HTML
    //SE CORTA EL CÓDIGO LÓGICO Y EMPIEA EL DIBUJO

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Positivo ");
#nullable restore
#line 23 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
            Write(numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 24 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>Negativo ");
#nullable restore
#line 27 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
            Write(numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 28 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color: fuchsia\">\r\n    Mi Primera vista MVC\r\n</h1>\r\n\r\n");
            WriteLiteral("\r\n<h2 style=\"background-color: yellow; color: blue\">\r\n    Nombre: ");
#nullable restore
#line 37 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
       Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Edad: ");
#nullable restore
#line 37 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
                            Write(Model.Edad);

#line default
#line hidden
#nullable disable
            WriteLiteral(", Email: ");
#nullable restore
#line 37 "C:\Users\Nazaret\source\repos\PrimerMVCCore\PrimerMVCCore\Views\Informacion\Inicio.cshtml"
                                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Persona> Html { get; private set; }
    }
}
#pragma warning restore 1591