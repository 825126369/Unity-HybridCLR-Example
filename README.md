华佗热更新 失败案例     【短时间内不再更新这个库了】

花了一周，都没搞定HybridCLR, 都是Editor 热更正常，打包后，各种报错。 (并没有他们说的那么好啊)

1： 如果将热更新脚本挂载到随主包的资源上(比如 Resources, StreamingAssets)，会发生scripting missing的错误！ 
所以得动态挂载脚本（这样啊，呵呵，看来没那么强大）

Bug:
1: Windows PC 平台报错:

PlatformNotSupportedException: Operation is not supported on this platform.
  at System.Reflection.Emit.DynamicMethod..ctor (System.String name, System.Type returnType, System.Type[] parameterTypes, System.Type owner, System.Boolean skipVisibility) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.CreateDynamicMethod (System.String name, System.Type returnType, System.Type[] parameterTypes, System.Type owner) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.Utilities.DynamicReflectionDelegateFactory.CreateDefaultConstructor[T] (System.Type type) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.Serialization.DefaultContractResolver.InitializeContract (Newtonsoft.Json.Serialization.JsonContract contract) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.Serialization.DefaultContractResolver.CreateArrayContract (System.Type objectType) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.Serialization.DefaultContractResolver.CreateContract (System.Type objectType) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.Serialization.DefaultContractResolver.ResolveContract (System.Type type) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.Serialization.JsonSerializerInternalReader.Deserialize (Newtonsoft.Json.JsonReader reader, System.Type objectType, System.Boolean checkAdditionalContent) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.JsonSerializer.DeserializeInternal (Newtonsoft.Json.JsonReader reader, System.Type objectType) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.JsonConvert.DeserializeObject (System.String value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) [0x00000] in <00000000000000000000000000000000>:0 
  at Newtonsoft.Json.JsonConvert.DeserializeObject[T] (System.String value) [0x00000] in <00000000000000000000000000000000>:0 
  at AddressablesRedirectManager+<Do>d__1.MoveNext () [0x00000] in <00000000000000000000000000000000>:0 
  at UnityEngine.SetupCoroutine.InvokeMoveNext (System.Collections.IEnumerator enumerator, System.IntPtr returnValueAddress) [0x00000] in <00000000000000000000000000000000>

2: WebGL 平台报错:

