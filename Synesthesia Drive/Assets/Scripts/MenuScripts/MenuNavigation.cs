using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNavigation : MonoBehaviour
{

   public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

   public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
