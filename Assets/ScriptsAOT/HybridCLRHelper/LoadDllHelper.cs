using System;
using System.Collections;
using System.Linq;
using System.Reflection;

public static class LoadDllHelper
{
    static CommonResSerialization mCommonResSerialization;
    public static IEnumerator LoadDll(string name)
    {
        AssetsLoader.Instance.GetAsset(name);
        // �������Դ����ϵͳ�л���ȸ���dll������
        byte[] assemblyData = xxxx;
        // ͬʱ����dll��pdb�ļ�
        byte[] assData2 = yyy;
        byte[] pdbData2 = zzz;
        Assembly ass2 = Assembly.Load(assData2, pdbData2);
    }

    public void Func1()
    {
#if !UNITY_EDITOR
        Assembly hotUpdateAss = Assembly.Load(File.ReadAllBytes($"{Application.streamingAssetsPath}/ScriptsHotFix.dll.bytes"));
#else
        Assembly hotUpdateAss = System.AppDomain.CurrentDomain.GetAssemblies().First(a => a.GetName().Name == "ScriptsHotFix");
#endif

        Type type = hotUpdateAss.GetType("Hello");
        type.GetMethod("Run").Invoke(null, null);
    }
}
