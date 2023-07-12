using System;
using UnityEngine;
using Utilities;

public class MyObject : RecyclableObject
{
    internal override void Init()
    {
        Invoke(nameof(Recycle), 5);
    }

    internal override void Release()
    {
        Debug.Log("Reciclado");
    }
}
