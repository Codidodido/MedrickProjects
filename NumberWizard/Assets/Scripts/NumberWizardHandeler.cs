using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberWizardHandeler : MonoBehaviour
{
    // Start is called before the first frame update
    public int Min = 0, Max = 1000,guess;
    [SerializeField] TextMeshProUGUI TEXT;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Guess()
    {
        guess = (Min + Max) / 2;
        TEXT.text = "Guess: "+guess.ToString();
    }
}
