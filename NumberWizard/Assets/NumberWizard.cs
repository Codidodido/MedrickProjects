using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] int max, min,guess,turn;
    void Start()
    {
        Debug.Log("Welcome to Number Wizard game .");
        StartGame();
    }

    void StartGame()
    {
        min = 1; max = 1000; turn = 0;
        
        Debug.Log($"Think about a number between {min} & {max}: ");
        
        Debug.Log("!: If gussed number is lower than your number press 'DownKey' / higher press 'UpKey' / correct press 'Enter'");
        Guess();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = (min + max) / 2;
            Guess();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = (max + min) / 2;
            Guess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log($"Correct Number!!! It is {guess}. | Gussed in {turn} turn ^_^");
            Debug.Log("Play Again");
            StartGame();
        }
    }

    void Guess()
    {
        turn++;
        guess = (min + max) / 2;
        Debug.Log($"Gussed number -> {guess}");
    }
}
