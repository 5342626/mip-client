using UnityEngine;

namespace Mip
{
    public class ButtonPanel : MonoBehaviour
    {
        public GameContext gameContext;
        
        public void Explore()
        {
            Debug.Log("Explore()");
            gameContext.SetConsumeStamina("탐색", 1);
            gameContext.SetEarnCash("탐색", 100);
        }
        
        public void Work()
        {
            gameContext.SetConsumeStamina("알바", 1);
            gameContext.SetEarnCash("알바", 6030);
        }
        
        public void Gamble()
        {
            
        }
    }
}