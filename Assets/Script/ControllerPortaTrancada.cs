using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ControllerPortaTrancada : MonoBehaviour
{
    public ControllerLabirinto Labi;
    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(player.Chaves > 0)
            {
                Labi.abrir();
            }
        }
    }
}
