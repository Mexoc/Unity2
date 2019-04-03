using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Geekbrains.Objects
{
    //Базовый класс для всех объектов
    public abstract class BaseObjectScene : MonoBehaviour
    {
        protected int _layer;
        protected Color _color;
        protected Material _material;
        protected Transform _transform;
        protected Vector3 _position;
        protected Quaternion _rotation;
        protected Vector3 _scale;
        protected GameObject _instanceObject;
        protected Rigidbody _rigidbody;
        protected string _name;
        protected bool _visible;

        #region Function
        protected virtual void Awake()
        {
            _instanceObject = gameObject;
            _name = _instanceObject.name;
            _transform = _instanceObject.transform;
            if (_instanceObject.GetComponent<Renderer>())
            {
                _material = GetComponent<Renderer>().material;

            }
            if (_instanceObject.GetComponent<Rigidbody>())
            {
                _rigidbody = GetComponent<Rigidbody>();
            }
        }
        #endregion

        #region Property
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                _instanceObject.name = _name;
            }
        }

        public int Layers
        {
            get { return _layer; }
            set
            {
                _layer = value;
                if (_instanceObject != null)
                {
                    _instanceObject.layer = _layer;
                }
            }
        }

        public Color Color
        {
            get { return _color; }
            set
            {
                _color = value;
                if (_material != null)
                {
                    _material.color = _color;
                }
            }
        }

        public Material Material
        {
            get { return _material; }
        }

        public Vector3 Position
        {
            get { return _position; }
            set
            {
                _position = value;
                if (_instanceObject != null)
                {
                    _instanceObject.transform.position = _position;
                }
            }
        }

        public Vector3 Scale
        {
            get { return _scale; }
            set
            {
                _scale = value;
                if (_instanceObject != null)
                {
                    _instanceObject.transform.localScale = _scale;
                }
            }
        }

        public Quaternion Rotation
        {
            get { return _rotation; }
            set
            {
                _rotation = value;
                if (_instanceObject != null)
                {
                    _instanceObject.transform.rotation = _rotation;
                }
            }
        }

        public Rigidbody GetRigidBody
        {
            get { return _rigidbody; }
        }

        public GameObject GetGameObject
        {
            get { return _instanceObject; }
        }

        public bool IsVisible
        {
            get { return _visible; }
            set
            {
                _visible = value;
                if (_instanceObject.GetComponent<MeshRenderer>())
                {
                    _instanceObject.GetComponent<MeshRenderer>().enabled = value;
                }
            }
        }

        public Transform GetTransform
        {
            get { return _transform; }
        }
        #endregion
    }
}

