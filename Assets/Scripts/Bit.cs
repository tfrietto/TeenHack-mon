using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bit : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(0.05F, 0.15F);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(
            this.transform.position.x - speed,
            this.transform.position.y,
            this.transform.position.z
            );
    }
}
