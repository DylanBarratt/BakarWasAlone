using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Bakar_Head")
        {
            SceneManager.LoadScene("Room");
        }
    }
}
