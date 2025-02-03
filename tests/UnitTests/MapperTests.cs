using Notissimus.CaptureServer.Contracts.Captures;
using Notissimus.CaptureServer.Web.Captures;
using Shouldly;
using Xunit;

namespace Notissimus.CaptureServer.UnitTests;

public class MapperTests
{
    [Theory]
    [MemberData(nameof(InvalidRequestModelFields))]
    public void ToAddCapturesCommand_Throws_WhenAnyArgumentIsNull(int? x, int? y, DateTimeOffset? capturedAt)
    {
        // Arrange
        var model = new CaptureRequestModel
        {
            X = x,
            Y = y,
            CapturedAt = capturedAt
        };

        var request = new AddCapturesRequest { Captures = [model] };

        // Act
        var f = () => request.ToAddCapturesCommand();

        // Assert
        f.ShouldThrow<ArgumentNullException>();
    }

    public static TheoryData<int?, int?, DateTimeOffset?> InvalidRequestModelFields =>
        new()
        {
            { 1, 2, null },
            { 1, null, DateTimeOffset.Now },
            { null, 2, DateTimeOffset.Now }
        };
}
