using Unity.Mathematics;
using Unity.Transforms;

public static class ECSExtentions
{
    //����������ת��Ϊ����ڸ��� LocalToWorld �ľֲ�����
    public static float3 WorldToLocal(this LocalToWorld parentLtw, float3 worldPosition)
    {
        return math.transform(math.inverse(parentLtw.Value), worldPosition);
    }

    //���ֲ�����ת��Ϊ����ڸ��� LocalToWorld ����������
    public static float3 LocalToWorld(this LocalToWorld parentLtw, float3 localPosition)
    {
        return math.transform(parentLtw.Value, localPosition);
    }
}
