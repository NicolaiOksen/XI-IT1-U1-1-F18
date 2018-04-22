using Microsoft.AspNetCore.Razor.TagHelpers;

public class CustomTagHelper : TagHelper
{
    public string Title { get; set; }
    public string Body { get; set; }

    public override void Process(TagHelperContext c, TagHelperOutput output)
    {
        output.TagName = "p";
        output.Attributes.Add("class", "example");
        output.PostContent.SetContent("Hello from my custom tag helper");
        output.PostContent.Append($"Title is: {Title} and body is: {Body}");
    }
}
