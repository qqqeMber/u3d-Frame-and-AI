using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace Frame
{
    public class ContextManager
    {
        private Stack<BaseContext> _contextStack = new Stack<BaseContext>();
    //    public static BaseContext FirstContext=new XXXXXX()
        private ContextManager()
        {
     //       Push(FirstContext);
        }
        public void Push(BaseContext nextContext)
        {

            if (_contextStack.Count != 0)
            {
                BaseContext curContext = _contextStack.Peek();
                BaseUI curView = Singleton<UIManager>.Instance.GetSingleUI(curContext.ViewType).GetComponent<BaseUI>();
                curView.OnPause(curContext);
            }

            _contextStack.Push(nextContext);
            BaseUI nextView = Singleton<UIManager>.Instance.GetSingleUI(nextContext.ViewType).GetComponent<BaseUI>();
            nextView.OnEnter(nextContext);
        }

        public void Pop()
        {
            if (_contextStack.Count != 0)
            {
                BaseContext curContext = _contextStack.Peek();
                _contextStack.Pop();

                BaseUI curView = Singleton<UIManager>.Instance.GetSingleUI(curContext.ViewType).GetComponent<BaseUI>();
                curView.OnExit(curContext);
            }

            if (_contextStack.Count != 0)
            {
                BaseContext lastContext = _contextStack.Peek();
                BaseUI curView = Singleton<UIManager>.Instance.GetSingleUI(lastContext.ViewType).GetComponent<BaseUI>();
                curView.OnResume(lastContext);
            }
        }

        public BaseContext PeekOrNull()
        {
            if (_contextStack.Count != 0)
            {
                return _contextStack.Peek();
            }
            return null;
        }
    }
}
