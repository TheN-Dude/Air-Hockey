using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalP : MonoBehaviour
{

    public GameObject pt2;
    public GameObject pt3;
    public GameObject Ept;
    public GameObject player;
    public GameObject Enemy;
    public GameObject Puck;
    public GameObject GE;
    public GameObject Hpts;
   

    public TMP_Text AiScore;
    public int NScore;

    Vector2 Pospuck;
    Vector2 PosPl;
    Vector2 PosE;

    GoalE cs_goalE;
    public GameObject LS;



    // Start is called before the first frame update
    void Start()
    {
        Pospuck = pt3.transform.position;
        PosPl = pt2.transform.position;
        PosE = Ept.transform.position;

        cs_goalE = GE.GetComponent<GoalE>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AiScore.text == "5")
        {
            LS.SetActive(true);

            Puck.SetActive(false);
            player.SetActive(false);
            Enemy.SetActive(false);
            Hpts.SetActive(false);

            player.transform.position = PosPl;
            Enemy.transform.position = PosE;
           Puck.transform.position = Pospuck;
         // AiScore.text = "0";
        }

       //f(cs_goalE.PlayerScore.text == "5")
       //
          //cs_goalE.PlayerScore.text = "0";
      //}




    }

    private void OnCollisionEnter2D(Collision2D puck)
    {
        if (puck.gameObject.tag == "Puck")
        {

            puck.gameObject.transform.position = Pospuck;
            puck.rigidbody.velocity = Vector2.zero;

            player.transform.position = PosPl;
            Enemy.transform.position = PosE;

            AiScore.text = (++NScore).ToString();


            Debug.Log("Collide Goal");
        }

       





    }

}
