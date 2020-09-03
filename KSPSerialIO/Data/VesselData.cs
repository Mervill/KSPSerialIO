﻿using System;
using System.Runtime.InteropServices;

namespace KSPSerialIO
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VesselData
    {
        public byte id;              //1
        public float AP;             //2
        public float PE;             //3
        public float SemiMajorAxis;  //4
        public float SemiMinorAxis;  //5
        public float VVI;            //6
        public float e;              //7
        public float inc;            //8
        public float G;              //9
        public int TAp;              //10
        public int TPe;              //11
        public float TrueAnomaly;    //12
        public float Density;        //13
        public int period;           //14
        public float RAlt;           //15
        public float Alt;            //16
        public float Vsurf;          //17
        public float Lat;            //18
        public float Lon;            //19
        public float LiquidFuelTot;  //20
        public float LiquidFuel;     //21
        public float OxidizerTot;    //22
        public float Oxidizer;       //23
        public float EChargeTot;     //24
        public float ECharge;        //25
        public float MonoPropTot;    //26
        public float MonoProp;       //27
        public float IntakeAirTot;   //28
        public float IntakeAir;      //29
        public float SolidFuelTot;   //30
        public float SolidFuel;      //31
        public float XenonGasTot;    //32
        public float XenonGas;       //33
        public float LiquidFuelTotS; //34
        public float LiquidFuelS;    //35
        public float OxidizerTotS;   //36
        public float OxidizerS;      //37
        public UInt32 MissionTime;   //38
        public float deltaTime;      //39
        public float VOrbit;         //40
        public UInt32 MNTime;        //41
        public float MNDeltaV;       //42
        public float Pitch;          //43
        public float Roll;           //44
        public float Heading;        //45
        public UInt16 ActionGroups;  //46  status bit order:SAS, RCS, Light, Gear, Brakes, Abort, Custom01 - 10 
        public byte SOINumber;       //47  SOI Number (decimal format: sun-planet-moon e.g. 130 = kerbin, 131 = mun)
        public byte MaxOverHeat;     //48  Max part overheat (% percent)
        public float MachNumber;     //49
        public float IAS;            //50  Indicated Air Speed
        public byte CurrentStage;    //51  Current stage number
        public byte TotalStage;      //52  TotalNumber of stages
        public float TargetDist;     //53  Distance to targeted vessel (m)
        public float TargetV;        //54  Target vessel relative velocity (m/s)
        public byte NavballSASMode;  //55  Combined byte for navball target mode and SAS mode
                                     // First four bits indicate AutoPilot mode:
                                     // 0 SAS is off  //1 = Regular Stability Assist //2 = Prograde
                                     // 3 = RetroGrade //4 = Normal //5 = Antinormal //6 = Radial In
                                     // 7 = Radial Out //8 = Target //9 = Anti-Target //10 = Maneuver node
                                     // Last 4 bits set navball mode. (0=ignore,1=ORBIT,2=SURFACE,3=TARGET)
        public short ProgradePitch;  //56 Pitch   Of the Prograde Vector;  int_16 ***Changed: now fix point, actual angle = angle/50*** used to be (-0x8000(-360 degrees) to 0x7FFF(359.99ish degrees)); 
        public short ProgradeHeading;//57 Heading Of the Prograde Vector;  see above for range   (Prograde vector depends on navball mode, eg Surface/Orbit/Target)
        public short ManeuverPitch;  //58 Pitch   Of the Maneuver Vector;  see above for range;  (0 if no Maneuver node)
        public short ManeuverHeading;//59 Heading Of the Maneuver Vector;  see above for range;  (0 if no Maneuver node)
        public short TargetPitch;    //60 Pitch   Of the Target   Vector;  see above for range;  (0 if no Target)
        public short TargetHeading;  //61 Heading Of the Target   Vector;  see above for range;  (0 if no Target)
        public short NormalHeading;  //62 Normal Of the Prograde Vector;  see above for range;  (Pitch of the Heading Vector is always 0)
    }
}
