using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Startmenuscript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pauseMenuUI;


    public static bool paused = true;
    // Update is called once per frame
    void Update()
    {
        
    }



    void Pause()

    {
        pauseMenuUI.SetActive(true); //Picks which UI shows up.
        Time.timeScale = 0; //speed of time, at 0 it is totally still
        paused = true;


    }


    public void Resume() //public so the button can access it
    {
        pauseMenuUI.SetActive(false); //pause menu dissapears
        Time.timeScale = 1f; // time is back to normal now
        paused = false;


    }

    public void QuitGame()
    {
        Debug.Log("quitgame");
        Application.Quit();
    }


}


