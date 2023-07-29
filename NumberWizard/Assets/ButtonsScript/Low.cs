using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Low : MonoBehaviour
{
    [SerializeField] NumberWizardHandeler general;
    private void OnMouseDown()
    {
        general.Max = general.guess;
        general.Guess();
    }
}
