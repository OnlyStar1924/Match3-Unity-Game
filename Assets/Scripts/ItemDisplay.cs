using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDisplay : MonoBehaviour
{
    public ItemSO itemso;

    // Use this for initialization
    void Start()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = itemso.sprite;
    }
}
