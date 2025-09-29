using System;
using System.Collections.Generic;
using UnityEngine.Scripting;

[Preserve]
public static class HotFixDllHelper
{
    public static List<string> AOTMetaAssemblyFiles { get; } = new List<string>()
    {
        "mscorlib",
        "System",
        "System.Core",
        "Newtonsoft.Json"
    };

    public static List<string> HotUpdateAssemblyFiles { get; } = new List<string>()
    {
        
    };

    [Preserve]
    public static List<Type> HotUpdatePreserveClassList = new List<Type> 
    {
        typeof(UnityEngine.UI.Image),
        typeof(UnityEngine.UI.RawImage),
        typeof(UnityEngine.UI.Text),
        typeof(UnityEngine.Canvas),
        typeof(UnityEngine.UI.CanvasScaler),
        typeof(UnityEngine.UI.GraphicRaycaster),
    };
}
