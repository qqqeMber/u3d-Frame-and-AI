using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Frame {
    public class UIType
    {
        /// <summary>
        /// 存储UI Prefab
        /// </summary>
        public string Path { get; private set; }

        public string Name { get; private set; }

        public UIType(string path)
        {
            Path = path;
            Name = path.Substring(path.LastIndexOf('/') + 1);
        }

        public override string ToString()
        {
            return string.Format("path : {0} name : {1}", Path, Name);
        }
        /// <summary>
        /// 做一个UI加一个
        /// </summary>
        public static readonly UIType MainMenu = new UIType("View/MainMenuView");
        public static readonly UIType OptionMenu = new UIType("View/OptionMenuView");
    }
}

