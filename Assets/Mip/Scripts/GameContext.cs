using UnityEngine;

namespace Mip
{
    public class GameContext : MonoBehaviour
    {
        public MainCanvas mainCanvas;
        
        public int cash
        {
            get
            {
                return _cash;
            }
            private set
            {
                _cash = value;
                mainCanvas.cashText.text = _cash.ToString("n0") + "원";
            }
        }
        
        public int stamina
        {
            get
            {
                return _stamina;
            }
            private set
            {
                _stamina = value;
                mainCanvas.staminaText.text = _stamina.ToString("n0");
            }
        }
        
        int _cash = 1166220;
        int _stamina = 100;
        
        void Awake()
        {
            cash = cash;
        }
        
        public void SetEarnCash(string reason, int cashDelta)
        {
            cash += cashDelta;
            mainCanvas.SetActiveEarnCash(reason + " +" + cashDelta.ToString("n0") + "원");
        }
        
        public void SetConsumeStamina(string reason, int staminaDelta)
        {
            stamina -= staminaDelta;
        }
    }
}
