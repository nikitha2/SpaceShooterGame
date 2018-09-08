
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HitOnTarget : MonoBehaviour
{

    public ParticleSystem explosive;
    private Boolean isFired = false;
    private AudioClip soundOfExplosion;
    private GvrAudioSource source;
    private static int score=0;
    public Text countText;
    public Text winText;
    string scoreText;

    void Start()
    {
        
        SetCountText();
        winText.text = "win!!";
    }

    void SetCountText()
    {
       //Debug.Log("------------------score-----------------" + score+ "---------------score.ToString---------" + score.ToString() +"----"+ scoreText);
        scoreText = score.ToString();
       // countText.text = "Score: " + scoreText;
        //Debug.Log("------------------score-----------------" + score + "---------------score.ToString---------" + score.ToString() + "----" + scoreText);

        //if (score >= 10000)
       // {
         //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //}
    }

    private void Awake()
    {
        source = GetComponent<GvrAudioSource>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        

        if (!isFired)
            {
            Debug.Log("Collided");
            if (collision.gameObject.tag == "Meteor")
            {
                Debug.Log("score: "+ score);
                Destroy(collision.gameObject);

                ParticleSystem explosion = Instantiate(explosive, gameObject.transform.position, gameObject.transform.rotation) as ParticleSystem;
              

                source.PlayOneShot(soundOfExplosion,100f);

                Destroy(gameObject);
                score = score + 10;
                SetCountText();

                if (gameObject == null && collision.gameObject == null)
                    {
                        isFired = true;
                    }
            }
        }
    }
}
