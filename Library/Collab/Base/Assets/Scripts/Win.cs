using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
	public GameObject j;
	public GameObject p;
    public GameObject obj;
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
    	bool player1health=player1.getHealth()<=0;
    	bool player2health=player2.getHealth()<=0;
    	if(player1health&&player2health){
            message="draw";
            transform.Translate(Vector3.right*Time.deltaTime);
    	}
        else if(player1.getHealth()<=0){
            message="Nohtyp won";
        }
        else if(player2.getHealth()<=0){
            message="Javachu won";
        }
    }
}

