// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorCRUDEFCodeFirst.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using BlazorCRUDEFCodeFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using BlazorCRUDEFCodeFirst.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\_Imports.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookDetails")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/bookDetails/{id:int}")]
    public partial class BookDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\gonza\source\repos\BlazorCRUDEFCodeFirst\BlazorCRUDEFCodeFirst\Pages\BookDetails.razor"
       
    [Parameter]
    public int id { get; set; }

    private Book book = new Book();

    protected override async Task OnInitializedAsync()
    {
        if (id != 0)
        {
            book = await BookService.GetBookDetails(id);
        }
    }

    protected async Task SaveBook()
    {
        await BookService.SaveBook(book);
        NavigationManager.NavigateTo("/");
    }

    protected void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBookService BookService { get; set; }
    }
}
#pragma warning restore 1591