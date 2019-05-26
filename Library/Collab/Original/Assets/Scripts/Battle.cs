using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    bool move1;
    Javachu j;
    Nohtyp p;
    TurnManager t;
    bool move2;
    int moveCount1;
    int  moveCount2;
    bool b;
    // Start is called before the first frame update
    void Start()
    {
        t=GameObject.Find("TurnManager").GetComponent<TurnManager>();
        p = GameObject.Find("HealthBar2").GetComponent<Nohtyp>();
        j = GameObject.Find("HealthBar1").GetComponent<Javachu>();
        bool b=t.getTurn();
        move1 = false;
        move2 = false;
        moveCount2 = -1;
        moveCount1 = -1;
        //move1 is if player 1 input a move and move2 is if player 2 input a move
    }

    // Update is called once per frame
    void Update()
    {
        if(b){
            if (UnityEngine.Input.GetKey(KeyCode.W))
            {
                moveCount1 = 0;
                move1 = true;
            }
            else if (UnityEngine.Input.GetKey(KeyCode.S))
            {
                moveCount1 = 1;
                move1 = true;
            }
            else if (UnityEngine.Input.GetKey(KeyCode.A))
            {
                moveCount1 = 2;
                move1 = true;

            }
            else if (UnityEngine.Input.GetKey(KeyCode.D))
            {
                moveCount1 = 3;
                move1 = true;
            }
            if (move1)
            {
                p.takeDmg(j.getMove(moveCount1));
                t.changeTurn();
            }
        }

        else{
            if (UnityEngine.Input.GetKey(KeyCode.UpArrow))
            {
                moveCount2 = 0;
                move2 = true;
            }   
            else if (UnityEngine.Input.GetKey(KeyCode.DownArrow))
            {
                moveCount2 = 1;
                move2 = true;
            }
            else if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))
            {
                moveCount2 = 2;
                move2 = true;

            }
            else if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
            {
                moveCount2 = 3;
                move2 = true;
            }
            if(move2){
                j.takeDmg(p.getMove(moveCount2));
                t.changeTurn();
            }
        }        
    }
}

