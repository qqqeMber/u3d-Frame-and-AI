using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 每制作好一个菜单 或 整体的控件（比如 玩家血量和分数） 需要存为prefab 位于Resources/View/xxxxxView
/// 并且在UIType 添加相应的类型
/// 每个UI各自绑定自己的脚本 分别有XXXXContext XXXXUI各自继承
/// 手动在unity设置脚本的方法
/// 也可以在脚本内 AddListtener
/// 每个UI都是单例
/// 对于不同场景 需要对ContextManager.FirstContext修改 
/// </summary>
namespace Frame
{
    public class UIManager
    {
        public Dictionary<UIType, GameObject> UI = new Dictionary<UIType, GameObject>();

        private Transform Canvas;

        private UIManager()
        {
            Canvas = GameObject.Find("Canvas").transform;
            foreach(Transform item in Canvas)
            {
                GameObject.Destroy(item.gameObject);
            }
        }

        public GameObject GetSingleUI(UIType uiType)
        {
            if (UI.ContainsKey(uiType) == false || UI[uiType] == null)
            {
                GameObject go = GameObject.Instantiate(Resources.Load<GameObject>(uiType.Path)) as GameObject;
                go.transform.SetParent(Canvas, false);
                go.name = uiType.Name;
                UI.Add(uiType,go);
                return go;
            }
            return UI[uiType];
        }

        public void DestroySingleUI(UIType uiType)
        {
            if (!UI.ContainsKey(uiType))
            {
                return;
            }

            if (UI[uiType] == null)
            {
                UI.Remove(uiType);
                return;
            }

            GameObject.Destroy(UI[uiType]);
            UI.Remove(uiType);
        }
    }
}

