using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoEventHolder
{
    public static Action OnPlayPressed { get; set; }
    public static Action OnPlayAnimation { get; set; }

    public static Action OnIncreaseWaist { get; set; }
    public static Action OnDecreaseWaist { get; set; }


}