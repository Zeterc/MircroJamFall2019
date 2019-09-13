using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Transform playerPos;
    private PlayerScript player;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerScript").GetComponent<PlayerScript>();
        playerPos = GameObject.FindGameObjectWithTag("PlayerScript").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.CompareTag("PlayerScript"))
        {
            Destroy(gameObject);
        }
    }

}
