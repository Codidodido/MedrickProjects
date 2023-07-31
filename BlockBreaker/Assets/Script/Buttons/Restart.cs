using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartGame()
    {
        List<int> levelsList = FindObjectOfType<GameStatus>().GetLevel();
        if(levelsList != null)
        {
            SceneManager.LoadScene(levelsList[levelsList.Count - 1]);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
        
    }
}
