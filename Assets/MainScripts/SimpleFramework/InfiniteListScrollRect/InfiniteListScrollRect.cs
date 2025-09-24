using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

/// <summary>
/// 无限列表滚动视野
/// </summary>
public class InfiniteListScrollRect : ScrollRect
{
    /// <summary>
    /// ElementTemplate
    /// </summary>
    public GameObject ElementTemplate;

    /// <summary>
    /// ListingDirection
    /// </summary>
    public Direction ListingDirection = Direction.Vertical;
    /// <summary>
    /// Height
    /// </summary>
    public int Height = 20;
    /// <summary>
    /// Interval
    /// </summary>
    public int IntervalY = 5;
    private List<InfiniteListData> _datas = new List<InfiniteListData>();
    private HashSet<InfiniteListData> _dataIndexs = new HashSet<InfiniteListData>();
    private Dictionary<InfiniteListData, InfiniteListElement> _displayElements = new Dictionary<InfiniteListData, InfiniteListElement>();
    private HashSet<InfiniteListData> _invisibleList = new HashSet<InfiniteListData>();
    private Queue<InfiniteListElement> _elementsPool = new Queue<InfiniteListElement>();
    private RectTransform _uiTransform;
    
    /// <summary>
    /// RectTransform
    /// </summary>
    public RectTransform UITransform
    {
        get
        {
            if (_uiTransform == null)
            {
                _uiTransform = GetComponent<RectTransform>();
            }
            return _uiTransform;
        }
    }

    /// <summary>
    /// CurrentDataCount
    /// </summary>
    public int DataCount
    {
        get
        {
            return _datas.Count;
        }
    }

    protected override void Awake()
    {
        base.Awake();
        onValueChanged.AddListener((value) => { RefreshScrollView(); });

    }
    
    protected override void OnDestroy()
    {
        base.OnDestroy();
        onValueChanged.RemoveAllListeners();
        _datas.Clear();
        _dataIndexs.Clear();
        _displayElements.Clear();
        _invisibleList.Clear();
        _elementsPool.Clear();
    }


    /// <summary>
    /// AddData
    /// </summary>
    /// <param name="data">InfiniteListData</param>
    public void AddData(InfiniteListData data)
    {
        if (_dataIndexs.Contains(data))
        {
            Debug.LogWarning("添加数据至无限列表失败：列表中已存在该数据 " + data.ToString());
            return;
        }

        _datas.Add(data);
        _dataIndexs.Add(data);

        RefreshScrollContent();
    }
    /// <summary>
    /// AddDatas
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <param name="datas">T[]</param>
    public void AddDatas<T>(T[] datas) where T : InfiniteListData
    {
        for (int i = 0; i < datas.Length; i++)
        {
            if (_dataIndexs.Contains(datas[i]))
            {
                Debug.LogWarning("添加数据至无限列表失败：列表中已存在该数据 " + datas[i].ToString());
                continue;
            }

            _datas.Add(datas[i]);
            _dataIndexs.Add(datas[i]);
        }

        RefreshScrollContent();
    }
    
    public void SetContentShowWhichData(int nIndex)
    {
        float contentY = nIndex * (Height + IntervalY);
        content.anchoredPosition = new Vector2(0, contentY);
    }

    public InfiniteListElement AddDatas<T>(T[] datas,int index) where T : InfiniteListData
    {
        
        float contentY = index * (Height + IntervalY);
        content.anchoredPosition = new Vector2(0, contentY);

        for (int i = 0; i < datas.Length; i++)
        {
            if (_dataIndexs.Contains(datas[i]))
            {
                Debug.LogWarning("添加数据至无限列表失败：列表中已存在该数据 " + datas[i].ToString());
                continue;
            }

            _datas.Add(datas[i]);
            _dataIndexs.Add(datas[i]);
        }

        RefreshScrollContent();
        
        return _displayElements[_datas[index]];
        
    }
    /// <summary>
    /// AddDatas
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <param name="datas">List<T></param>
    public void AddDatas<T>(List<T> datas) where T : InfiniteListData
    {
        for (int i = 0; i < datas.Count; i++)
        {
            if (_dataIndexs.Contains(datas[i]))
            {
                Debug.LogWarning("添加数据至无限列表失败：列表中已存在该数据 " + datas[i].ToString());
                continue;
            }

            _datas.Add(datas[i]);
            _dataIndexs.Add(datas[i]);
        }
        RefreshScrollContent();
    }
    /// <summary>
    /// RemoveData
    /// </summary>
    /// <param name="data">InfiniteListData</param>
    public void RemoveData(InfiniteListData data)
    {
        if (_dataIndexs.Contains(data))
        {
            _datas.Remove(data);
            _dataIndexs.Remove(data);

            if (_displayElements.ContainsKey(data))
            {
                RecycleElement(_displayElements[data]);
                _displayElements.Remove(data);
            }

            RefreshScrollContent();
        }
        else
        {
            Debug.LogWarning("从无限列表中移除数据失败：列表中不存在该数据 " + data.ToString());
        }
    }
    /// <summary>
    /// ClearData
    /// </summary>
    public void ClearData()
    {
        content.anchoredPosition = new Vector2(0, 0);
        verticalScrollbar.value = 1;
        _datas.Clear();
        _dataIndexs.Clear();
        foreach (var element in _displayElements)
        {
            RecycleElement(element.Value);
        }
        _displayElements.Clear();
        RefreshScrollContent();
    }

