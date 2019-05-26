using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
	public GameObject j;
	public GameObject p;
    public GameObject obj;
    SpriteRenderer SpriteR;
	Javachu player1;
	Nohtyp player2;
    string message;
    // Start is called before the first frame update
    void Start()
    {
    	player1=j.GetComponent<Javachu>();
    	player2=p.GetComponent<Nohtyp>();
    }

    // Update is called once per frame
    void Update()
    {
        SpriteR=obj.GetComponent<SpriteRenderer>();
        if(player1.getHealth()<=0){
            message="Nohtyp won";
            transform.Translate(Vector3.right*Time.deltaTime);
            SpriteR.sprite=Resources.Load<Sprite>("Sprites/Win banner2");
        }
        else if(player2.getHealth()<=0){
            message="Javachu won";
            transform.Translate(Vector3.right*Time.deltaTime);
            SpriteR.sprite=Resources.Load<Sprite>("Sprites/Win banner1");
        }
    }
}

