using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trophyMove : MonoBehaviour
{
    private Vector3 target;
    private bool isDragging;
    int speed = 15;
    Rigidbody2D rb;
    AudioManager am;
    public void OnMouseDown()
    {
        isDragging = true;
    }

    public void OnMouseUp()
    {
        isDragging = false;
    }

    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.localPosition.x, -5f, gameObject.transform.localPosition.z);
        rb.velocity = Vector2.zero;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (isDragging)
        {
            //transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.x, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }
    }
    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>();

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            gameObject.transform.parent = null;
        }
    }
}
