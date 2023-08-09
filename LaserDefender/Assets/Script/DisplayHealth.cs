using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayHealth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI HealthText;
    Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        Display();
    }

    void Display()
    {
        int Health = player.GetHealth();
        HealthText.text = Health.ToString();
    }
}