    /// <summary>
    /// RefreshContent
    /// </summary>
    protected void RefreshScrollContent()
    {
        if (ListingDirection == Direction.Vertical)
        {
            content.sizeDelta = new Vector2(content.sizeDelta.x, _datas.Count * (Height + IntervalY));
        }
        else
        {
            content.sizeDelta = new Vector2(_datas.Count * (Height + IntervalY), content.sizeDelta.y);
        }
        RefreshScrollView();
    }
    
    /// <summary>
    /// Refresh ScrollView
    /// </summary>
    protected void RefreshScrollView()
    {
        if (ListingDirection == Direction.Vertical)
        {
            float contentY = content.anchoredPosition.y;//current content posY data
            float viewHeight = UITransform.sizeDelta.y;//father height
                                                        //Debug.Log("this is  " + contentY);

            float addItem = (Height + IntervalY) * 6;
            float maxValue = -viewHeight - addItem;
            float minValue = addItem;

            ClearInvisibleVerticalElement(contentY, viewHeight, minValue, maxValue);
            int originIndex = (int)(contentY / (Height + IntervalY));//current index calculate top through the content 

            if (originIndex < 0) originIndex = 0;
            for (int i = originIndex; i < _datas.Count; i++)
            {

                InfiniteListData data = _datas[i];
                float viewY = -(i * Height + (i + 1) * IntervalY);//calculate total heights

                float realY = viewY + contentY;

                if (realY >= maxValue && realY <= minValue)
                {
                    if (_displayElements.ContainsKey(data))
                    {
                        continue;
                    }

                    InfiniteListElement element = ExtractIdleElement();
                    element.UITransform.anchoredPosition = new Vector2(0, viewY);
                    element.OnUpdateData(data);
                    _displayElements.Add(data, element);
                }
                else
                {
                    break;
                }
            }
        }
        else
        {
            float contentX = content.anchoredPosition.x;
            float viewWidth = UITransform.sizeDelta.x;

            ClearInvisibleHorizontalElement(contentX, viewWidth);

            int originIndex = (int)(-contentX / (Height + IntervalY));
            if (originIndex < 0) originIndex = 0;

            for (int i = originIndex; i < _datas.Count; i++)
            {
                InfiniteListData data = _datas[i];

                float viewX = i * Height + (i + 1) * IntervalY;
                float realX = viewX + contentX;
                if (realX < viewWidth)
                {
                    if (_displayElements.ContainsKey(data))
                    {
                        _displayElements[data].UITransform.anchoredPosition = new Vector2(viewX, 0);
                        continue;
                    }

                    InfiniteListElement element = ExtractIdleElement();
                    element.UITransform.anchoredPosition = new Vector2(viewX, 0);
                    element.OnUpdateData(data);
                    _displayElements.Add(data, element);
                }
                else
                {
                    break;
                }
            }
        }
    }
    /// <summary>
    /// Clear Invisible(vertical)
    /// </summary>
    /// <param name="contentY">content's posY</param>
    /// <param name="viewHeight">Height</param>
    private void ClearInvisibleVerticalElement(float contentY, float viewHeight, float minValue, float maxValue)
    {
        if (-0.1f < contentY && contentY < 0.01f)
        {
            contentY = 0f;
        }
        foreach (var element in _displayElements)
        {
            //realY = current item relative posY + 
            float realY = element.Value.UITransform.anchoredPosition.y + contentY;

            if (realY > maxValue && realY < minValue)
            {
                continue;
            }
            else
            {
                _invisibleList.Add(element.Key);
            }
        }
        foreach (var item in _invisibleList)
        {
            RecycleElement(_displayElements[item]);
            _displayElements.Remove(item);
        }
        _invisibleList.Clear();
    }
    /// <summary>
    /// Clear Invisible(Horizontal)
    /// </summary>
    /// <param name="contentX">content's posX</param>
    /// <param name="viewWidth">viewWidth</param>
    private void ClearInvisibleHorizontalElement(float contentX, float viewWidth)
    {
        foreach (var element in _displayElements)
        {
            float realX = element.Value.UITransform.anchoredPosition.x + contentX;
            if (realX > -Height && realX < viewWidth)
            {
                continue;
            }
            else
            {
                _invisibleList.Add(element.Key);
            }
        }
        foreach (var item in _invisibleList)
        {
            RecycleElement(_displayElements[item]);
            _displayElements.Remove(item);
        }
        _invisibleList.Clear();
    }

    private InfiniteListElement ExtractIdleElement()
    {
        if (_elementsPool.Count > 0)
        {
            InfiniteListElement element = _elementsPool.Dequeue();
            element.gameObject.SetActive(true);
            return element;
        }
        else
        {
            GameObject obj = Instantiate(ElementTemplate, content);
            obj.SetActive(true);
            InfiniteListElement element = obj.GetComponent<InfiniteListElement>();
            return element;
        }
    }

    /// <summary>
    /// Recycle unless Element
    /// </summary>
    /// <param name="element">element</param>
    private void RecycleElement(InfiniteListElement element)
    {
        element.gameObject.SetActive(false);
        _elementsPool.Enqueue(element);
    }

    /// <summary>
    /// Direction
    /// </summary>
    public enum Direction
    {
        /// <summary>
        /// Horizontal
        /// </summary>
        Horizontal,
        /// <summary>
        /// Vertical
        /// </summary>
        Vertical
    }
}
