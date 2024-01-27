using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    private float _speed;
    private Vector3 _direction;
    private Vector3 _target;




    private void Update()
    {

        transform.Translate( -_direction * _speed * Time.deltaTime); 

        
    }
    public void StartMove(Vector3 target, float speed)
    {
        _direction = (transform.position - target).normalized;
        _target = target;
        _speed = speed;
    }


    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
