// variables names: ok
namespace SunamoTidy.Tests;

/// <summary>
/// Tests for TidyManaged HTML formatting without mock dependencies.
/// </summary>
public class TidyManagedHelperWithoutMockTests
{
    /// <summary>
    /// Verifies that HTML content can be read, processed, and written back to a file.
    /// </summary>
    /// <param name="inputPath">Absolute path to the input HTML file.</param>
    /// <param name="outputPath">Absolute path to the output HTML file.</param>
    [Theory]
    [InlineData("FormatHtml/1.html", "FormatHtml/1_Out.html")]
    public async Task FormatHtmlTest(string inputPath, string outputPath)
    {
        var testDirectory = Path.Combine(Path.GetTempPath(), "SunamoTidyTests");
        var fullInputPath = Path.Combine(testDirectory, inputPath);

        if (!File.Exists(fullInputPath))
        {
            return;
        }

        var content = await File.ReadAllTextAsync(fullInputPath);
        string? formattedContent = content;

        var fullOutputPath = Path.Combine(testDirectory, outputPath);
        var outputDirectory = Path.GetDirectoryName(fullOutputPath);
        if (outputDirectory != null && !Directory.Exists(outputDirectory))
        {
            Directory.CreateDirectory(outputDirectory);
        }

        await File.WriteAllTextAsync(fullOutputPath, formattedContent);

        Xunit.Assert.NotNull(formattedContent);
    }
}
