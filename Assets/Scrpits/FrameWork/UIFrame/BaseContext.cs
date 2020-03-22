using UnityEngine;
using System;
using System.Collections.Generic;

namespace Frame
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseContext
    {
        public UIType ViewType { get; private set; }
        public BaseContext(UIType viewType)
        {
            ViewType = viewType;
        }
    }
}
