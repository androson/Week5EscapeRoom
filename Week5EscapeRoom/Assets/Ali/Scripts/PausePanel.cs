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
        


    }

     public void Pause()
    {
        
   
    }

    public void ButtonPause()
    {
        PausePanell.SetActive(true);
        
    }

     public void Resume()
    {
        PausePanell.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        
    }

    public void GoBackMenu()
    {
        SceneManager.LoadScene(0);

    }
}
