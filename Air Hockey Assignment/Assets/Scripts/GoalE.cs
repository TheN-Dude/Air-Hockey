using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalE : MonoBehaviour
{
    public GameObject pt1;
    public GameObject Ppt;
    public GameObject pt4;
    public GameObject enemy;
    public GameObject player;
    public GameObject WS;
    public GameObject Puck;
    public GameObject GP;

    GoalP cs_GoalP;

    public TMP_Text PlayerScore;
    int NScore;

    Vector2 Pospuck;
    Vector2 PosPE;
    Vector2 PosP;
   

    // Start is called before the first frame update
    void Start()
    {
        Pospuck = pt1.transform.position;
        PosPE = pt4.transform.position;
        PosP = Ppt.transform.position;

        cs_GoalP = GP.GetComponent<GoalP>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerScore.text == "5")
        {
            WS.SetActive(true);

            Puck.SetActive(false);
            player.SetActive(false);
            enemy.SetActive(false);

            enemy.transform.position = PosPE;
            player.transform.position = PosP;
            Puck.transform.position = Pospuck;
           //layerScore.text = "0";
        }
        // (cs_GoalP.AiScore.text == "5")
        //
           //s_GoalP.AiScore.text = "0";
       //

        

    }


    private void OnCollisionEnter2D(Collision2D puck)
    {
        if(puck.gameObject.tag == "Puck")
        {
           
            puck.gameObject.transform.position = Pospuck;
            puck.rigidbody.velocity = Vector2.zero;

            enemy.transform.position = PosPE;

            player.transform.position = PosP;
            

            PlayerScore.text = (++NScore).ToString();  //the .ToString() converts the integer NScore to a string. Nscore is also being ++(incremeted).

            Debug.Log("Collide Goal");


        }

       

    }

        
    
}
