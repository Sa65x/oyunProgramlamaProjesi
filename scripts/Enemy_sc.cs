using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy_sc : MonoBehaviour
{
    [SerializeField]
    float speed = 3.0f;

    void Start()
    {

    }



    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -5.2)
        {
            float randomx = Random.Range(-10f, 10f);
            transform.position = new Vector3(randomx, 4f, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        player_sc player1 = other.transform.GetComponent<player_sc>();
        player1.Damage();

        Destroy(this.gameObject);

        if (other.tag == "player")
        {
            Destroy(this.gameObject);
        }
        else if (other.tag == "Laser")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

}