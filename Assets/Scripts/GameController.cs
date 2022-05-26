using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    [SerializeField] private GameObject pauseButton;
    [SerializeField] private GameObject defeatPanel;
    [SerializeField] private Text timeText;
    [SerializeField] private int startTime;
    private float sceneStartTime;
    private float currTime;

    private void Awake()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);

        sceneStartTime = Time.time;
        currTime = startTime;
        timeText.text = (Mathf.RoundToInt(currTime)).ToString();
    }

    private void FixedUpdate()
    {
        currTime = startTime - (Time.time - sceneStartTime);
        timeText.text = (Mathf.RoundToInt(currTime)).ToString();
        CheckDefeat();
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

    private void CheckDefeat()
    {
        if(currTime < 0)
        {
            Time.timeScale = 0;
            defeatPanel.SetActive(true);
            pauseButton.SetActive(false);
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void AgainLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
