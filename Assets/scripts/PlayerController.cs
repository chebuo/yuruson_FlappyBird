using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float jumpForce=5;
    public static int score=0;
    public bool isGame=true;
    InputAction jumpAction;
    Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        jumpAction.Enable();
        rb2d = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(jumpAction.triggered)
        {
            rb2d.linearVelocityY = 0;
            rb2d.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            Debug.Log("Jump!");
        }
        if(transform.position.y<-7)
        {
            Debug.Log("Game Over!");
            isGame=false;
        }
        if(transform.position.y>7)
        {
            Debug.Log("Game Over!");
            isGame=false;
        }
        if (!isGame)
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            Debug.Log("Game Over!");
            isGame=false;
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("score"))
        {
            Debug.Log("Score!");
            score++;
        }
    }
}
