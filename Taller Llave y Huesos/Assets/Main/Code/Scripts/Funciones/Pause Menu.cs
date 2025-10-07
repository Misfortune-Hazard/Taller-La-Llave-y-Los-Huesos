using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject Pausemenu;


    void Start()
    {
        Pausemenu.SetActive(false);
    }

    public void PauseG()
    {
        Pausemenu.SetActive(true);
        Time.timeScale = 0;
    

    }

    public void ResumeG()
    {
        Pausemenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void QuitG()
    {
        Application.Quit(); 
    }

    public void GotoMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
          
    }

}
