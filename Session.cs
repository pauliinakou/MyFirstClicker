using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Session
{
    private static int clickCount;

    public static int ClickCount
    {
        get
        {
            return clickCount;
        }
        set
        {
            clickCount = value;
        }
    }
}
