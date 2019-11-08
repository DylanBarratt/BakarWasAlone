using UnityEngine;
using UnityEngine.UI;

public class pabtcFlash : MonoBehaviour
{
    public Texture2D b, s;
    void Start()
    {
        Invoke("Flash1", 0.5f);
    }
    void Flash1()
    {
        gameObject.GetComponent<RawImage>().texture = b;
        Invoke("Flash2", 0.5f);
    }
    void Flash2()
    {
        gameObject.GetComponent<RawImage>().texture = s;
        Invoke("Flash1", 0.5f);
    }
}
