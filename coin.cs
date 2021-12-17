using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1,0,0) * rotateSpeed * Time.deltaTime); //코인 돌아가게 하기
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            gameObject.SetActive(false);
        }
        
    }

}
