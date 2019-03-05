using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("player"))
        {
            EnemySmoke.isAttacking = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("player"))
        {
            EnemySmoke.isAttacking = false;
        }
    }
}
