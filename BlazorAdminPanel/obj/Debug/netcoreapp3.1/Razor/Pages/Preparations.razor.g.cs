#pragma checksum "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Pages\Preparations.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "514d9283154cb0f5c51e3c8591071803448d11b9"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAdminPanel.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using BlazorAdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using BlazorAdminPanel.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\_Imports.razor"
using BlazorAdminPanel.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Pages\Preparations.razor"
using BlazorAdminPanel.Shared.MyComponent;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/preparations")]
    public partial class Preparations : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container-fluid");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<div class=\"card shadow text-center mb-4\">\r\n        <h3 class=\"text-break mb-1 py-1\"><font color=\"#ff9933\"><b>Препараты</b></font></h3>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.AddMarkupContent(7, "\r\n\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-lg-6 col-xl-6");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenComponent<BlazorAdminPanel.Shared.MyComponent._Preparations>(11);
            __builder.AddAttribute(12, "Table", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAdminPanel.Models.Table>(
#nullable restore
#line 22 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Pages\Preparations.razor"
                                  preparationsTable

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "Title", "Заполниность ячеек данным препаратом");
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-lg-6 col-xl-6");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card shadow mb-4");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.AddMarkupContent(22, "<div class=\"card-header py-3\">\r\n                    <h6 class=\"text-secondary font-weight-bold m-0\">Таблица данных</h6>\r\n                </div>\r\n                ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "card-body");
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "table-responsive");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "table table-sm");
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.AddMarkupContent(32, @"<thead>
                                <tr>
                                    <th class=""text-left"">Название</th>
                                    <th class=""text-right"">Кол-во препарата</th>
                                </tr>
                            </thead>
                            ");
            __builder.OpenElement(33, "tbody");
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 40 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Pages\Preparations.razor"
                                 foreach (Row i in preparationsTable.Rows)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "                                    ");
            __builder.OpenElement(36, "tr");
            __builder.AddMarkupContent(37, "\r\n                                        ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 43 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Pages\Preparations.razor"
                                             i.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                                        ");
            __builder.OpenElement(41, "td");
            __builder.AddMarkupContent(42, "\r\n                                            ");
            __builder.OpenElement(43, "input");
            __builder.AddAttribute(44, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Pages\Preparations.razor"
                                                                                          () => preparationsTable.WritePS()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "rounded-0 border-0 form-control float-right text-success text-right");
            __builder.AddAttribute(46, "type", "text");
            __builder.AddAttribute(47, "maxlength", "12");
            __builder.AddAttribute(48, "minlength", "1");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Pages\Preparations.razor"
                                                                 i.NumCustomers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => i.NumCustomers = __value, i.NumCustomers));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n");
#nullable restore
#line 48 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Pages\Preparations.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Pages\Preparations.razor"
       


    // Асинхронная инициализация данных при загрузке данного компонента
    protected override async Task OnInitializedAsync()
    {
        await Task.Run(() => preparationsTable.Read());

        preparationsTable.UpdateEvent += UpdateDB;
    }


    public async void UpdateDB(object sender)
    {
        await InvokeAsync(() => StateHasChanged());
    }


    // Очистка перед удалением компонента
    public void Dispose()
    {

        preparationsTable.UpdateEvent -= UpdateDB;

        // throw new Exception("Удаление");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Models.PreparationsTable preparationsTable { get; set; }
    }
}
#pragma warning restore 1591
