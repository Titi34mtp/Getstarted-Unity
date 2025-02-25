﻿#if ENABLE_VR || (UNITY_GAMECORE && INPUT_SYSTEM_1_4_OR_NEWER) || PACKAGE_DOCS_GENERATION
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation
{
    /// <summary>
    /// An input device representing a simulated XR head mounted display.
    /// </summary>
    [InputControlLayout(stateType = typeof(XRSimulatedHMDState), isGenericTypeOfDevice = false, displayName = "XR Simulated HMD")]
    [Preserve]
    public class XRSimulatedHMD : XRHMD
    {
    }
}
#endif
