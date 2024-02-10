using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class logiScript : MonoBehaviour
{
  
    public int playerScore;
    public Text scoreText;
    public GameObject gameovrscrn;
    [ContextMenu("addscore")]
    public void addScore(int scoreToAdd)
        {

            playerScore = playerScore+scoreToAdd;
            scoreText.text = playerScore.ToString();



        }
    
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameovrscrn.SetActive(true);
    }
}
