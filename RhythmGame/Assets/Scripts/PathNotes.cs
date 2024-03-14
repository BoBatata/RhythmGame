using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathNotes : MonoBehaviour
{
    [SerializeField] private float beatTime;

    [SerializeField] private bool isStarted;

    private void Start()
    {
        beatTime = beatTime / 60f;
    }

    private void Update()
    {
        if (!isStarted)
        {
            if (Input.anyKeyDown)
            {
                isStarted = true;
            }
        }
        else
        {
            transform.position -= new Vector3(0f, beatTime * Time.deltaTime, 0f);
        }
    }
}
