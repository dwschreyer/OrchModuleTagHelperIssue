using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;

namespace ClTagHelpers
{
    [HtmlTargetElement("my-ex-m-cl-h1")]
    [OutputElementHint("h1")]
    public class MyExMClH1TagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            var htmlAttributes = new Dictionary<string, object>();
            htmlAttributes.Add("style", "background-color: blue; color: white;");
            var tagBuilder = new TagBuilder(output.TagName);
            tagBuilder.MergeAttributes(htmlAttributes);
            output.MergeAttributes(tagBuilder);
        }
    }
}
