using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Bakar_P")
        {
            SceneManager.LoadScene("WalkingInTheRain");

        }
    }
}
