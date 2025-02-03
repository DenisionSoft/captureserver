using Notissimus.CaptureServer.Domain.Captures;

namespace Notissimus.CaptureServer.Application.Captures;

internal sealed class CaptureService : ICaptureService
{
    private readonly ICaptureRepository captureRepository;

    public CaptureService(
        ICaptureRepository captureRepository)
    {
        this.captureRepository = captureRepository;
    }

    public Task AddCapturesAsync(AddCapturesCommand command, CancellationToken cancellationToken)
    {
        List<Capture> captures = new();

        foreach (var captureModel in command.Captures)
        {
            var capture = Capture.Create(
                captureModel.X,
                captureModel.Y,
                captureModel.CapturedAt);

            captures.Add(capture);
        }

        return captureRepository.AddRangeAsync(captures, cancellationToken);
    }
}