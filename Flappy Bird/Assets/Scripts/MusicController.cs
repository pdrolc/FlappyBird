using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    private static MusicController mc;

    public void Awake()
    {
        if (mc == null)
        {
            mc = this;
            DontDestroyOnLoad(gameObject);
        } 
        else if (mc != this)
        {
            Destroy(gameObject);
        }
    }

}
