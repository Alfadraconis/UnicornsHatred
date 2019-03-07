using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EmptyFlip : MonoBehaviour
{

    public GameObject Shootpoint;

    public float PlayerM;
    public float dirxx;

    void Start()
    {

        PlayerM= GetComponent<PlayerMovement>();
        dirxx = PlayerMovement.dirx;
    }
        
   

    // Update is called once per frame
    void Update(){
        if (dirxx > 0){
            ShootPoint.transform.Rotate(0f, 180f, 0f);
        }
        else if (dirxx < 0){
            Shootpoint.transform.Rotate(0f, 180f, 0f);
        }
    }
}
