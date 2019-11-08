using UnityEngine;

public class sadMove : MonoBehaviour
{
    private float speed = 4f;
    void FixedUpdate()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);

        if (transform.position.y <= -6.5f)
        {
            Destroy(gameObject);
        }

        Collider2D[] cNear = Physics2D.OverlapCircleAll(transform.position, 1f);
        if (cNear.Length > 0)
        {
            foreach (Collider2D x in cNear)
            {
                if (x.gameObject != gameObject)
                {
                    if (x.gameObject.tag == "SAD")
                    {
                        Destroy(x.gameObject);
                    }
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "SAD")
        {
            if (transform.position.y < coll.gameObject.transform.position.y)
            {
                Destroy(coll.gameObject);
            }
        }
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("PLAYERDED");

            coll.gameObject.transform.position = new Vector2(0, 0);

            GameObject[] sads = GameObject.FindGameObjectsWithTag("SAD");

            for (int i = 0; i < sads.Length; i++)
            {
                Destroy(sads[i]);
            }

            Movement2.amountSpawned = 0;
        }
    }
}
