using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSetup : MonoBehaviour
{
    [SerializeField]
    private GameObject _player = default;

    // Start is called before the first frame update
    void Start()
    {
        if(Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer)
        {
            _player.AddComponent<MobileInput>();
        }
        else
        {
            // KeyboardInput is kind of a misnomer now that I think about it but I'm too lazy to fix it right now
            _player.AddComponent<KeyboardInput>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
