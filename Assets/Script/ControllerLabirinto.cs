using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ControllerLabirinto : MonoBehaviour
{
    [SerializeField]
    public Animator anim;
    public BoxCollider2D box;
    // Start is called before the first frame update
    void Awake()
    {
        
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            {
                abrir();
            }
        }
    }


    public void abrir()
    {
        anim.SetBool("fechar",false);
        anim.SetBool("Abrir",true);
    }
    
    public void fechar()
    {
        anim.SetBool("Abrir",false);
        anim.SetBool("fechar",true);
        box.isTrigger = false;
    }

    void Atravessar()
    {
        box.isTrigger = true;
    }

}      