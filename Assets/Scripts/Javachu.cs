using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Javachu : MonoBehaviour
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
    bool cooldown;
    // Start is called before the first frame update
    void Start()
    {
        maxHP = 20;
        one=new Move();
        one.setDamage(1);
        one.setName("plz work");/*
        one=new Move();
        one.setDamage(2);
        one=new Move();
        one.setDamage(3);
        one=new Move();
        one.setDamage(4);
        move =new Move[4]{ one, two, three, four };
        int hp = (int)maxHP;*/
        Debug.Log(maxHP);
        hp = (int)maxHP;
    }

    // Update is called once per frame
    void Update() 
    {
    }
    public void damage(int dmg)
    {
        hp -= dmg;
        float percent = (float)dmg/maxHP;
        Debug.Log("Percent java: " + percent);
        anchor.transform.localScale -= new Vector3(0, percent, 0);
        if (hp > maxHP)
        {
            anchor.transform.localScale = new Vector3(1, 1, 1);
        }
        if (hp < 0)
        {
            anchor.transform.localScale = new Vector3(1, 0, 1);
        }
    }

    public void attackAnimStart(double seconds)
    {
        StartCoroutine(attackAnim(seconds));
    }
    public IEnumerator attackAnim(double seconds)
    {
        transform.position += new Vector3(0F, 1F, 0F);
        yield return new WaitForSeconds((float)seconds);
        transform.position -= new Vector3(0F, 1F, 0F);

    }
    public bool getCooldown()
    {
        return cooldown;
    }
    public void heal(int dmg)
    {
        hp += dmg;
        float percent = (float)dmg / maxHP;
        Debug.Log("Percent java: " + percent);
        anchor.transform.localScale += new Vector3(0, (float)0.1, 0);
        if (hp > maxHP)
        {
            anchor.transform.localScale = new Vector3(0, (float)1, 0);
        }
    }
    public void setHealth(int health)
    {
        hp = health;
    }
    public Move getMove(int i)
    {
        return one;
    }
    public int getHealth()
    {
        return hp;
    }
    public int getMaxHealth()
    {
        return (int)maxHP;
    }
    public int[] attackOne() // returns array, with index 0 being damage done, and index 1 being heal to player
    {
        int[] returnArray = new int[2];
        returnArray[0] = 3;
        returnArray[1] = 0;
        return returnArray;
    }
    public int[] attackTwo()
    {
        int[] returnArray = new int[2];
        returnArray[0] =  (int)(Random.value * 5 + 1);
        returnArray[1] = 0;
        return returnArray;
    }
    public int[] attackThree()
    {
        int[] returnArray = new int[2];
        returnArray[0] = 6;
        returnArray[1] = 3;
        return returnArray;
    }
    public int[] attackFour()
    {
        int[] returnArray = new int[2];
        returnArray[0] = 0;
        returnArray[1] = -2;
        return returnArray;
    }
}
