using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void Start()
    {
        
    }
    public string currentCoin = "RedCoin";
    public PlayerScript playerScript;
    public GameController gameController;
    public AudioSource collectSound;
    public AudioSource gameoverSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == currentCoin)
        {
            collectSound.Play();
            FindAnyObjectByType<UpdateScore>().addScore();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag != currentCoin) {
            playerScript.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Ground")
        {
            gameoverSound.Play();
            playerScript.enabled = false;
            gameController.showGameOverScreen();
        }
    }


}
