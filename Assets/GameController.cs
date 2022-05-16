using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private Text timeText;
    [SerializeField] private int startTime;
    private float currTime;

    private void Awake()
    {
        currTime = startTime;
        timeText.text = (Mathf.RoundToInt(currTime)).ToString();
    }

    private void FixedUpdate()
    {
        currTime = startTime - Time.time;
        timeText.text = (Mathf.RoundToInt(currTime)).ToString();
    }

    public void PauseOn()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
        pauseButton.SetActive(false);
    }
    public void ResumeOn()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        pausePanel.SetActive(false);
    }
}
