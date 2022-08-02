using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveForward();
    }

    public void moveForward()
    {
        this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
