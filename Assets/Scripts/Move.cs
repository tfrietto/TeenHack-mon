using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
	private string name;
	public int damage;
    public bool player1;
    public int identifier;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setDamage(int d)
    {
        damage = d;
    }
    public void setName(string n)
    {
        name = n;
    }
    public int getDamage(){
        if(damage!=null)
    	return damage;
        else
        {
            return 0;
        }
    }
    public string getName(){
    	return name;
    }
}
