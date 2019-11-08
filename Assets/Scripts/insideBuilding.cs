using UnityEngine;
using UnityEngine.SceneManagement;
public class insideBuilding : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "bakarW")
        {
            SceneManager.LoadScene("dodge");
        }
    }
}
