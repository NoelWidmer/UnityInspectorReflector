﻿using System;
using UnityEngine;

namespace InspectorReflector.Sample
{
    [Inspect]
    public class DefaultSample : MonoBehaviour
    {
        // Default

        [SerializeField]
        private AnimationCurve _defaultAnimationCurve;
        [Inspect]
        public AnimationCurve DefaultAnimationCurve
        {
            get
            {
                return _defaultAnimationCurve;
            }
            set
            {
                _defaultAnimationCurve = value;
            }
        }



        [SerializeField]
        private bool _defaultBool;
        [Inspect]
        public bool DefaultBool
        {
            get
            {
                return _defaultBool;
            }
            set
            {
                _defaultBool = value;
            }
        }



        [SerializeField]
        private byte _defaultByte;
        [Inspect]
        public byte DefaultByte
        {
            get
            {
                return _defaultByte;
            }
            set
            {
                _defaultByte = value;
            }
        }



        [SerializeField]
        private Bounds _defaultBounds;
        [Inspect]
        public Bounds DefaultBounds {
            get
            {
                return _defaultBounds;
            }
            set
            {
                _defaultBounds = value;
            }
        }



        [SerializeField]
        private char _defaultChar;
        [Inspect]
        public char DefaultChar
        {
            get
            {
                return _defaultChar;
            }
            set
            {
                _defaultChar = value;
            }
        }



        [SerializeField]
        private Color _defaultColor;
        [Inspect]
        public Color DefaultColor { get
            {
                return _defaultColor;
            }
            set
            {
                _defaultColor = value;
            }
        }



        [SerializeField]
        private double _defaultDouble;
        [Inspect]
        public double DefaultDouble
        {
            get
            {
                return _defaultDouble;
            }
            set
            {
                _defaultDouble = value;
            }
        }



        [SerializeField]
        private EnumNumbers _defaultEnum;
        [Inspect]
        public EnumNumbers DefaultEnum
        {
            get
            {
                return _defaultEnum;
            }
            set
            {
                _defaultEnum = value;
            }
        }

        [SerializeField]
        private FlagNumbers _flagEnum;
        [Inspect]
        public FlagNumbers FlagEnum
        {
            get
            {
                return _flagEnum;
            }
            set
            {
                _flagEnum = value;
            }
        }



        [SerializeField]
        private float _defaultFloat;
        [Inspect]
        public float DefaultFloat
        {
            get
            {
                return _defaultFloat;
            }
            set
            {
                _defaultFloat = value;
            }
        }



        [SerializeField]
        private int _defaultInt;
        [Inspect]
        public int DefaultInt {
            get
            {
                return _defaultInt;
            }
            set
            {
                _defaultInt = value;
            }
        }



        [SerializeField]
        private long _defaultLong;
        [Inspect]
        public long DefaultLong
        {
            get
            {
                return _defaultLong;
            }
            set
            {
                _defaultLong = value;
            }
        }



        [SerializeField]
        private Rect _defaultRect;
        [Inspect]
        public Rect DefaultRect
        {
            get
            {
                return _defaultRect;
            }
            set
            {
                _defaultRect = value;
            }
        }



        [SerializeField]
        private sbyte _defaultSByte;
        [Inspect]
        public sbyte DefaultSByte
        {
            get
            {
                return _defaultSByte;
            }
            set
            {
                _defaultSByte = value;
            }
        }



        [SerializeField]
        private short _defaultShort;
        [Inspect]
        public short DefaultShort
        {
            get
            {
                return _defaultShort;
            }
            set
            {
                _defaultShort = value;
            }
        }



        [SerializeField]
        private string _defaultString;
        [Inspect]
        public string DefaultString
        {
            get
            {
                return _defaultString;
            }
            set
            {
                _defaultString = value;
            }
        }



        [SerializeField]
        private uint _defaultUInt;
        [Inspect]
        public uint DefaultUInt
        {
            get
            {
                return _defaultUInt;
            }
            set
            {
                _defaultUInt = value;
            }
        }



        [SerializeField]
        private ulong _defaultULong;
        [Inspect]
        public ulong DefaultULong
        {
            get
            {
                return _defaultULong;
            }
            set
            {
                _defaultULong = value;
            }
        }



        [SerializeField]
        private ushort _defaultUShort;
        [Inspect]
        public ushort DefaultUShort
        {
            get
            {
                return _defaultUShort;
            }
            set
            {
                _defaultUShort = value;
            }
        }



        [SerializeField]
        private Vector2 _defaultVector2;
        [Inspect]
        public Vector2 DefaultVector2
        {
            get
            {
                return _defaultVector2;
            }
            set
            {
                _defaultVector2 = value;
            }
        }



        [SerializeField]
        private Vector3 _defaultVector3;
        [Inspect]
        public Vector3 DefaultVector3
        {
            get
            {
                return _defaultVector3;
            }
            set
            {
                _defaultVector3 = value;
            }
        }



        [SerializeField]
        private Vector4 _defaultVector4;
        [Inspect]
        public Vector4 DefaultVector4
        {
            get
            {
                return _defaultVector4;
            }
            set
            {
                _defaultVector4 = value;
            }
        }



        // Readonly

        [SerializeField]
        private Rect _rectReadonlyByIR;
        [Inspect(InspectionType.Readonly)]
        public Rect RectReadonlyByIR
        {
            get
            {
                return _rectReadonlyByIR;
            }
            set
            {
                _rectReadonlyByIR = value;
            }
        }



        [SerializeField]
        private Rect _rectReadonlyByCode;
        [Inspect]
        public Rect RectReadonlyByCode
        {
            get
            {
                return _rectReadonlyByCode;
            }
        }


        
        // Nested types.

        public enum EnumNumbers
        {
            One = 1,
            Two = 2,
            Three = 3,
            Four = 4
        }


        [Flags]
        public enum FlagNumbers
        {
            One = 1,
            Two = 2,
            Four = 4,
            Eight = 8
        }
    }
}