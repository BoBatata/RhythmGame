using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonsControlls : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private Sprite unpressedButton;
    [SerializeField] private Sprite pressedButton;

    [SerializeField] private KeyCode keyToPress;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            spriteRenderer.sprite = pressedButton;
        }

        if (Input.GetKeyUp(keyToPress))
        {
            spriteRenderer.sprite = unpressedButton;
        }
    }

}
