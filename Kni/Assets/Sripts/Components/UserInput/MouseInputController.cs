using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Sripts.Components.UserInput
{
    public class MouseInputController : InputController
    {
        public void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                // TODO : Cast a ray from the camera to a point and check collider tag
                // Raise one of the three events depending on the hit game object
            }
        }
    }
}
