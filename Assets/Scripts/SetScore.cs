using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text text = this.GetComponent<Text>();
        text.text = ScoreKeeper.instance.score.ToString();
       // ScoreKeeper.Instance.Reset();
    }

    
}
