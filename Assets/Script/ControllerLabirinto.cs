using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ControllerLabirinto : MonoBehaviour
{
    public Rigidbody2D rig;
    public BoxCollider2D box;
    // Start is called before the first frame update
    void Awake()
    {
        rig = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    // void OnCollisionEnter(Collision other)
    // {
    //     if(other.Compare.Tag("Player"))
    //     {
    //         box.isTrigger = false;
    //     }
    // }












}
