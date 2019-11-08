using UnityEngine;
using UnityEngine.UI;

public class reset : MonoBehaviour
{
    float timeL;

    public Text timer;
    void Start()
    {
        timeL = 37.5f;
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Bakar_Head")
        {
            coll.gameObject.transform.position = Vector2.zero;
            timeL = 37.5f;
        }
    }
    void Update()
    {
        if (timeL <= 0)
        {
            GameObject.Find("Bakar_Head").transform.position = Vector2.zero;
            timeL = 37.5f;
        }
        else
        {
            timeL -= Time.deltaTime;
        }

        timer.text = ((int) timeL).ToString();
    }
}
