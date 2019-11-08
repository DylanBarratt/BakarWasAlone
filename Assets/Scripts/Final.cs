using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Final : MonoBehaviour
{
    bool started;

    int imageNum;

    public Texture2D[] imagesV;

    public AudioClip[] soundsV;
    void Start()
    {
        started = false;
        gameObject.GetComponent<RawImage>().enabled = false;
        Invoke("FStart", 3f);
    }
    void FStart()
    {
        GameObject[] d = GameObject.FindGameObjectsWithTag("Delete");
        for (int x = 0; x < d.Length; x++)
        {
            Destroy(d[x]);
        }

        gameObject.GetComponent<RawImage>().enabled = true;
        gameObject.GetComponent<AudioSource>().clip = soundsV[1];
        gameObject.GetComponent<AudioSource>().Play();
        started = true;
    }
    void Update()
    {
        if (started == true)
        {
            if (imageNum != 13)
            {
                if (gameObject.GetComponent<AudioSource>().isPlaying == false)
                {
                    imageNum += 1;
                    if (imagesV.Length != imageNum)
                    {
                        gameObject.GetComponent<RawImage>().texture = imagesV[imageNum];
                        gameObject.GetComponent<AudioSource>().clip = soundsV[imageNum];
                        gameObject.GetComponent<AudioSource>().Play();
                    }
                    else
                    {
                        Invoke("Credits", 7.5f);
                    }
                }
            }
        }
    }
    void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
