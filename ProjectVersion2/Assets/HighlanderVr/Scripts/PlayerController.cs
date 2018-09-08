using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;
    public static int score;
    private Rigidbody rb;
    HitOnTarget ht;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        SetCountText();
        winText.text = "win!!";
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            score = score + 10;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Score: " + score.ToString();
        if (score >= 12)
        {
            winText.text = "You Win!";
        }
    }

}
