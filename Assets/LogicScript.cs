using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject pauseMenuScreen;

   [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        if (playerScore % 5 == 0)
        {
            PipeMoveScript.SpeedUp(PipeMoveScript.moveSpeed / 2); //50% Speed Increase
            PipeSpawnScript.globalSpawnCooldown *= 0.75f; //25% decrease in spawn cooldown
        }

    }
 
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void pauseGame()
    {
        Time.timeScale = 0f;
        pauseMenuScreen.SetActive(true);
    }

    public void resumeGame()
    {
        pauseMenuScreen.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void quitGame()
    {
        Debug.Log("Closing Game...");
        Application.Quit();
    }
}
