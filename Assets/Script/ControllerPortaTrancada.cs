using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ControllerPortaTrancada : MonoBehaviour
{
    [SerializeField]
    public Animator anim;
    public BoxCollider2D box;
    public ControllerLabirinto Labi;
    public Player player;
    public bool Aberta;
    // Start is called before the first frame update
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(player.Chaves > 0)
            {
               abrir();
            }
        }
    }



    public void abrir()
    {
        player.Chaves --;
        anim.SetBool("FicarAberta",true);
    }

    void Atravessar()
    {
        box.isTrigger = true;
    }

}
