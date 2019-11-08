using UnityEngine;

public class Movement3 : MonoBehaviour
{
    public AudioClip I1;

    private bool move;
    void Start()
    {
        move = false;
        Invoke("Cs", 2f);
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
    void Cs()
    {
        move = true;
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
        gameObject.GetComponent<AudioSource>().clip = I1;
        gameObject.GetComponent<AudioSource>().Play();
        gameObject.GetComponent<AudioSource>().loop = true;
    }

    void FixedUpdate()
    {
        if (move == true)
        {
            transform.position = new Vector2(transform.position.x + 0.1f * Input.GetAxisRaw("Horizontal"), transform.position.y + 0.1f * Input.GetAxisRaw("Jump"));
        }
    }
}
