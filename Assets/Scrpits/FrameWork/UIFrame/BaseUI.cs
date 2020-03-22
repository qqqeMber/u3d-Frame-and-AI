using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Frame {
    public abstract class BaseUI : MonoBehaviour
    {
        public virtual void OnEnter(BaseContext context)
        {
        }

        public virtual void OnExit(BaseContext context)
        {
        }

        public virtual void OnPause(BaseContext context)
        {
        }

        public virtual void OnResume(BaseContext context)
        {
        }

        public void DestroySelf()
        {
            Destroy(gameObject);
        }

    }
}



