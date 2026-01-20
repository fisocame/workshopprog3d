using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI messageText;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        if (messageText) messageText.text = "";
    }

    public void UpdateScore(int score)
    {
        if (scoreText) scoreText.text = $"Score: {score}";
    }

    public void ShowMessage(string msg)
    {
        if (messageText) messageText.text = msg;
    }
}
