using UnityEngine;

public class credits : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown == true)
        {
            Application.Quit();
        }
    }
}
