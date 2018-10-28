using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionBehavior : MonoBehaviour {

    [SerializeField] private PotionCountdown potionUI;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            potionUI.StartCountdown();
            Destroy(gameObject);
        }
    }
}
