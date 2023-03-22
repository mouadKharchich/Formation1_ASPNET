using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Formation.TagHelpers
{
    [HtmlTargetElement(Attributes ="name")]
    public class Condition : TagHelper
    {
        
        public string Name { get; set; }

        

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "condition";
            output.Content.SetContent($"Hello, {Name}!");
        }
    }
}
