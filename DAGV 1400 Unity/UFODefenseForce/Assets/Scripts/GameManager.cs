using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    
    private GameObject gameOverText;

    private void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameOverText = GameObject.Find("GameOverText");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isGameOver)
        {
            EndGame(); // Start EndGame method
        }
        else
            gameOverText.gameObject.SetActive(false); // Keeps GameOver text hidden
    }

    public void EndGame()
    {
        gameOverText.gameObject.SetActive(true); // Make game over text appear
        
        Time.timeScale = 0; // Freeze time/end game
    }
}
