// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class CECBEDHLMBM : Table {
  public static CECBEDHLMBM GetRootAsCECBEDHLMBM(ByteBuffer _bb) { return GetRootAsCECBEDHLMBM(_bb, new CECBEDHLMBM()); }
  public static CECBEDHLMBM GetRootAsCECBEDHLMBM(ByteBuffer _bb, CECBEDHLMBM obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public CECBEDHLMBM __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint ODBPKGJPLMD { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint KJFEBMBHKOC { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<CECBEDHLMBM> CreateCECBEDHLMBM(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint ODBPKGJPLMD = 0,
      uint KJFEBMBHKOC = 0) {
    builder.StartObject(3);
    CECBEDHLMBM.AddKJFEBMBHKOC(builder, KJFEBMBHKOC);
    CECBEDHLMBM.AddODBPKGJPLMD(builder, ODBPKGJPLMD);
    CECBEDHLMBM.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return CECBEDHLMBM.EndCECBEDHLMBM(builder);
  }

  public static void StartCECBEDHLMBM(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddODBPKGJPLMD(FlatBufferBuilder builder, uint ODBPKGJPLMD) { builder.AddUint(1, ODBPKGJPLMD, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, uint KJFEBMBHKOC) { builder.AddUint(2, KJFEBMBHKOC, 0); }
  public static Offset<CECBEDHLMBM> EndCECBEDHLMBM(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<CECBEDHLMBM>(o);
  }
};

