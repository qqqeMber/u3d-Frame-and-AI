using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Frame
{
    public class GameManger : MonoBehaviour
    {
        public void Start()
        {
            Singleton<UIManager>.Create();
            Singleton<ContextManager>.Create();
        }
    }
}

