using UnityEngine;

public class Movement1 : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 0.1f * Input.GetAxisRaw("Vertical"));
    }
}
