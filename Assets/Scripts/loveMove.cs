using UnityEngine;

public class loveMove : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.position = GameObject.Find("bakarW").transform.position;
    }
}
