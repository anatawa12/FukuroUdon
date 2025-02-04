﻿/*
Copyright (c) 2023 Mimy Quality
Released under the MIT license
https://opensource.org/licenses/mit-license.php
*/

using UdonSharp;
using UnityEngine;
//using VRC.SDKBase;
//using VRC.Udon;
using VRC.SDK3.Components;

namespace MimyLab
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.None)]
    public class MirrorProfile : UdonSharpBehaviour
    {
        public bool disablePixelLights = true;
        public bool turnOffMirrorOcclusion = true;
        public LayerMask reflectLayers = 0b01111111110001100010101100000001;
        public Material customMaterial = null;
        public MirrorClearFlags cameraClearFlags = default;
        public Material customSkybox = null;
        public Color customCrearColor = Color.black;
    }
}
