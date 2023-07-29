using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class High : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] NumberWizardHandeler general;
    private void OnMouseDown()
    {
        general.Min = general.guess;
        general.Guess();
    }
}
