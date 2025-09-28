using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"ScriptsAOT.dll",
		"UnityEngine.CoreModule.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// SingleTonMonoBehaviour<object>
	// System.Action<UnityEngine.ResourceManagement.AsyncOperations.DownloadStatus>
	// }}

	public void RefMethods()
	{
		// object UnityEngine.Component.GetComponent<object>()
		// object UnityEngine.GameObject.AddComponent<object>()
	}
}