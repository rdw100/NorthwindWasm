#pragma checksum "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5b444d95884ca87a349c628c93f730cecabffd5"
// <auto-generated/>
#pragma warning disable 1591
namespace NorthwindWasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\_Imports.razor"
using NorthwindWasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\_Imports.razor"
using NorthwindWasm.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchcustomersdata")]
    public partial class FetchCustomersData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Northwind Customers</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching customer data from the server.</p>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
 if (customers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 11 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>ID</th>\r\n                <th>NAME</th>\r\n                <th>CONTACT</th>\r\n                <th>TITLE</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 24 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
             foreach (var customer in customers)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
                         customer.CustomerId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 28 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
                         customer.CompanyName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 29 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
                         customer.ContactName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 30 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
                         customer.ContactTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 32 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 35 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\ryand\source\repos\NorthwindWasm\NorthwindWasm\Pages\FetchCustomersData.razor"
       
    private Customer[] customers;

    protected override async Task OnInitializedAsync()
    {
        customers = await Http.GetFromJsonAsync<Customer[]>("sample-data/customers.json");
    }

    public class Customer
    {

        public string CustomerId { get; set; }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public string Fax { get; set; }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
