using Markdig;

namespace MarkdigExtension.MSCallout.Test;

[TestClass]
public class TestMSCallout
{
    private MarkdownPipeline MarkdownPipeline { get; set; }

    public TestMSCallout()
    {
        var markdownPipelineBuilder = new MarkdownPipelineBuilder()
            // .UseAdvancedExtensions()
            .UseYamlFrontMatter();
        MarkdownPipeline = markdownPipelineBuilder.Build();
    }

    [TestMethod]
    [DataRow(@"a.md")]
    [DataRow(@"b.md")]
    public void MSCallout_Base(string fileName)
    {
        var inputFilePathBase =
            @"E:\Code\C#\Tool\MarkdigExtension\MarkdigExtension.MSCallout\MarkdigExtension.MSCallout.Test\assets";

        var filePath = Path.Combine(inputFilePathBase, fileName);
        var markText = File.ReadAllText(filePath);
        var result = Markdig.Markdown.Parse(markText, MarkdownPipeline).ToHtml();
        var outputFilePathBase =
            @"E:\Code\C#\Tool\MarkdigExtension\MarkdigExtension.MSCallout\MarkdigExtension.MSCallout.Test\assets\TestResults";
        filePath = Path.Combine(outputFilePathBase, $"{fileName.Split(".").First()}.html");
        File.WriteAllText(filePath, result);
    }
}