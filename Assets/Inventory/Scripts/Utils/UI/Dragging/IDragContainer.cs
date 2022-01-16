﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev.Core.UI.Dragging
{

    public interface IDragContainer<T> : IDragDestination<T>, IDragSource<T> where T : class
    {
    }
}