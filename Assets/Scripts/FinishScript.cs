using UnityEngine;

public class FinishScript : MonoBehaviour
{
    [SerializeField] private Collider heroCollider;
    [SerializeField] private GameObject victoryPanel;
    [SerializeField] private GameObject pauseButton;

    private void OnTriggerEnter(Collider other)
    {
        if(other == heroCollider)
        {
            Time.timeScale = 0;
            victoryPanel.SetActive(true);
            pauseButton.SetActive(false);
        }
    }
}
