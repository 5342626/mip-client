using UnityEngine;
using UnityEngine.UI;

namespace Mip
{
    public class MainCanvas : MonoBehaviour
    {
        public Text cashText;
        public Text cashEarnText;
        
        public Text staminaText;
        
        public void SetActiveEarnCash(string text)
        {
            cashEarnText.text = text;
            cashEarnText.gameObject.SetActive(true);
        }
    }
}