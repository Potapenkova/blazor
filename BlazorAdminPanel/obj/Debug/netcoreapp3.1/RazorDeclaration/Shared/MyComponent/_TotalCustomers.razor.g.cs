// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAdminPanel.Shared.MyComponent
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
    public partial class _TotalCustomers : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\User\Desktop\Diplom\BlazorAdminPanel\BlazorAdminPanel\Shared\MyComponent\_TotalCustomers.razor"
       
    [Parameter]
    public Models.EarningsTable earningsTable { get; set; }


    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            earningsTable.UpdateEvent += UpdateDB;
        }
    }


    public async void UpdateDB(object sender)
    {
        // Обновление компонента после посчета итогов.
        await InvokeAsync(() => StateHasChanged());
    }


    // Очистка перед удалением компонента
    public void Dispose()
    {
        earningsTable.UpdateEvent -= UpdateDB;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
