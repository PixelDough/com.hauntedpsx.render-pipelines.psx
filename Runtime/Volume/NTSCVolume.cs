﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace HauntedPSX.RenderPipelines.PSX.Runtime
{
    [Serializable, VolumeComponentMenu("HauntedPS1/NTSCVolume")]
    public class NTSCVolume : VolumeComponent
    {
        public BoolParameter isEnabled = new BoolParameter(true);
        public ClampedFloatParameter kernelWidth = new ClampedFloatParameter(1.5f, 1f, 5f);
        public ClampedFloatParameter sharpenPercent = new ClampedFloatParameter(0.8f, 0, 1);
        public ClampedFloatParameter horizontalCarrierFrequency = new ClampedFloatParameter(0.81f, 0.1f, 3f);
        public ClampedFloatParameter linePhaseShift = new ClampedFloatParameter(3.14f, 0, 6.28f);

        
        
        static NTSCVolume s_Default = null;
        public static NTSCVolume @default
        {
            get
            {
                if (s_Default == null)
                {
                    s_Default = ScriptableObject.CreateInstance<NTSCVolume>();
                    s_Default.hideFlags = HideFlags.HideAndDontSave;
                }
                return s_Default;
            }
        }
    }
}
