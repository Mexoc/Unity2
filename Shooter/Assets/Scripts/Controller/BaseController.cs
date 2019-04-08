using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains.Controller
{
    public class BaseController : MonoBehaviour
    {
        protected bool _enable;

        public bool Enable
        {
            get { return _enable; }
        }

        public virtual void On()
        {
            _enable = true;
        }

        public virtual void Off()
        {
            _enable = false;
        }
    }
}

