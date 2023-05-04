using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    public GameObject OtherTel;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D puck)
    {
        
        if (puck.gameObject.tag == "Puck")
        {

            puck.gameObject.transform.position = OtherTel.transform.position;
          

           
        }


    }





}
