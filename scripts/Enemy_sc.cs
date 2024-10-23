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
            float randomx = Random.Range(-15f, 15f);
            transform.position = new Vector3(randomx, 5.2f, 0);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        player_sc oyuncu = other.transform.GetComponent<player_sc>();
        oyuncu.Demage();

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
