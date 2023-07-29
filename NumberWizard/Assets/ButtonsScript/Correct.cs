using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Correct : MonoBehaviour
{
    [SerializeField] NumberWizardHandeler general;
    [SerializeField] TextMeshProUGUI TEXT;
    private void OnMouseDown()
    {
        TEXT.text = "I gussed Trueeeeeeeeeeeeee ;D";
        
    }
}
