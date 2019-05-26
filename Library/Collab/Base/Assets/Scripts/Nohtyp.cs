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
    bool moveOver = false;
    public GameObject anchor;
    // Start is called before the first frame update
    void Start()
    {
        maxHP = 10;
        one=new Move();
        one.setDamage(1);
        one=new Move();
        one.setDamage(2);
        one=new Move();
        one.setDamage(3);
        one=new Move();
        one.setDamage(4);
        move = new Move[4]{ one, two, three, four };
        int hp = (int)maxHP;
        Debug.Log(move[0].getDamage());
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
    public Move getMove(int i)
    {
        Move m = move[i];
        return m;
    }
}
