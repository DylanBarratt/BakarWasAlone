using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nextImage : MonoBehaviour
{
    int imageNum;

    public Texture2D[] imagesV;

    public AudioClip[] soundsV;
    void Update()
    {
        if (imageNum < imagesV.Length)
        {
            if (Input.anyKeyDown)
            {
                gameObject.GetComponent<AudioSource>().loop = false;
                if (GameObject.Find("pabtc") != null)
                {
                    Destroy(GameObject.Find("pabtc"));
                    imageNum = 0;
                }      
            }
        }

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
                SceneManager.LoadScene("Main");
            }
        }
    }
}
