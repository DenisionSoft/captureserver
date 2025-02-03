using Notissimus.CaptureServer.Application.Captures;
using Notissimus.CaptureServer.Common;
using Notissimus.CaptureServer.Contracts.Captures;

namespace Notissimus.CaptureServer.Web.Captures;

public static class CaptureMapperExtensions
{
    public static AddCapturesCommand ToAddCapturesCommand(this AddCapturesRequest request)
    {
        return new AddCapturesCommand
        (
            Captures: request.Captures.Select(ToCaptureModel).ToList()
        );
    }

    private static CaptureModel ToCaptureModel(this CaptureRequestModel requestModel)
    {
        return new CaptureModel
        (
            X: requestModel.X.Required(),
            Y: requestModel.Y.Required(),
            CapturedAt: requestModel.CapturedAt.Required()
        );
    }
}
