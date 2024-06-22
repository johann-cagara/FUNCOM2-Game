using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static Unity.Burst.Intrinsics.X86;

public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update

    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    private SpriteRenderer rend;
    private Sprite vase1, vase2, vase3, vase4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
            Debug.Log("Player in range");
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
