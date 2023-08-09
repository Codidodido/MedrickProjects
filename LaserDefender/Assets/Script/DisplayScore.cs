using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayScore : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI ScoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Display();
    }

    void Display()
    {
        int Score = FindObjectOfType<GameSession>().GetScore();
        ScoreText.text = Score.ToString();
    }
}
