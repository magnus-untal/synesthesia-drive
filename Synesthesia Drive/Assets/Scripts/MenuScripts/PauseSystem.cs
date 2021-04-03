using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseSystem : MonoBehaviour
{
    bool pause = false;
    public GameObject pauseMenu;


    public void PauseGame()
    {
        
            pauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0f;
            AudioSource[] music = FindObjectsOfType<AudioSource>();

            foreach (AudioSource a in music)
            {
                a.Pause();
            }
        
    }

    public void ResumeGame()
    {
            
            pauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1f;
            AudioSource[] music = FindObjectsOfType<AudioSource>();

            foreach (AudioSource a in music)
            {
                a.Play();
            }
        
    }

    public void LeaveLevel()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }



    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;
            if (pause)
            {
                PauseGame();

            }
            else if (!pause)
            {
                ResumeGame();
            }
        }

    }
}
