using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{

    float currentTime = 0f;
    float startTime = 5f;
     public GameObject CT;

    public TMP_Text TIMER;

    public GameObject Puck;
    public GameObject player;
    public GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1  * Time.deltaTime;


        TIMER.text = currentTime.ToString("0");

        if(currentTime <=0)
        {

            TIMER.text = "Start";

            Puck.SetActive(true);
            player.SetActive(true);
            Enemy.SetActive(true);
        }

        if(currentTime <= -0.5)
        {
            CT.SetActive(false);
        }

        
}
}
