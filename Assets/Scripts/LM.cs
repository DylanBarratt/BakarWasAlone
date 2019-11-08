using UnityEngine;

public class LM : MonoBehaviour
{
    void Start()
    {
        transform.position = new Vector2(transform.position.x, GameObject.Find("Bakar_P").transform.position.y + 1.5f);
    }
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, GameObject.Find("Bakar_P").transform.position.y + 1.5f);
    }
}
