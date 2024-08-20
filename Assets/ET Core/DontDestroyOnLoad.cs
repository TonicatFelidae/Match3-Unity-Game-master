using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ETSimpleKit // TO ET NOT ETSimpleKit
{
    public class DontDestroyOnLoad : MonoBehaviour
    {
        // Start is called before the first frame update
        void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}
