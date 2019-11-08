using UnityEngine;

public class movement4 : MonoBehaviour
{
    public static bool freeze;
    void Start()
    {
        freeze = false;
    }
    void FixedUpdate()
    {
        if (freeze == false)
        {
            if (Input.GetAxisRaw("Horizontal") > 0.1f)
            {
                transform.position = new Vector2(transform.position.x + 0.05f * Input.GetAxisRaw("Horizontal"), transform.position.y);
                gameObject.GetComponent<Animator>().Play("walk");
            }else
                gameObject.GetComponent<Animator>().Play("still");
        }
    }
}
