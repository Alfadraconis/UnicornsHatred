using UnityEngine;
using System.Collections;

public class PlataformaBullet : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            Destroy(target.gameObject);
            Destroy(gameObject);
        }

        if (target.tag == "Ground")
        {
            Destroy(gameObject);
        }

    }

}
