using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private bool OnOff = false;
    public Canvas mainMenu;

    public void Switch()
    {
        if(OnOff == false)
        {
            mainMenu.transform.Translate(450, 0,0);
            OnOff = true;
        }
        else
        {
            mainMenu.transform.Translate(-450, 0, 0);
            OnOff = false;
        }    
    }

    public void GoToMarkers()
    {
        SceneManager.LoadScene("Markers");
    }

    public void GoMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
