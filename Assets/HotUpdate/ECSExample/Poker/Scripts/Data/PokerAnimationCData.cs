using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

public struct PokerItemCData : IComponentData
{
    public int color;
    public int cardNum;
    public int nCardId;
}

public struct PokerTimerRemoveCData : IComponentData
{
    public float mRomveCdTime;
}

public struct PokerAnimationCData : IComponentData
{
    public Entity mEntity;
    public int index;
    public int value;
    public int cardid;
    public int color;
    public bool open;
    public bool trigger;
    public float triggerDelay;
    public bool btoRight;
    public float deltTime;
    public float checktimes; //ÿ��֡�����һ��λ�á�
    public float3 startPt;  //�ʼ����ʼ�㡣
    public float3 nowPt;
    public float vx;    // x������ٶ�
    public float vy;    // y������ٶ�  
    public float vyMax; // y���������ٶ�
    public float vx_a;  // x����ļ��ٶ� x������
    public float vy_a;  // y����ļ��ٶ�

    public float maxHeight;
    public float minHeight;
    public float maxWidth;
    public float minWidth;
    
    public void Reset()
    {
        mEntity = Entity.Null;
        index = 0; //�ڼ���col��
        value = 13;
        cardid = 1;  //13*v+value cardid
        color = 0;
        open = false;
        trigger = false;
        triggerDelay = 0;
        btoRight = true;
        deltTime = 0;
        checktimes = 0; //ÿ��֡�����һ��λ�á�

        startPt = new Vector3(0, 0, 0);  //�ʼ����ʼ�㡣
        nowPt = new Vector3(0, 0, 0);

        vx = 0;    // x������ٶ�
        vy = 0;    // y������ٶ�  
        vyMax = 0; // y���������ٶ�
        vx_a = 0;  // x����ļ��ٶ� x������
        vy_a = 0;  // y����ļ��ٶ�
        maxHeight = 0;   //ÿ�θ������ֵ��
    }

    public void Init(int index, int color, int value)
    {
        this.color = color;
        this.index = index;
        this.value = value;
        this.cardid = getCardId(color, value);
    }

    public static bool toRight(int index)
    {
        int[] toRightRate = new int[] { 100, 50, 40, 30 };
        int rate = UnityEngine.Random.Range(0, 100);
        bool toRight = rate <= toRightRate[index];
        return toRight;
    }

    public static float randomVx()
    {
        return UnityEngine.Random.Range(100, 200);
    }

    public static float randomVy()
    {
        return UnityEngine.Random.Range(100, 300);
    }

    public static float randomVy_a()
    {
        return UnityEngine.Random.Range(2000, 3000) * -1;
    }

    public static int getCardId(int color, int value)
    {
        return (int)color * 13 + value;
    }

}

public struct PokerAnimationCData2 : IComponentData
{
    public Entity mEntity;
    public int index;
    public int value;
    public int cardid;
    public int color;
    public bool open;
    public bool trigger;
    public float triggerDelay;
    public bool btoRight;
    public float deltTime;
    public float checktimes; //ÿ��֡�����һ��λ�á�
    public float3 startPt;  //�ʼ����ʼ�㡣
    public float3 nowPt;
    public float vx;    // x������ٶ�
    public float vy;    // y������ٶ�  
    public float vyMax; // y���������ٶ�
    public float vx_a;  // x����ļ��ٶ� x������
    public float vy_a;  // y����ļ��ٶ�

    public float maxHeight;
    public float minHeight;
    public float maxWidth;
    public float minWidth;

    public void Reset()
    {
        mEntity = Entity.Null;
        index = 0; //�ڼ���col��
        value = 13;
        cardid = 1;  //13*v+value cardid
        color = 0;
        open = false;
        trigger = false;
        triggerDelay = 0;
        btoRight = true;
        checktimes = 0; //ÿ��֡�����һ��λ�á�

        startPt = new Vector3(0, 0, 0);  //�ʼ����ʼ�㡣
        nowPt = new Vector3(0, 0, 0);

        vx = 0;    // x������ٶ�
        vy = 0;    // y������ٶ�  
        vyMax = 0; // y���������ٶ�
        vx_a = 0;  // x����ļ��ٶ� x������
        vy_a = 0;  // y����ļ��ٶ�
        maxHeight = 0;   //ÿ�θ������ֵ��
    }

    public void Init(int index, int color, int value)
    {
        this.color = color;
        this.index = index;
        this.value = value;
        this.cardid = getCardId(color, value);
    }

    public static bool toRight()
    {
        bool toRight = UnityEngine.Random.Range(0, 100) < 100;
        return toRight;
    }

    public static float randomVx()
    {
        return UnityEngine.Random.Range(50, 200);
    }

    public static float randomVy()
    {
        return UnityEngine.Random.Range(100, 150);
    }

    public static float randomVy_a()
    {
        return UnityEngine.Random.Range(1000, 1500) * -1;
    }

    public static int getCardId(int color, int value)
    {
        return (int)color * 13 + value;
    }

}