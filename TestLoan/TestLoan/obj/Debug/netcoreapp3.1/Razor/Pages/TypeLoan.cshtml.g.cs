#pragma checksum "C:\Users\Palmpich\Documents\GitHub\DiisLoan\TestLoan\TestLoan\Pages\TypeLoan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b266a0bf092da0bf585fb68ec3927c56b3bd2b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestLoan.Pages.Pages_TypeLoan), @"mvc.1.0.razor-page", @"/Pages/TypeLoan.cshtml")]
namespace TestLoan.Pages
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
#line 1 "C:\Users\Palmpich\Documents\GitHub\DiisLoan\TestLoan\TestLoan\Pages\_ViewImports.cshtml"
using TestLoan;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b266a0bf092da0bf585fb68ec3927c56b3bd2b5", @"/Pages/TypeLoan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b81cc2cf82832b8065cb60c76f58c3f60a5e422", @"/Pages/_ViewImports.cshtml")]
    public class Pages_TypeLoan : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""row row-cols-1 row-cols-md-3"">
    <div class=""col mb-4"">
        <div class=""card h-100"">
            <div class=""card-body"">
                <div class=""pt-4"">
                    <div class=""mx-3 pt-3 pb-2""
                         style=""text-align: center; color:#1877f2; background-color: #FAFAFA; border-radius: 5px;"">
                        <h4>ประเภทเงินยืมที่ 1</h4>
                    </div>
                </div>
                <div class=""p-3 pt-3 px-4"" style=""text-align: left;"">
                    <h6>ประเภท ");
#nullable restore
#line 16 "C:\Users\Palmpich\Documents\GitHub\DiisLoan\TestLoan\TestLoan\Pages\TypeLoan.cshtml"
                          Write(Model.LoanName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" บาท</h6>\r\n                    <h6>อัตราดอกเบี้ย ");
#nullable restore
#line 17 "C:\Users\Palmpich\Documents\GitHub\DiisLoan\TestLoan\TestLoan\Pages\TypeLoan.cshtml"
                                 Write(Model.Increase);

#line default
#line hidden
#nullable disable
            WriteLiteral(" เดือน</h6>\r\n                    <h6>งวด ");
#nullable restore
#line 18 "C:\Users\Palmpich\Documents\GitHub\DiisLoan\TestLoan\TestLoan\Pages\TypeLoan.cshtml"
                       Write(Model.periods);

#line default
#line hidden
#nullable disable
            WriteLiteral(" บาท</h6>\r\n                    <h6>วงเงินกู้ยืมสูงสุด ");
#nullable restore
#line 19 "C:\Users\Palmpich\Documents\GitHub\DiisLoan\TestLoan\TestLoan\Pages\TypeLoan.cshtml"
                                      Write(Model.remain_loan);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" งวด</h6>
                    <div class=""mt-3""></div>
                    <h6>** เงินเดือนคงเหลือสุทธิต้องไม่น้อยกว่าร้อยละ 10 **</h6>
                </div>

            </div>
        </div>
    </div>
    <div class=""col mb-4"">
        <div class=""card h-100"">
            <img src=""..."" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Card title</h5>
                <p class=""card-text"">This is a short card.</p>
            </div>
        </div>
    </div>
    <div class=""col mb-4"">
        <div class=""card h-100"">
            <img src=""..."" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Card title</h5>
                <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content.</p>
            </div>
        </div>
    </div>
    <div class=""col mb-4"">
        <div class=""card h-100"">
            <img src=""..");
            WriteLiteral(@"."" class=""card-img-top"" alt=""..."">
            <div class=""card-body"">
                <h5 class=""card-title"">Card title</h5>
                <p class=""card-text"">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestLoan.Pages.TypeLoanModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestLoan.Pages.TypeLoanModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TestLoan.Pages.TypeLoanModel>)PageContext?.ViewData;
        public TestLoan.Pages.TypeLoanModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591