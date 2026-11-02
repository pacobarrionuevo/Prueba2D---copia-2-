using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D platformRB;
    [SerializeField] private float platformSpeed;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            platformRB.velocity = new Vector2(platformSpeed, platformRB.velocity.y);
        }

        if (collision.CompareTag("Platform"))
        {
            platformRB.velocity *= -1f;
        }
    }
}
