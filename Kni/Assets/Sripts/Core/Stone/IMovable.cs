using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Sripts.Core.Stone
{
    public interface IMovable
    {
        // Move an object directly to a given destination
        void Move(Vector3 destination);

        // Same but happens over time
        IEnumerator MoveCoroutine(Vector3 destination);
    }
}
