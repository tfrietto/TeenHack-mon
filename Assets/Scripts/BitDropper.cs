using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitDropper : MonoBehaviour
{
    public GameObject bit;
    bool cooldown;
    Sprite onebit;
    Sprite zerobit;

    // Start is called before the first frame update
    void Start()
    {
        cooldown = false;
        onebit = Resources.Load<Sprite>("Sprites/onebit");
        zerobit = Resources.Load<Sprite>("Sprites/zerobit");
    }

    // Update is called once per frame
    void Update()
    {
        if (!cooldown)
        {
            Vector3 position = new Vector3(12F, Random.Range(-5f, 5f), 0);
            GameObject clone = Instantiate(bit, position, Quaternion.identity);
            float scaleFactor = (Random.value * 5);
            clone.transform.localScale -= new Vector3(scaleFactor, scaleFactor, 0);
            if (Random.value > 0.5)
            {
                clone.GetComponent<SpriteRenderer>().sprite = zerobit;
            }
            else
            {
                clone.GetComponent<SpriteRenderer>().sprite = onebit;
            }
            var color = clone.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, (float)Random.value);
            StartCoroutine(cool((float)0.25));
        }
    }

    IEnumerator cool(double seconds)
    {
        cooldown = true;
        yield return new WaitForSeconds((float)seconds);
        cooldown = false;
    }
}
