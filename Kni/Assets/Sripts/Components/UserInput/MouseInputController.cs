using Assets.Sripts.Components.Stone;
using Assets.Sripts.Core.Input;
using Assets.Sripts.Core.Stone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Sripts.Components.UserInput
{
    public class MouseInputController : InputController
    {
        private const string STONE_TAG = "Stone";
        private const string BOARD_TAG = "Board";
        private const string HIGHLIGHT_TAG = "Highlight";

        public new Camera camera;

        public void Start()
        {
            this.camera = this.GetComponent<Camera>();
            // or
            //this.camera = Camera.main;
        }
         
        /// <summary>
        /// Check for mouse click and handle accordingly
        /// </summary>
        public void Update()
        {
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                // Cast a ray from the camera to a point and check collider tag
                // Raise one of the three events depending on the hit game object

                Ray clickRay = camera.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                Physics.Raycast(clickRay, out hit);

                HandleRaycastHit(hit);
            }
        }

        /// <summary>
        /// Raise the event corresponding to the hit parameter
        /// </summary>
        /// <param name="hit">Raycast hit information to be used for raising the right event</param>
        private void HandleRaycastHit(RaycastHit hit)
        {
            // Stone hit
            if(hit.collider.tag == STONE_TAG)
            {
                IMovable stone = hit.collider.gameObject.GetComponent<StoneController>();
                StoneSelectedEventArgs args = new StoneSelectedEventArgs(stone);
                OnStoneSelected(args);
            }

            // Position hit
            else if(hit.collider.tag == BOARD_TAG)
            {
                Vector3 position = hit.collider.transform.position;
                PositionSelectedEventArgs args = new PositionSelectedEventArgs(position);
                OnPositionSelected(args);
            }

            // Highlight hit
            else if(hit.collider.tag == HIGHLIGHT_TAG)
            {
                Vector3 position = hit.collider.transform.position;
                PositionSelectedEventArgs args = new PositionSelectedEventArgs(position);
                OnDestinationSelected(args);
            }
        }
    }
}
