using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPts : MonoBehaviour
{
    public GameObject GP;
    public GameObject GE;
    public GameObject puck;

    GoalP cs_GoalP;
    GoalE cs_GoalE;
    int TriggerScore;

    Puck cs_puck;

    // Start is called before the first frame update
    void Start()
    {
        cs_GoalP = GP.GetComponent<GoalP>();

        cs_GoalE = GE.GetComponent<GoalE>();


        cs_puck = puck.GetComponent<Puck>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Puck")
        {
            
                cs_GoalE.NScore++;
                cs_GoalE.PlayerScore.text = cs_GoalE.NScore.ToString();
            
            
               

  
           

        }
    }

   


}
