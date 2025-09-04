namespace SunamoTidy.Tests;


public class TidyManagedHelperWithoutMockTests
{
    //[TestMethod]
    public async Task FormatHtmlTest()
    {
        var content = File.ReadAllTextAsync(@"D:\_Test\sunamo\SunamoTidy\FormatHtml\1.html");
        string actual = null;
        //actual = TidyManagedHelper.FormatHtml(content);
        await File.WriteAllTextAsync(@"D:\_Test\sunamo\SunamoTidy\FormatHtml\1_Out.html", actual);
    }
}
