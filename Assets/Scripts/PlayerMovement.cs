using TMPro;
using Unity.Mathematics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRigidbody;
    [SerializeField] private int speed;
    [SerializeField] private int score;
    [SerializeField] private TMP_Text scoreText;

    private void Start()
    {
        IncreseScore(0);
    }

    private void FixedUpdate()
    {
        playerRigidbody.linearVelocity=Vector3.zero;

        if (Input.GetKey(KeyCode.A) && transform.position.x >-7){
            Move(Vector2.left);
        }
       if(Input.GetKey(KeyCode.D) && transform.position.x < 7)
        {
            Move(Vector2.right);
        }
    }

    public void IncreseScore(int amount) {
        score += amount;
        scoreText.text = score.ToString();
    }

    private void Move(Vector2 direction) {
        direction.Normalize();  
        Vector2 target = direction * speed;
        playerRigidbody.linearVelocity = Vector2.Lerp(playerRigidbody.linearVelocity, target, 70 * Time.deltaTime);
    }

}
