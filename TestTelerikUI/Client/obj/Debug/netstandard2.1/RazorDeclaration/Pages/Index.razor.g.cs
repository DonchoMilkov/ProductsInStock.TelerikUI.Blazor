#pragma checksum "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b14cc2e0e934acacc7586731700ae0bf1d63c0f2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestTelerikUI.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\_Imports.razor"
using TestTelerikUI.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\_Imports.razor"
using TestTelerikUI.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\Pages\Index.razor"
using TestTelerikUI.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\donch\source\repos\TestTelerikUI\TestTelerikUI\Client\Pages\Index.razor"
       

    public List<Product> GridData { get; set; }
    public Product ProductToEdit { get; set; }
    int PageSize = 15;
    int lastId = 0;

    protected override async Task OnInitializedAsync()
    {
        GridData = await Http.GetJsonAsync<List<Product>>("Product");
    }

    private void CreateHandler(GridCommandEventArgs args)
    {
        Product product = (Product)args.Item;

        product.ProductId = ++lastId;
        GridData.Insert(0, product);
    }

    private void DeleteHandler(GridCommandEventArgs args)
    {
        GridData.Remove((Product)args.Item);
    }

    private void UpdateHandler(GridCommandEventArgs args)
    {
        Product product = (Product)args.Item;

        var existing = GridData.FirstOrDefault(p => p.ProductId == product.ProductId);

        if (existing != null)
        {
            existing.ProductName = product.ProductName;
            existing.UnitPrice = product.UnitPrice;
            existing.UnitsInStock = product.UnitsInStock;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
