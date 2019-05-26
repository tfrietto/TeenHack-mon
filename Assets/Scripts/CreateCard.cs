using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateCard : MonoBehaviour
{
    SpriteRenderer spriteR;
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
            spriteR = move.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
            if(i == 0){
                spriteR.sprite = Resources.Load<Sprite>("Sprites/wmove");
                GameObject canvas = clone.transform.GetChild(1).gameObject;
                canvas.transform.GetChild(0).gameObject.GetComponent<Text>().text = "System.out.\nprintln(\"shock\")";
                canvas.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Base Attack, Does three damage";
            }
            else if (i == 1){
                GameObject canvas = clone.transform.GetChild(1).gameObject;
                spriteR.sprite = Resources.Load<Sprite>("Sprites/amove");
                    canvas.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Java destruction 9000";
                canvas.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Deals large damage at a cost";
            }
            else if (i == 2){
                GameObject canvas = clone.transform.GetChild(1).gameObject;
                spriteR.sprite = Resources.Load<Sprite>("Sprites/smove");
                canvas.transform.GetChild(0).gameObject.GetComponent<Text>().text = "(int) (Math.Random()*5)";
                canvas.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Does Anywhere between one and five damage";
            }
            else if (i == 3){
                GameObject canvas = clone.transform.GetChild(1).gameObject;
                spriteR.sprite = Resources.Load<Sprite>("Sprites/dmove");
                canvas.transform.GetChild(0).gameObject.GetComponent<Text>().text = "hp+=2";
                canvas.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Heal for two health";
           
            }
        }
        for(int i=0;i<4;i++){
            GameObject clone = Instantiate(card,new Vector3(3.36F-i*3.6F,3F,0),Quaternion.identity);
            Move move = clone.GetComponent<Move>();
            move.player1 = false;
            move.identifier=i;
            spriteR = move.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>();
            if (i == 0){
                GameObject canvas = clone.transform.GetChild(1).gameObject;
                spriteR.sprite = Resources.Load<Sprite>("Sprites/upmove");
                canvas.transform.GetChild(0).gameObject.GetComponent<Text>().text = "git commit";
                canvas.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Base Attack, does three damage";
            }
            else if (i == 1){
                GameObject canvas = clone.transform.GetChild(1).gameObject;
                spriteR.sprite = Resources.Load<Sprite>("Sprites/leftmove");
                canvas.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Delete the repository";
                canvas.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Deals large damage at a cost";
            }
            else if (i == 2){
                GameObject canvas = clone.transform.GetChild(1).gameObject;
                spriteR.sprite = Resources.Load<Sprite>("Sprites/downmove");
                canvas.transform.GetChild(0).gameObject.GetComponent<Text>().text = "git pull request";
                canvas.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Does Anywhere between one and five damage";
            }
            else if (i == 3){
                GameObject canvas = clone.transform.GetChild(1).gameObject;
                spriteR.sprite = Resources.Load<Sprite>("Sprites/rightmove");
                canvas.transform.GetChild(0).gameObject.GetComponent<Text>().text = "git reset";
                canvas.transform.GetChild(1).gameObject.GetComponent<Text>().text = "Heals two health";
            
            }
        }
        card.GetComponent<SpriteRenderer>().enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
