using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class GameController : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject pointsCount;
    public GameObject clickToStartText;
    public GameObject finalPointsCount;
    private bool isGameStarted = true;

    private void Start()
    {
        PauseGame();
        gameOverPanel.SetActive(false);
    }
    private void Update()
    {   
        if (isGameStarted == true) { 
            if (Mouse.current.leftButton.isPressed || Keyboard.current.enterKey.isPressed)
            {
                startGame();
            }
        }
    }
    public void showGameOverScreen()
    {
        isGameStarted = false;
        pointsCount.SetActive(false);
        gameOverPanel.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene("Game");
        isGameStarted = true;
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        pointsCount.SetActive(false);
        clickToStartText.SetActive(true);
        Time.timeScale = 0f;
    }

    public void startGame()
    {
        clickToStartText.SetActive(false);
        Time.timeScale = 1f;
        pointsCount.SetActive(true);
    }
}
