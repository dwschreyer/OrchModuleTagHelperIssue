using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;

namespace Module1.TagHelpers
{
    [HtmlTargetElement("my-m-h1")]
    [OutputElementHint("h1")]
    public class MyMH1TagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "h1";
            var htmlAttributes = new Dictionary<string, object>();
            htmlAttributes.Add("style", "background-color: red; color: white;");
            var tagBuilder = new TagBuilder(output.TagName);
            tagBuilder.MergeAttributes(htmlAttributes);
            output.MergeAttributes(tagBuilder);
        }
    }
}
