using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollTexture : MonoBehaviour {
    [SerializeField]
    Renderer _conveyor;

    
    public float MoveSpeed;
    float _changeInOffset;

    private void Update()
    {
        _changeInOffset += MoveSpeed * Time.deltaTime;
        _conveyor.material.SetTextureOffset("_MainTex", new Vector2(0, _changeInOffset));
        //if (_changeInOffset >= 1)
        //    _changeInOffset = 0;
    }
}
