using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Button gameOver;
    public Button levelComplete;
    public Text score,totalScore;
    public Image scoreImage;
    
    public static int scoreAmount;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        scoreAmount = 0;
    }

    public void GameOverMethod()
    {
        gameOver.gameObject.SetActive(true);
        scoreImage.gameObject.SetActive(false);
    }

    public void LevelCompleteMethod()
    {
        totalScore.text = scoreAmount.ToString();
        levelComplete.gameObject.SetActive(true);
        scoreImage.gameObject.SetActive(false);
    }

}
