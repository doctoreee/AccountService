using AccountService.Application.Wrappers;

namespace AccountService.API.Wrappers
{
    public static class ResponseBaseExtensions
    {
        public static ApiResponse ToApiResponse(this ResponseBase responseBase)
        {
            return new()
            {
                Success = true,
                Data = responseBase,
                Messages = responseBase.Message == default
                    ? null
                    : new List<ApiResponseMessage> { new ApiResponseMessage
                    {
                        Code = responseBase.Code,
                        Message = responseBase.Message
                        }
                    }
            };
        }
    }
}
