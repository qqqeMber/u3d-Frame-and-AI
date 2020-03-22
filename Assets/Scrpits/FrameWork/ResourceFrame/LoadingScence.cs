using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Frame
{
    /// <summary>
    /// 如果需要异步加载scence 使用该脚本
    /// 同步加载则直接loadscence()
    /// </summary>
    public class LoadingScence : MonoBehaviour
    {
        public Slider m_Slider;
        public Text m_Text;
        public static string nextScenceName;
        void Start()
        {
            StartCoroutine(loadScene());
        }
        private IEnumerator loadScene()
        {
            int displayProgress = 0;
            int toProgress = 0;
            AsyncOperation op = SceneManager.LoadSceneAsync(nextScenceName);
            op.allowSceneActivation = false;
            while (op.progress < 0.9f)
            {
                toProgress = (int)op.progress * 100;
                while (displayProgress < toProgress)
                {
                    ++displayProgress;
                    SetLoadingPercentage(displayProgress);
                    yield return new WaitForEndOfFrame();
                }
            }
            toProgress = 100;
            while (displayProgress < toProgress)
            {
                ++displayProgress;
                SetLoadingPercentage(displayProgress);
                yield return new WaitForEndOfFrame();
            }
            op.allowSceneActivation = true;
        }
        public void SetLoadingPercentage(int DisplayProgress)
        {
            m_Slider.value = DisplayProgress * 0.01f;
            m_Text.text = DisplayProgress.ToString() + "%";
        }
    }
}
