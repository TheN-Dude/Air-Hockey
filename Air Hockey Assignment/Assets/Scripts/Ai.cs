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
    public GameObject GP;
    public GameObject GE;

    Vector2 clampedAi;

    PlayerMovement cs_PM;
    public GameObject player;

    GoalP cs_GoalP;
    GoalE cs_GoalE;

    

   // public int CollideScore;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        cs_PM = player.GetComponent<PlayerMovement>();

      //  cs_GoalP = GP.GetComponent<GoalP>();

      //  cs_GoalE = GE.GetComponent<GoalE>();
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
        // AiPos = Mathf.Lerp(AiPos, puck.transform.position ,MoveSpeed * Time.deltaTime);

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        


        if (collision.gameObject.tag == "Puck")
        {
           // CollideScore++;

           

           // if (CollideScore >= 2)
          //  {
               // cs_GoalP.NScore--;
                //cs_GoalP.AiScore.text = cs_GoalE.NScore.ToString();


          //  }

            cs_PM.CollideScore = 0;

            Debug.Log(cs_PM.CollideScore);


        }

   


    }





}
