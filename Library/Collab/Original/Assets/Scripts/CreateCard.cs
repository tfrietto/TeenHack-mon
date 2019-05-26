using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCard : MonoBehaviour
{
	public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        Javachu j=GameObject.Find("HealthBar1").GetComponent<Javachu>();
        Nohtyp p=GameObject.Find("HealthBar2").GetComponent<Nohtyp>();
        for(int i=0;i<4;i++){
            GameObject clone = Instantiate(card,new Vector3(i*3.6F-4.02F,-3.48F,0),Quaternion.identity);
            Move move = clone.GetComponent<Move>();
            move.player1 = true;
            move.identifier=i;
            //set image for move here
        }
        for(int i=0;i<4;i++){
            GameObject clone = Instantiate(card,new Vector3(4.02F-i*3.6F,3.48F,0),Quaternion.identity);
            Move move = clone.GetComponent<Move>();
            move.player1 = false;
            move.identifier=i;
            //set image for move here
        }
        card.GetComponent<SpriteRenderer>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
