using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    bool move1;
    Javachu player1;
    Nohtyp player2;
    public GameObject j;
    public GameObject p;
    bool move2;
    int moveCount1;
    int moveCount2;
    bool player;
    // Start is called before the first frame update
    void Start()
    {
        player1 = j.GetComponent<Javachu>();
        player2 = p.GetComponent<Nohtyp>();
        Debug.Log("test?" + player1.getHealth());
        move1 = false;
        move2 = false;
        player = true;
        //move1 is if player 1 input a move and move2 is if player 2 input a move
    }

    // Update is called once per frame
    void Update()
    {
        if (getTurn())
        {
            if (UnityEngine.Input.GetKey(KeyCode.W))
            {
                moveCount1 = 1;
                move1 = true;
            }
            else if (UnityEngine.Input.GetKey(KeyCode.S))
            {
                moveCount1 = 2;
                move1 = true;
            }
            else if (UnityEngine.Input.GetKey(KeyCode.A))
            {
                moveCount1 = 3;
                move1 = true;

            }
            else if (UnityEngine.Input.GetKey(KeyCode.D))
            {
                moveCount1 = 4;
                move1 = true;
            }
            if (move1)
            {
                Debug.Log("WASD attack");/*
                Move one = player1.getMove(moveCount1);
                player2.damage(player2.getHealth() - one.getDamage());*//*
                player1.transform.position -= new Vector3(1F, 0.5F, 0F);
                player1.attackAnim(0.25);
                if (!player1.getCooldown())
                {
                    player1.transform.position += new Vector3(1F, 0.5F, 0F);
                }*/
                Debug.Log("Player 1: " + player1.getHealth() + " Player 2: " + player2.getHealth());
                player1.attackAnimStart(0.25);
                if (moveCount1 == 1)
                {
                    player2.damage(player1.attackOne()[0]);
                    player1.damage(player1.attackOne()[1]);
                }
                else if (moveCount1 == 2)
                {
                    player2.damage(player1.attackTwo()[0]);
                    player1.damage(player1.attackTwo()[1]);
                }
                else if (moveCount1 == 3)
                {
                    player2.damage(player1.attackThree()[0]);
                    player1.damage(player1.attackThree()[1]);
                }
                else if (moveCount1 == 4)
                {
                    player2.damage(player1.attackFour()[0]);
                    player1.damage(player1.attackFour()[1]);
                }
                changeTurn();
            }
            if (player1.getHealth() > player1.getMaxHealth())
            {
                player1.setHealth(player1.getMaxHealth());
            }
            Debug.Log("Player 1: " + player1.getHealth() + " Player 2: " + player2.getHealth());
        }
        if (!getTurn())
        {
            if (UnityEngine.Input.GetKey(KeyCode.UpArrow))
            {
                moveCount2 = 1;
                move2 = true;
            }
            else if (UnityEngine.Input.GetKey(KeyCode.DownArrow))
            {
                moveCount2 = 2;
                move2 = true;
            }
            else if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))
            {
                moveCount2 = 3;
                move2 = true;

            }
            else if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
            {
                moveCount2 = 4;
                move2 = true;
            }
            if (move2)
            {
                Debug.Log("Arrow key player attack");/*
                Move two=player2.getMove(moveCount2);
                player1.damage(player1.getHealth() - two.getDamage());*//*
                player2.transform.position += new Vector3(1F, 0.5F, 0F);
                player2.attackAnim(0.25);*/
                player2.attackAnimStart(0.25);

                if (moveCount2 == 1)
                {
                    player1.damage(player2.attackOne()[0]);
                    player2.damage(player2.attackOne()[1]);
                }
                else if (moveCount2 == 2)
                {
                    player1.damage(player2.attackTwo()[0]);
                    player2.damage(player2.attackTwo()[1]);
                }
                else if (moveCount2 == 3)
                {
                    player1.damage(player2.attackThree()[0]);
                    player2.damage(player2.attackThree()[1]);
                }
                else if (moveCount2 == 4)
                {
                    player1.damage(player2.attackFour()[0]);
                    player2.damage(player2.attackFour()[1]);
                }
                changeTurn();
                move1 = false;
                move2 = false;
                Debug.Log("new turn");
            }
        }
        if (player2.getHealth() > player2.getMaxHealth())
        {
            player2.setHealth(player2.getMaxHealth());
        }
    }
    public bool getTurn()
    {
        return player;
    }
    public void changeTurn()
    {
        player = !player;
    }
}

