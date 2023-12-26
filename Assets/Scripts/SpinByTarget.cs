using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class SpinByTarget : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    [SerializeField] private float angle = 1f;
    private GameObject _currentObject;
    
    // Start is called before the first frame update
    void Start()
    {
        _currentObject = this.GameObject();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(_target is null)
            return;
        else
        {
            _currentObject.transform.RotateAround(_target.transform.position, Vector3.up, angle * Time.fixedDeltaTime );
        }
        
    }
}
