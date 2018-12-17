using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorMotion : MonoBehaviour {

    [SerializeField]
    ScrollTexture scrollTexture;

    Vector3 _motion;

    List<GameObject> _currentPassengers = new List<GameObject>();

    private void FixedUpdate()
    {
        Debug.Log(_currentPassengers);
        Move();
    }

    private void OnTriggerEnter(Collider other)
    {
      
        if (other.gameObject.CompareTag("Movable"))
        {
            _currentPassengers.Add(other.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        for(int i = 0; i < _currentPassengers.Count; i++)
        {
            if(other.gameObject == _currentPassengers[i])
            {
                _currentPassengers.Remove(_currentPassengers[i]);
            }
        }
    }

    private void Move()
    {
        _motion = new Vector3(0, 0, -scrollTexture.MoveSpeed);
        for (int i = 0; i < _currentPassengers.Count; i++)
        {
            _currentPassengers[i].gameObject.transform.position += _motion * Time.fixedDeltaTime;
        }
    }


    //  private void OnTriggerStay(Collider collider)
    //  {
    //      _motion = new Vector3(0, 0, -scrollTexture.MoveSpeed);
    //
    //      if(collider.gameObject.CompareTag("Movable"))
    //      {
    //          collider.gameObject.transform.position += _motion * Time.deltaTime;
    //      }
    //
    //    
    //
    //      Debug.Log("Detecting");
    // }


}
