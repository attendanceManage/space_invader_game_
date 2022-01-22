using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper instance;
    public int score= 0;
    private Text secoreText;

   
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
   
    // Start is called before the first frame update
    void Start()
    {
        secoreText=this.GetComponent<Text>();
        Reset();
        secoreText.text=score.ToString();

    }

    // Update is called once per frame
    public void ChangeScore(int points)
    {
          score+=points;
          secoreText.text=score.ToString();
     }

    public static void Reset()
    {
      ScoreKeeper.instance.score=0;
   
    }

 
    
}
