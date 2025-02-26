using UnityEngine;
using UnityEngine.SceneManagement; // Add this namespace

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int score = 0;
    public int targetScore = 4; // Score to reach before changing scenes

    public void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void IncrementScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Use your new scene's name
    }
}
