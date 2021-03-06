#pragma checksum "C:\Users\Aiymkan\blazorserver02\Pages\TowersofHanoi.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b2154d40b9e33c30c2b38a41e5e3afa6f7a3cd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
