using UnityEngine;
using UnityEngine.SceneManagement;
public class platformerStart : MonoBehaviour
{
    public AudioClip I1;
    void Start()
    {
        Invoke("LoadNScene", 3f);
        gameObject.GetComponent<AudioSource>().clip = I1;
        gameObject.GetComponent<AudioSource>().Play();
    }

    void LoadNScene()
    {
        SceneManager.LoadScene("Platform");
    }
}
