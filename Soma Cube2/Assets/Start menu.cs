using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Startmenu : MonoBehaviour
{
   
    public GameObject HelpMenuUI;
    public GameObject pauseMenuUI;
    // Start is called before the first frame update

    private void Start()
   {
       
        { 
            HelpMenuUI.SetActive(false); 
        }

    }
    public  void Help()
    {

        Debug.Log("help button is working");
        
        HelpMenuUI.SetActive(true);

        pauseMenuUI.SetActive(false);
    }
        public void Close()
    {
        Debug.Log("Close button is working");
        HelpMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);

    }
}
