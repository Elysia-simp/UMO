// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class FKEPLHAEEBK : Table {
  public static FKEPLHAEEBK GetRootAsFKEPLHAEEBK(ByteBuffer _bb) { return GetRootAsFKEPLHAEEBK(_bb, new FKEPLHAEEBK()); }
  public static FKEPLHAEEBK GetRootAsFKEPLHAEEBK(ByteBuffer _bb, FKEPLHAEEBK obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FKEPLHAEEBK __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint ODBPKGJPLMD { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint KJFEBMBHKOC { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint AEAKMMJLLDK { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GEJGMBBCFEE { get { int o = __offset(12); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<FKEPLHAEEBK> CreateFKEPLHAEEBK(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint ODBPKGJPLMD = 0,
      uint KJFEBMBHKOC = 0,
      uint AEAKMMJLLDK = 0,
      uint GEJGMBBCFEE = 0) {
    builder.StartObject(5);
    FKEPLHAEEBK.AddGEJGMBBCFEE(builder, GEJGMBBCFEE);
    FKEPLHAEEBK.AddAEAKMMJLLDK(builder, AEAKMMJLLDK);
    FKEPLHAEEBK.AddKJFEBMBHKOC(builder, KJFEBMBHKOC);
    FKEPLHAEEBK.AddODBPKGJPLMD(builder, ODBPKGJPLMD);
    FKEPLHAEEBK.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return FKEPLHAEEBK.EndFKEPLHAEEBK(builder);
  }

  public static void StartFKEPLHAEEBK(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddODBPKGJPLMD(FlatBufferBuilder builder, uint ODBPKGJPLMD) { builder.AddUint(1, ODBPKGJPLMD, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, uint KJFEBMBHKOC) { builder.AddUint(2, KJFEBMBHKOC, 0); }
  public static void AddAEAKMMJLLDK(FlatBufferBuilder builder, uint AEAKMMJLLDK) { builder.AddUint(3, AEAKMMJLLDK, 0); }
  public static void AddGEJGMBBCFEE(FlatBufferBuilder builder, uint GEJGMBBCFEE) { builder.AddUint(4, GEJGMBBCFEE, 0); }
  public static Offset<FKEPLHAEEBK> EndFKEPLHAEEBK(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FKEPLHAEEBK>(o);
  }
};

