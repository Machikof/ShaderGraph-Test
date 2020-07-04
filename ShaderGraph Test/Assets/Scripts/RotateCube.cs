using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    private float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotateSpeed = Random.Range(0.1f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(rotateSpeed, rotateSpeed * 2f, rotateSpeed * 1.5f);
    }
}
