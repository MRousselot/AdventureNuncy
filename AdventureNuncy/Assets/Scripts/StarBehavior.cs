using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBehavior : MonoBehaviour {

    [SerializeField] private StarUI starUI;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            starUI.AddStar();
            Destroy(gameObject);
        }
    }
}
