using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextDisplayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string text;
    [SerializeField] TextMeshProUGUI Displayer;
    private float delay = 0.05f;
    
    void Start()
    {
        text = text.Replace("\\n", "\n");
        StartCoroutine(Write());
    }

    // Update is called once per frame
    void Update()
    {   
    }

    IEnumerator Write()
    {
        for(int i = 0; i < text.Length; i++)
        {
            Displayer.text += text[i];
            yield return new WaitForSeconds(delay);
        }
    }
}
