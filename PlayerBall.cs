using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
   

    // Start is called before the first frame update
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();  
    }

  
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }
   
}
