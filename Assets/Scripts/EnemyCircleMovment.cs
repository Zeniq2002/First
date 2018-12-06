using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCircleMovment : MonoBehaviour
{
    private float RotateSpeed = 5f;
    public float Radius = 5f;

    private Vector2 _centre;
    private float _angle;

    private void Start()
    {
        //ger en mitten för var den ska rotera runt
        _centre = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        //ger en fart till rotationen
        _angle += RotateSpeed * Time.deltaTime;
        //säger hur lång ifrån mitten den ska rotera
        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        transform.position = _centre + offset;
    }
}
