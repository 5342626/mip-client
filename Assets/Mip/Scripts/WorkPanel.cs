using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Mip
{
    public class WorkPanel : MonoBehaviour
    {
        public Text text;
        public Animator textAnimator;
        public GameObject closeButton;
        public GameObject earnMoneyImage;
        public bool working;
        public Slider slider;

        void Update()
        {
            if (working)
            {
                slider.value += Time.deltaTime;

                if (slider.value >= slider.maxValue && closeButton.activeSelf == false)
                {
                    closeButton.SetActive(true);
                    text.text = "완료!";
                    earnMoneyImage.SetActive(true);
                }
            }
        }

        void OnEnable()
        {
            closeButton.SetActive(false);
            slider.gameObject.SetActive(false);
            working = false;
            text.text = "상단 메뉴에서 알바를 선택하세요.";
            slider.value = slider.minValue;
        }
        
        public void CloseWindow()
        {
            gameObject.SetActive(false);
        }

        public void SelectConv()
        {
            if (working == false)
            {
                working = true;
                text.text = "편의점 알바 중...";
                textAnimator.enabled = true;
                slider.gameObject.SetActive(true);
            }
        }

        public void SelectLabors()
        {
            if (working == false)
            {
                working = true;
                text.text = "일용직 알바 중...";
                textAnimator.Play("Explore Text");
                slider.gameObject.SetActive(true);
            }
        }

        public void SelectDarkLabors()
        {
            if (working == false)
            {
                working = true;
                text.text = "어둠의 알바 중...";
                textAnimator.enabled = true;
                slider.gameObject.SetActive(true);
            }
        }
    }
}
