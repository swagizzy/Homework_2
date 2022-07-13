using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_2D : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private float _xVelocity = 0;
    public float moveStat = 1;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _xVelocity = -moveStat;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _xVelocity = moveStat;
        }
        else
        {
            _xVelocity = 0;
        }

        _rigidbody.velocity = new Vector3(_xVelocity, _rigidbody.velocity.y, 0);
    }
}
