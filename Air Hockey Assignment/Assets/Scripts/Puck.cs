using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour


{

     public bool Colli = false;

    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Colli = true;


    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        Colli = false;
    }

}
