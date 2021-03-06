#pragma checksum "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b2154d40b9e33c30c2b38a41e5e3afa6f7a3cd"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver02.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Aiymkan\blazorserver02\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aiymkan\blazorserver02\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Aiymkan\blazorserver02\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Aiymkan\blazorserver02\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Aiymkan\blazorserver02\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Aiymkan\blazorserver02\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Aiymkan\blazorserver02\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Aiymkan\blazorserver02\_Imports.razor"
using blazorserver02;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Aiymkan\blazorserver02\_Imports.razor"
using blazorserver02.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/towersOfHanoi")]
    public partial class TowersofHanoi : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Towers of Hanoi</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "svg");
            __builder.AddAttribute(4, "height", "210");
            __builder.AddAttribute(5, "width", "500");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "line");
            __builder.AddAttribute(8, "x1", "30");
            __builder.AddAttribute(9, "y1", "0");
            __builder.AddAttribute(10, "x2", "30");
            __builder.AddAttribute(11, "y2", "150");
            __builder.AddAttribute(12, "stroke-width", "15");
            __builder.AddAttribute(13, "stroke", 
#nullable restore
#line 9 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                    color1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                                     (() => TowerClick("towerA"))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "line");
            __builder.AddAttribute(17, "x1", "0");
            __builder.AddAttribute(18, "y1", "150");
            __builder.AddAttribute(19, "x2", "60");
            __builder.AddAttribute(20, "y2", "150");
            __builder.AddAttribute(21, "stroke-width", "15");
            __builder.AddAttribute(22, "stroke", 
#nullable restore
#line 11 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                    color1

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                                     (() => TowerClick("towerA"))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(24, ">\r\n\r\n        ");
            __builder.OpenElement(25, "svg");
            __builder.AddAttribute(26, "height", "210");
            __builder.AddAttribute(27, "width", "500");
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "line");
            __builder.AddAttribute(30, "x1", "130");
            __builder.AddAttribute(31, "y1", "0");
            __builder.AddAttribute(32, "x2", "130");
            __builder.AddAttribute(33, "y2", "150");
            __builder.AddAttribute(34, "stroke-width", "15");
            __builder.AddAttribute(35, "stroke", 
#nullable restore
#line 15 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                        color2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                                         (() => TowerClick("towerB"))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "line");
            __builder.AddAttribute(39, "x1", "100");
            __builder.AddAttribute(40, "y1", "150");
            __builder.AddAttribute(41, "x2", "160");
            __builder.AddAttribute(42, "y2", "150");
            __builder.AddAttribute(43, "stroke-width", "15");
            __builder.AddAttribute(44, "stroke", 
#nullable restore
#line 17 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                        color2

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                                         (() => TowerClick("towerB"))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n        ");
            __builder.OpenElement(48, "svg");
            __builder.AddAttribute(49, "height", "210");
            __builder.AddAttribute(50, "width", "500");
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "line");
            __builder.AddAttribute(53, "x1", "230");
            __builder.AddAttribute(54, "y1", "0");
            __builder.AddAttribute(55, "x2", "230");
            __builder.AddAttribute(56, "y2", "150");
            __builder.AddAttribute(57, "stroke-width", "15");
            __builder.AddAttribute(58, "stroke", 
#nullable restore
#line 22 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                        color3

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                                         (() => TowerClick("towerC"))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "line");
            __builder.AddAttribute(62, "x1", "200");
            __builder.AddAttribute(63, "y1", "150");
            __builder.AddAttribute(64, "x2", "260");
            __builder.AddAttribute(65, "y2", "150");
            __builder.AddAttribute(66, "stroke-width", "15");
            __builder.AddAttribute(67, "stroke", 
#nullable restore
#line 24 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                        color3

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                                         (() => TowerClick("towerC"))

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.OpenElement(72, "submit");
            __builder.AddAttribute(73, "class", "btn btn-success");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                                              (()=>InitialState())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "1");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    ");
            __builder.OpenElement(77, "submit");
            __builder.AddAttribute(78, "class", "btn btn-success");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
                                              (()=>AfterActionTower())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(80, "2");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor"
       
    private static string newColor = "#007bff";
    private static string defaultColor = "#000000";
    private string color1 = defaultColor, color2 = defaultColor, color3 = defaultColor;
    private static HanoiGame h = new HanoiGame();
    private static HanoiTower t = new HanoiTower(h);
    private void TowerClick(string tower)
    {
        color1 = defaultColor;
        color2 = defaultColor;
        color3 = defaultColor;

        if(tower == "towerA") {
            color1 = newColor;
        }
        else if(tower == "towerB") {
            color2 = newColor;
        }
        else if (tower == "towerC") {
            color3 = newColor;
        }
    }
    private void InitialState()
    {
        h = new HanoiGame();
        t = new HanoiTower(h);
        h.addTower(t);
        t.pushDisk(new HanoiDisk(6,"orange"));
        t.pushDisk(new HanoiDisk(4,"blue"));
        t.pushDisk(new HanoiDisk(2,"yellow"));
        h.addTower(new HanoiTower(h));
        h.addTower(new HanoiTower(h));
        h.toConsole();
    }
    private void AfterActionTower()
    {
        h.getTower(1).pushDisk(h.getTower(0).popDisk());
        h.getTower(2).pushDisk(h.getTower(0).popDisk());
        h.toConsole();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
