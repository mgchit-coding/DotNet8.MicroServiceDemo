using DotNet8.MicroServiceDemo.Shared.Enums;

namespace DotNet8.MicroServiceDemo.Shared.Models.Errors;

public static class BlogResponse
{
    public static Error Success = new(EnumResponseCode.R0001.ToString(),
            EnumResponseDescription.Success.ToString());

    public static Error Fail = new(EnumResponseCode.R0002.ToString(),
        EnumResponseDescription.Fail.ToString());

    public static Error NotFound = new(EnumResponseCode.R0003.ToString(),
        EnumResponseDescription.NotFound.ToString());
}