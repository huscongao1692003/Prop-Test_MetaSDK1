using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//namespace Oculus.Interaction.PoseDetection.Debug
//{
    public class HandGrabMove : MonoBehaviour
    {
    //[Tooltip("The IActiveState to debug.")]
    //[SerializeField, Interface(typeof(IActiveState))]
    //private UnityEngine.Object _activeState;
    //private IActiveState ActiveState { get; set; }
    //public Vector3 difference, oldhandpos, currenthandpos;
    //private OVRHand rightHand;
    //public GameObject XRRig;


    //private bool _lastActiveValue = false;


    //void Update()
    //{
    //    bool isActive = ActiveState.Active;
    //    if (_lastActiveValue != isActive)
    //    {
    //        currenthandpos = rightHand.transform.position;
    //        difference = difference = (oldhandpos - currenthandpos) * 2.6f;
    //        XRRig.transform.position += difference;
    //        _lastActiveValue = isActive;
    //    }

    //    oldhandpos = rightHand.transform.position;
    //}
    public float curlThreshold = 45f; // Angle threshold to determine finger curl

    private OVRSkeleton ovrSkeleton;
    private int thumbProximalIndex, indexProximalIndex, middleProximalIndex, ringProximalIndex, pinkyProximalIndex;

    void Start()
    {
        ovrSkeleton = GameObject.Find("OVRControllerPrefabName").GetComponent<OVRSkeleton>();

        // Identify finger bone indices based on OVRSkeleton documentation (replace with actual indices)
        thumbProximalIndex = 0; // Assuming thumb proximal is the first bone
        indexProximalIndex = 1;
        middleProximalIndex = 2;
        ringProximalIndex = 3;
        pinkyProximalIndex = 4;
    }

    //void Update()
    //{
    //    ovrSkeleton.Bones. = ovrSkeleton.Bones[thumbProximalIndex];
    //    Bone indexProximal = ovrSkeleton.Bones[indexProximalIndex];

    
    //    bool isHandGrab = CheckFingerCurl(thumbProximal) &&
    //                       CheckFingerCurl(indexProximal) &&
    //                       CheckFingerCurl(middleProximal) &&
    //                       CheckFingerCurl(ringProximal) &&
    //                       CheckFingerCurl(pinkyProximal);

    //    // Perform actions based on the hand grab gesture
    //    if (isHandGrab)
    //    {
    //        // Grab logic here (e.g., raycast to grab objects)
    //        Debug.Log("Hand Grab Detected!");
    //    }
    //}

    //bool CheckFingerCurl(Bone proximalBone)
    //{
    //    if (proximalBone.name == null) return false;

    //    Bone distalBone = ovrSkeleton.Bones.FirstOrDefault(bone => bone.name.StartsWith(proximalBone.name.Replace("proximal", "distal"))); // Assuming distal bone name follows specific format

    //    if (distalBone.name == null) return false;

    //    Vector3 boneDirection = (distalBone.transform.position - proximalBone.transform.position).normalized;
    //    float angle = Vector3.Angle(boneDirection, Vector3.up);

    //    return angle > curlThreshold;
    //}
}
//}