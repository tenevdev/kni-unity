using Assets.Sripts.Core.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Sripts.Components.UserInput
{
    public abstract class InputController : MonoBehaviour, IInputController
    {
        protected static InputController instance;
        public static InputController Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = GameObject.FindObjectOfType<InputController>();
                }

                return instance;
            }
        }

        public event PositionSelectedEventHandler PositionSelected;
        protected virtual void OnPositionSelected(PositionSelectedEventArgs args)
        {
            if(PositionSelected != null)
            {
                PositionSelected(this, args);
            }
        }

        public event StoneSelectedEventHandler StoneSelected;
        protected virtual void OnStoneSelected(StoneSelectedEventArgs args)
        {
            if (StoneSelected != null)
            {
                StoneSelected(this, args);
            }
        }

        public event DestinationSelectedEventHandler DestinationSelected;
        protected virtual void OnDestinationSelected(PositionSelectedEventArgs args)
        {
            if (DestinationSelected != null)
            {
                DestinationSelected(this, args);
            }
        }
    }
}
