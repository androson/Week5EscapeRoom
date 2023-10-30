using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{
    public GameObject PausePanell;

   


    private void Start()
    {
       // PausePanell.SetActive(false);
    }

    void update()
    {
        //Pause();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanell.gameObject.SetActive(true);
            
        }


    }

     public void Pause()
    {
        if (Input.GetKey(KeyCode.B))
        {
            PausePanell.SetActive(true);
        }
   
    }

    public void ButtonPause()
    {
        PausePanell.SetActive(true);
        
    }

     public void Resume()
    {
        PausePanell.SetActive(false);
        
    }

    public void GoBackMenu()
    {
        SceneManager.LoadScene(0);

    }
}
