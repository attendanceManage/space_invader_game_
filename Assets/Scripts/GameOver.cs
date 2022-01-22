using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

  public static GameOver instance = null;
  public static bool isPlayerDead = false;
  private void Awake()
  {
        if(instance==null)
        {
           instance=this;
           DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    
    }

  //public Text gameOver;

    // Start is called before the first frame update
    void Start()
    {
       // gameOver = GetComponent<Text>();
       // gameOver.enabled = false; // Ensures gameOver text is shown at the start

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerDead)
        {
            Time.timeScale = 0; // Pauses everything
           // gameOver.enabled = true; // gameOver text shown
        }
    }
}
