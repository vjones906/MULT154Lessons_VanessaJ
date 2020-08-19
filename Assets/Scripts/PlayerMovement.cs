using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbPlayer;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horMove = Input.GetAxis("Horizontal");

        rbPlayer.AddForce(new Vector3(horMove, 0, 0), ForceMode.Impulse);
    }
}
