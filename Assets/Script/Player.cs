using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Chaves = 0;
    public float movi;
    Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rig.velocity = new Vector3( Input.GetAxisRaw("Horizontal")* movi, Input.GetAxisRaw("Vertical")* movi,0f);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "chave")
        {
            Chaves ++;
            Destroy(collision.gameObject);
        
        }

    }
}
