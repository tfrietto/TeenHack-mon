using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nohtyp : MonoBehaviour
{
    int hp;
    float maxHP;
    Move[] move;
    Move one;
    Move two;
    Move three;
    Move four;
    public GameObject anchor;
    // Start is called before the first frame update
    void Start()
    {
        maxHP = 10;
        // one=one.GetComponent<Move>();
        // one.setDamage(1);
        // one=two.GetComponent<Move>();
        // one.setDamage(2);
        // one=three.GetComponent<Move>();
        // one.setDamage(3);
        // one=four.GetComponent<Move>();
        // one.setDamage(4);
        // move = new Move[4]{ one, two, three, four };
        int hp = (int)maxHP;
    }

    // Update is called once per frame
    void Update() //uncomment this stuff to break the program in its current state
    {

    }
    public void takeDmg(int dmg)
    {
        hp -= dmg;
        float percent = (float)dmg / maxHP;
        Debug.Log(percent);
        anchor.transform.localScale -= new Vector3(0, percent, 0);
    }
    public int getMove(int i)
    {
        return move[i].getDamage();
    }
    public void setMove(Move m,int p){
        move[p]=m;
    }
}
