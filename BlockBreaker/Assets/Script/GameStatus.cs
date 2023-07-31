using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStatus : MonoBehaviour
{
    // Start is called before the first frame update

    [Range(0f,10f)][SerializeField] float GameSpeed = 1f;
    [SerializeField] int ScorePayBlock = 88;
    [SerializeField] int CurrentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] List<int> Levels;

    void Start()
    {    
        scoreText.text = CurrentScore.ToString();
        //AddLevel(SceneManager.GetActiveScene().buildIndex);
    }

    private void Awake()
    {
        
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = GameSpeed;
    }

    public void AddScore()
    {
        CurrentScore += ScorePayBlock;
        scoreText.text = CurrentScore.ToString();
    }

    public void Restart()
    {
        Destroy(gameObject);
    }

    public void AddLevel(int levelIndex)
    {
        Levels.Add(levelIndex);
    }

    public List<int> GetLevel()
    {
        return Levels;
    }

    
}
