using Assets.Sripts.Core.Stone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

namespace Assets.Sripts.Components.Stone
{
    /// <summary>
    /// Controller to be attached to each stone game object
    /// </summary>
    public class StoneController : MonoBehaviour, IMovable
    {
        public void Move(Vector3 destination)
        {
            throw new NotImplementedException();
        }

        public IEnumerator MoveCoroutine(Vector3 destination)
        {
            throw new NotImplementedException();
        }
    }
}
