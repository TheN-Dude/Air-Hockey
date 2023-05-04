using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{

    public GameObject puck;
    Rigidbody2D rb;
    Vector2 targetPos;
    Vector2 startingposition;
    float MoveSpeed;


    Vector2 AiPos;
    float XAiPos;
    float YAiPos;

    float PuckX;
    float PuckY;

    public GameObject Line;
    public GameObject RB;
    public GameObject TB;
    public GameObject BB;
    public GameObject AiRest;

    Vector2 clampedAi;

    PlayerMovement cs_PM;
    public GameObject player;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cs_PM = player.GetComponent<PlayerMovement>();
    } 

    // Update is called once per frame
    void Update()
    {
            AiPos = transform.position;

            XAiPos = transform.position.x;
            YAiPos = transform.position.y;
            PuckX = puck.transform.position.x;
            PuckY = puck.transform.position.y;
        


        Vector2 RightB = RB.transform.position;
        Vector2 Lne = Line.transform.position;
        Vector2 TopB = TB.transform.position;
        Vector2 BotB = BB.transform.position;
        // AiPos = Vector2.Lerp(AiPos, puck.transform.position ,MoveSpeed * Time.deltaTime);

        MoveSpeed = Random.Range(10f, 20f);

        if(PuckX < Lne.x)
        {
            XAiPos = Mathf.Lerp(XAiPos, AiRest.transform.position.x, MoveSpeed * Time.fixedDeltaTime);

            YAiPos = Mathf.Lerp(YAiPos, PuckY, 50f * Time.fixedDeltaTime);

        }
        else
        {
            XAiPos = Mathf.Lerp(XAiPos, PuckX, MoveSpeed * Time.fixedDeltaTime);
            YAiPos = Mathf.Lerp(YAiPos, PuckY, 100f * Time.fixedDeltaTime);
        }

       
      
        clampedAi = new Vector2(Mathf.Clamp(XAiPos, Lne.x,RightB.x), Mathf.Clamp(YAiPos, BotB.y, TopB.y));

        rb.MovePosition(clampedAi);

     


    }

 // public void OnCollisonEnter(Collision2D puck)
//  {
 //     if (puck.gameObject.tag == "Puck")
  //    {
 //         cs_PM.CollideScore = 1;

 //     }

        

 // }


}
