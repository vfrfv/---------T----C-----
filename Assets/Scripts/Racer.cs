using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider))]

public class Racer : MonoBehaviour
{
    [SerializeField] private Transform[] _poins;
    [SerializeField] private float _speed;

    private int _currentPoint;

    private void Update()
    {
        Transform target = _poins[_currentPoint];

        transform.LookAt(target.position);
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if(transform.position == target.position)
        {
            _currentPoint++;

            if(_currentPoint ==  _poins.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}
