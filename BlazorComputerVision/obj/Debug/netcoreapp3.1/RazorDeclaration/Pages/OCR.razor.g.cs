#pragma checksum "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "324ae7ffc96047dedb1638f4f490e5f34c606639"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorComputerVision.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using BlazorComputerVision;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using BlazorComputerVision.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
using BlazorComputerVision.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/computer-vision-ocr")]
    public partial class OCR : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\ankit\source\repos\BlazorComputerVision\BlazorComputerVision\Pages\OCR.razor"
       
    string imagePreview;
    string textData;
    bool loading = false;
    byte[] imageFileBytes;
    const string status = "Max image size allowed is 5 MB";

    async Task ViewFile(IFileListEntry[] files)
    {
        var file = files.FirstOrDefault();
        if (file == null)
        {
            return;
        }
        else
        {
            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);
            imageFileBytes = memoryStream.ToArray();
            string base64String = Convert.ToBase64String(imageFileBytes, 0, imageFileBytes.Length);

            imagePreview = string.Concat("data:image/png;base64,", base64String);
            memoryStream.Flush();
        }
    }

    private async Task GetText()
    {
        loading = true;
        textData = await computerVisionService.GetTextFromImage(imageFileBytes);
        loading = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ComputerVisionService computerVisionService { get; set; }
    }
}
#pragma warning restore 1591
