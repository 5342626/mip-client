using UnityEngine;
using UnityEngine.UI;

namespace Mip
{
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Image))]
    [ExecuteInEditMode]
    public class BackgroundScaler : MonoBehaviour
    {
        public RectTransform rootCanvas;
        public Canvas rootCanvas2;
        
        Image image;
        float lastScreenWidth;
        float lastScreenHeight;
        
        void Awake()
        {
            image = GetComponent<Image>();
        }
        
        void Update()
        {   
            var sw = rootCanvas2.pixelRect.width;
            var sh = rootCanvas2.pixelRect.height;
            
            if (sw != lastScreenWidth || sh != lastScreenHeight)
            {
                var sar = (float)sw / sh;
                
                Debug.Log("sw = " + rootCanvas2.pixelRect.width);
                Debug.Log("sh = " + rootCanvas2.pixelRect.height);
                
                
                var iw = image.sprite.rect.width;
                var ih = image.sprite.rect.height;
                var iar = (float)iw / ih;
                
                Debug.Log("iw = " + iw);
                Debug.Log("ih = " + ih);
                
                if (sar > iar)
                {
                    transform.localScale = Vector3.one * sar / iar;
                }
                else
                {
                    transform.localScale = Vector3.one * iar / sar;
                }
                
                lastScreenWidth = sw;
                lastScreenHeight = sh;
            }
        }
    }
}