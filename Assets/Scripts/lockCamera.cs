using UnityEngine;
using Cinemachine;
public class lockCamera : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D coll)
    {
        if (coll.gameObject.name == "bakarW")
        {
            GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>().Follow = null;
        }
    }
}
