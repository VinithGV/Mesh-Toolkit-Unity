//
// This file was auto-generated from Animator assets in Unity Project Mesh101.unity.
//

// <auto-generated />

namespace MeshApp.Animations
{
    using System;
    using Microsoft.MeshApps;
    using Microsoft.MeshApps.Dom;

    [UserCreatable(false)]
    public class TestControllerAnimator : AnimationNode
    {
        private readonly float[] _baseLayerSpeeds = { 1F, 1F, };

        protected TestControllerAnimator(in Guid ahandle, bool transfer)
        : base(ahandle, transfer)
        {
        }

        public enum BaseLayerState
        {
            State1,
            State2,
        }

        [Replication(ReplicationKind.Full)]
        public BaseLayerState CurrentBaseLayerState
        {
            get => (BaseLayerState)GetIntPropertyValue(nameof(CurrentBaseLayerState));
            set
            {
                SetIntPropertyValue(nameof(CurrentBaseLayerState), (int)value);
                SystemTimeOfBaseLayerUpdated = Application.ToServerTime(DateTime.UtcNow);
            }
        }

        [Replication(ReplicationKind.Full)]
        public float BaseLayerSpeed
        {
            get => _baseLayerSpeeds[GetIntPropertyValue(nameof(CurrentBaseLayerState))];
        }

        [Replication(ReplicationKind.Full)]
        internal TimeStamp SystemTimeOfBaseLayerUpdated
        {
            get => GetTimeStampPropertyValue(nameof(SystemTimeOfBaseLayerUpdated));
            set => SetTimeStampPropertyValue(nameof(SystemTimeOfBaseLayerUpdated), value);
        }

        internal static TestControllerAnimator GetOrCreateInstance(in Guid cookie, bool transfer)
        {
            var result = GetOrCreateDomObject(
                cookie,
                transfer,
                (handle, t) => new TestControllerAnimator(handle, transfer: t));

            return result as TestControllerAnimator;
        }
    }
}