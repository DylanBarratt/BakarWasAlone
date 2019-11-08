using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class Movement2 : MonoBehaviour
{
    public GameObject sad, wih;

    private float spawnSpeed;

    private bool started;

    public static int amountSpawned;

    public AudioClip change, rain;

    void Start()
    {
        Invoke("Spawn1", 3);
        started = true;
        gameObject.GetComponent<AudioSource>().clip = change;
        gameObject.GetComponent<AudioSource>().Play();
        amountSpawned = 0;
        spawnSpeed = 0.1f;
    }
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x + 0.05f * Input.GetAxisRaw("Horizontal"), transform.position.y);
        spawnSpeed -= 0.001f * Time.deltaTime;
        if (amountSpawned >= 300)
        {
            GameObject[] sads = GameObject.FindGameObjectsWithTag("SAD");
            if (sads.Length == 0)
            {
                SceneManager.LoadScene("InsideBuilding");
            }
        }

        if (gameObject.GetComponent<AudioSource>().isPlaying == false)
        {
            if (gameObject.GetComponent<AudioSource>().clip != rain)
            {
                gameObject.GetComponent<AudioSource>().clip = rain;
                gameObject.GetComponent<AudioSource>().loop = true;
                gameObject.GetComponent<AudioSource>().Play();
            }
        }

        if (started == false)
        {
            if (amountSpawned == 0)
            {
                Invoke("Spawn1", 3);
                started = true;
            }
        }
    }
    void Spawn1()
    {
        started = false;
        Debug.Log(amountSpawned);
        if(amountSpawned < 300)
        {
            Instantiate(sad, new Vector2(Random.Range(-12, 12), Random.Range(15, 20)), sad.transform.rotation);
            amountSpawned += 1;
            Invoke("Spawn2", spawnSpeed);
        }
    }
    void Spawn2()
    {
        Debug.Log(amountSpawned);
        if (amountSpawned < 300)
        {
            Instantiate(sad, new Vector2(Random.Range(-12, 12), Random.Range(15, 20)), sad.transform.rotation);
            amountSpawned += 1;
            Invoke("Spawn1", spawnSpeed);
        }
    }
}
