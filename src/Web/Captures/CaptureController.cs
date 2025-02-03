using Microsoft.AspNetCore.Mvc;
using Notissimus.CaptureServer.Application.Captures;
using Notissimus.CaptureServer.Contracts;
using Notissimus.CaptureServer.Contracts.Captures;

namespace Notissimus.CaptureServer.Web.Captures;

[ApiController]
public class CaptureController : ControllerBase
{
    private readonly ICaptureService captureService;

    public CaptureController(ICaptureService captureService)
    {
        this.captureService = captureService;
    }

    /// <summary>
    /// Добавить снимки координат мыши
    /// </summary>
    [HttpPost(ApiRoute.Captures, Name = "AddCapturesAsync")]
    public async Task AddCapturesAsync(
        [FromBody] AddCapturesRequest request,
        CancellationToken cancellationToken)
    {
        var command = request.ToAddCapturesCommand();
        await captureService.AddCapturesAsync(command, cancellationToken);
    }
}
