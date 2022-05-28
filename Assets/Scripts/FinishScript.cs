using UnityEngine;
using UnityEngine.UI;

public class FinishScript : MonoBehaviour
{
    [SerializeField] private Collider heroCollider;
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private Text bonusText;
    [SerializeField] private GameObject pauseButton;

    private void OnTriggerEnter(Collider other)
    {
        if(other == heroCollider)
        {
            Time.timeScale = 0;
            victoryPanel.SetActive(true);
            bonusText.text = $"Бонусов собрано: {BonusCatch.bonusCount}/5";
            pauseButton.SetActive(false);
        }
    }
}
