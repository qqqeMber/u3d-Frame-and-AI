using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 不包括UI的加载
/// </summary>
namespace Frame 
{
   public class ResManager : MonoBehaviour
    {
        public T ResourcesLoading<T>(string path, bool IsAsync) where T : UnityEngine.Object
        {
            if (string.IsNullOrEmpty(path))
            {
                return null;
            }
            else
            {
                T load;
                if (IsAsync == false)
                {
                    load = Resources.Load<T>(path);
                }
                else
                {
                    load = Resources.LoadAsync<T>(path).asset as T;
                }
                    return load;
            }
        }
        public void ReleaseResource(UnityEngine.Object obj,bool destoryObj)
        {
            Resources.UnloadAsset(obj);
        }
    }

}