using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("aaaa");
    }

    // Update is called once per frame
    void Update()
    {
        
    
     }
    public void ExitButton(){
        Application.Quit();
    }

    public void StartGame(){
     
        SceneManager.LoadScene("SpaceInvaders");
    }

      public void ReStartGame(){
     
        SceneManager.LoadScene("MainMenu");
    }
}
