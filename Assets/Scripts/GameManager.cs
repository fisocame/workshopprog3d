using UnityEngine;

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
}
