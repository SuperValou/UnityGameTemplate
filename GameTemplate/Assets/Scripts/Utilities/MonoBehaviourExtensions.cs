﻿using System;
using UnityEngine;

namespace Assets.Scripts.Utilities
{
    public static class MonoBehaviourExtensions
    {
        public static TComponent GetComponentOrThrow<TComponent>(this MonoBehaviour monoBehaviour)
            where TComponent : Component
        {
            var component = monoBehaviour.GetComponent<TComponent>();
            if (component == null)
            {
                throw new ArgumentException($"Missing '{typeof(TComponent).Name}' component on '{monoBehaviour.gameObject}' game object.");
            }

            return component;
        }
    }
}