using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class up : MonoBehaviour
{
    public Sprite front;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "bakarW")
        {
            coll.gameObject.GetComponent<SpriteRenderer>().sprite = front;
            coll.gameObject.GetComponent<Animator>().Play("close");
            GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>().Follow = null;
            movement4.freeze = true;
            coll.gameObject.GetComponent<Animator>().Play("close");
            coll.gameObject.transform.position = new Vector3(47.441f, 0.006f, 0f);
            coll.gameObject.transform.localScale = new Vector3(3.195f, 3.174f, 1f);
            Invoke("NextScene", 1.5f);
        }
    }
    void NextScene()
    {
        SceneManager.LoadScene("Platform");
    }
}
