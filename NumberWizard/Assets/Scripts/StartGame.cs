using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] NumberWizardHandeler general;
    
    [SerializeField] TextMeshProUGUI Displayer;
    [SerializeField] GameObject Box;
    private void OnMouseDown()
    {
        general.Guess();
        Displayer.text = "";

        Box.SetActive(true);

        this.gameObject.SetActive(false);
    }

    
}
