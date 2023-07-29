using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void OnMouseDown()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        // Implement restart logic here
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
