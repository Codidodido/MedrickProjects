using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int Score;
    [SerializeField] int Health;
    public int GetScore()
    {
        return Score;
    }
    public void AddScore(int number)
    {
        Score += number;
    }

    public void Reset()
    {
        Score = 0;
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
