using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    Vector2 Mpos;
    Rigidbody2D rb;
    public GameObject Line;
    public GameObject LB;
    public GameObject TB;
    public GameObject BB;
    public GameObject GP;
    public GameObject GE;
    public GameObject enemy;

    GoalP cs_GoalP;
    GoalE cs_GoalE;
    int Nscore;
    public int DataCS = 0;
    public int CollideScore;

    //public Transform BoundHold;

    //Boundries playerbound;

    //struct Boundries
    //{
    //public float Up, Down, Left, Right;

    //public Boundries(float up, float down, float left, float right)
    //{
    // Up = up;
    //Down = down;
    // Left = left;
    //Right = right;
    //}
    //}



    // Start is called before the first frame update
    void Start()
    {

       rb = GetComponent<Rigidbody2D>();
        //playerbound = new Boundries(BoundHold.GetChild(0).position.x, BoundHold.GetChild(1).position.y, BoundHold.GetChild(2).position.x, BoundHold.GetChild(3).position.y);
        cs_GoalP = GP.GetComponent<GoalP>();

        cs_GoalE= GE.GetComponent<GoalE>();
    }

    // Update is called once per frame
    void Update()
    {
        Mpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 LeftB = LB.transform.position;
        Vector2 Lne = Line.transform.position;
        Vector2 TopB = TB.transform.position;
        Vector2 BotB = BB.transform.position;




        if (Input.GetMouseButton(0))
        {
            Vector2 clampedMpos;


            clampedMpos = new Vector2(Mathf.Clamp(Mpos.x, LeftB.x, Lne.x), Mathf.Clamp(Mpos.y, BotB.y, TopB.y));

           


            rb.MovePosition(clampedMpos); //this makes the movement have a force affect(Physics)
            Debug.Log("Right click");
        }

        Debug.Log(DataCS);


       

    }
// public void OnCollisionEnter2D(Collision2D puck)
 // {
  //    if (puck.gameObject.tag == "Puck")
   //   {
            
   //       DataCS = (++CollideScore);

   //       if(DataCS >2)
   //      {
  //            cs_GoalE.PlayerScore.text = (--Nscore).ToString();

               
    //      }


    //  }

//  }

  

   

}
