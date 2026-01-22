using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private bool gameEnded = false;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void WinGame()
    {
        if (gameEnded) return;
        gameEnded = true;

        UIManager.Instance.ShowMessage("You Win!");
        Time.timeScale = 0f;
    }

    public void GameOver()
    {
        if (gameEnded) return;
        gameEnded = true;

        UIManager.Instance.ShowMessage("Game Over!");
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
