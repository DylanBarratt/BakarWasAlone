using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;
public class loveSee : MonoBehaviour
{
    public Sprite turned;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "bakarW")
        {
            GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>().Follow = null;
            Invoke("Turn", 1f);
            movement4.freeze = true;
        }
    }
    void Turn()
    {
        Debug.Log("");
        GameObject.Find("bakarW").GetComponent<Animator>().enabled = false;
        GameObject.Find("bakarW").transform.localScale = new Vector2(2.3f, 2.3f);
        GameObject.Find("bakarW").GetComponent<SpriteRenderer>().sprite = turned;
        Invoke("final", 0.3f);
    }
    void final()
    {
        SceneManager.LoadScene("final");
    }
}

