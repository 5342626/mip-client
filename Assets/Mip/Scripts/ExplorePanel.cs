using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Mip
{
    public class ExplorePanel : MonoBehaviour
    {
        public Text text;
        public Animator textAnimator;
        public GameObject closeButton;
        public GameObject earnMoneyImage;
        
        bool earned;
        
        void OnEnable()
        {
            closeButton.SetActive(false);
            
            text.text = "거리를 탐색하는 중입니다...";
            
            StartCoroutine(StartExplore());
        }
        
        IEnumerator StartExplore()
        {
            yield return new WaitForSeconds(3.0f);
            
            textAnimator.Stop();
            
            text.color = Color.black;
            
            var r = Random.Range(0, 2);
            
            Debug.Log(r);
            
            if (r == 1)
            {
                text.text = "돈을 주웠습니다!";
                earned = true;
            }
            else
            {
                text.text = "거리가 너무 깨끗합니다.\n주울 돈이 없네요.";
                earned = false;
            }
            
            closeButton.SetActive(true);
        }
        
        public void CloseWindow()
        {
            gameObject.SetActive(false);
            
            if (earned)
            {
                earnMoneyImage.SetActive(true);
            }
        }
    }
}
