using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public int score { get; private set; }
    public int winScore = 10;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;
        UIManager.Instance.UpdateScore(score);

        if (score >= winScore)
        {
            GameManager.Instance.WinGame();
        }
    }
}
