using System;

namespace KSPSerialIO
{
    public struct VesselControls
    {
        public bool SAS;
        public bool RCS;
        public bool Lights;
        public bool Gear;
        public bool Brakes;
        public bool Precision;
        public bool Abort;
        public bool Stage;
        public int Mode;
        public int SASMode;
        public int SpeedMode;
        public bool[] ControlGroup;
        public float Pitch;
        public float Roll;
        public float Yaw;
        public float TX;
        public float TY;
        public float TZ;
        public float MainThrottle;
        public float WheelSteer;
        public float WheelThrottle;
    };
}
