using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameObject PlayerCharacter;

    [SerializeField]
    private GameObject _playerCharacter;

    private void Start()
    {
        PlayerCharacter = _playerCharacter;
    }
}
