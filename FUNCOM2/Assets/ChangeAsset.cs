using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeAsset : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite vase1, vase2, vase3, vase4;
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    // Start is called before the first frame update

    // Update is called once per frame

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        //rend.sprite = vase1;
    }

    private void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
           //Debug.Log("Player in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
        }
    }
    public void changeSprite()
    {
        if (rend.sprite == vase1)
        {
            rend.sprite = vase2;
        }
        else if (rend.sprite == vase2)
        {
            rend.sprite = vase3;
        }
        else if (rend.sprite == vase3)
        {
            rend.sprite = vase4;
        }
        else if (rend.sprite == vase4)
        {
            rend.sprite = vase1;
        }
    }
    
}
