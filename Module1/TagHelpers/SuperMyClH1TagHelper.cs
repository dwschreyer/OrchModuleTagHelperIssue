using ClTagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module1.TagHelpers
{
    [HtmlTargetElement("s-my-cl-h1")]
    [OutputElementHint("h1")]
    public class SuperMyClH1TagHelper : MyClH1TagHelper
    {
    }
}
