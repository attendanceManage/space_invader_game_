using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script controls the behaviour of each single Alien enemy
public class EnemyBehaviour : MonoBehaviour
{

    public static EnemyBehaviour instance;
    // Start is called before the first frame update
    public int scoreValue = 10;
    private int scoreKeeper;
    public AudioClip audioEnemy;

    //  private void Awake()
    // {
    //     if(instance==null)
    //     {
    //        instance=this;
    //        DontDestroyOnLoad(gameObject);
    //     }
    //     else{
    //         Destroy(gameObject);
    //     }
    
    // }
    
 
    void Start()
    {
        //scoreKeeper  = GameObject.FindObjectOfType<ScoreKeeper>();
        //audio = GetComponent<AudioSource>();
  
    
    }

    void Update()
    {
      FireShoot();
       // audio = GetComponent<AudioSource>();
    
    }


    // Update is called once per frame


	// A function automatically triggerred when another game object with Collider2D component
	// Enters the Collider2D boundaries on this game object
    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
		// Check the tag on the other game object. If it's the projectile's tag,
		//  destroy both this game object and the projectile
      if (otherCollider.tag == "Projectile")
        {
           
            Destroy(gameObject);
            Destroy(otherCollider.gameObject);
            AudioSource.PlayClipAtPoint(audioEnemy,this.transform.position);
            ScoreKeeper.instance.ChangeScore(scoreValue);
          
           
            
       }else{
       }
    }


    void FireShoot()
    {
		// Create an instance of the GameObject referenced by the projectilePrefab variable
		// When the instance is created, position at the same location where the player currently is (by copying their transform.position),
		// and don't rotate the instance at all - let it keep its "identity" rotation
     //  if(Random.Range(0f,500f) < 1){
            /// Instantiate(enemyProjectile, gameObject.transform.position, Quaternion.identity) as GameObject;
       //}
      
        
    }

     
}
