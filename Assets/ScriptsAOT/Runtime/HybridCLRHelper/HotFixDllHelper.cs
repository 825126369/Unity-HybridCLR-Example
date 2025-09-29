using System.Collections.Generic;

public static class HotFixDllHelper
{
    public static List<string> AOTMetaAssemblyFiles { get; } = new List<string>()
    {
        "mscorlib",
        "System",
        "System.Core",
    };

    public static List<string> HotUpdateAssemblyFiles { get; } = new List<string>()
    {
        
    };
}
