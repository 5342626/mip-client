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
                mainCanvas.cashText.text = (_cash < 0 ? "-" : "") + _cash.ToString("n0");
                mainCanvas.cashText.color = _cash < 0 ? Color.red : Color.green;
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
        
        public static GameContext Instance;
        
        void Awake()
        {
            Instance = this;
            
            cash = cash;
        }
        
        public void SetEarnCash(string reason, int cashDelta)
        {
            cash += cashDelta;
            //mainCanvas.SetActiveEarnCash(reason + " +" + cashDelta.ToString("n0") + "원");
        }
        
        public void SetConsumeStamina(string reason, int staminaDelta)
        {
            stamina -= staminaDelta;
        }
    }
}
