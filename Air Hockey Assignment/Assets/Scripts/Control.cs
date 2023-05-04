using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    public GameObject t;
    public GameObject OT;

    float currentTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
      
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;

        if (currentTime >= 15)
        {
            t.SetActive(true);
            OT.SetActive(false);
        }

        if (currentTime >= 30)
        {
            t.SetActive(false);
            OT.SetActive(true);
        }

        if(currentTime >= 45)
        {
            t.SetActive(true);
            OT.SetActive(false);
        }

        if(currentTime >= 60)
        {
            t.SetActive(false);
            OT.SetActive(true);
        }

     // Debug.Log(currentTime);

    }
}
