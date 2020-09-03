using System;
using System.Runtime.InteropServices;

namespace KSPSerialIO
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ControlPacket
    {
        public byte id;
        public byte MainControls;                  // SAS RCS Lights Gear Brakes Precision Abort Stage 
        public byte Mode;                          // 0 = stage, 1 = docking, 2 = map
        public ushort ControlGroup;                //control groups 1-10 in 2 bytes
        public byte NavballSASMode;                //AutoPilot mode (See above for AutoPilot modes)(Ignored if the equal to zero or out of bounds (>10)) //Navball mode
        public byte AdditionalControlByte1;
        public short Pitch;         // 0 -> 1023
        public short Roll;          // 0 -> 1023
        public short Yaw;           // 0 -> 1023
        public short TX;            // 0 -> 1023
        public short TY;            // 0 -> 1023
        public short TZ;            // 0 -> 1023
        public short MainThrottle;  // 0 -> 1000
        public short WheelSteer;    // 0 -> 1023
        public short WheelThrottle; // 0 -> 1000
    };
}
