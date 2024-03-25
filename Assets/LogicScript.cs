using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Logic : MonoBehaviour
{
    private int playerScore;
    public Text scoreTextBox;
    [SerializeField] private GameObject gameOverScreen;

    [ContextMenu("increase score")]
    public void addScore(int scoreToAdd=1)
    {
        playerScore += scoreToAdd;
        scoreTextBox.text= playerScore.ToString();
        Debug.Log("'increase score'");
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void restartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name); 
    }
}
