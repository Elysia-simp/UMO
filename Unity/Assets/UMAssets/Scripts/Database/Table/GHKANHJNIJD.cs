// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class GHKANHJNIJD : Table {
  public static GHKANHJNIJD GetRootAsGHKANHJNIJD(ByteBuffer _bb) { return GetRootAsGHKANHJNIJD(_bb, new GHKANHJNIJD()); }
  public static GHKANHJNIJD GetRootAsGHKANHJNIJD(ByteBuffer _bb, GHKANHJNIJD obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public GHKANHJNIJD __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint HHFEPINGMEI { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint NJLJEKDBPCH { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint MAOAGDBDBIB { get { int o = __offset(12); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<GHKANHJNIJD> CreateGHKANHJNIJD(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint CFLMCGOJJJD = 0,
      uint HHFEPINGMEI = 0,
      uint NJLJEKDBPCH = 0,
      uint MAOAGDBDBIB = 0) {
    builder.StartObject(5);
    GHKANHJNIJD.AddMAOAGDBDBIB(builder, MAOAGDBDBIB);
    GHKANHJNIJD.AddNJLJEKDBPCH(builder, NJLJEKDBPCH);
    GHKANHJNIJD.AddHHFEPINGMEI(builder, HHFEPINGMEI);
    GHKANHJNIJD.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    GHKANHJNIJD.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return GHKANHJNIJD.EndGHKANHJNIJD(builder);
  }

  public static void StartGHKANHJNIJD(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(1, CFLMCGOJJJD, 0); }
  public static void AddHHFEPINGMEI(FlatBufferBuilder builder, uint HHFEPINGMEI) { builder.AddUint(2, HHFEPINGMEI, 0); }
  public static void AddNJLJEKDBPCH(FlatBufferBuilder builder, uint NJLJEKDBPCH) { builder.AddUint(3, NJLJEKDBPCH, 0); }
  public static void AddMAOAGDBDBIB(FlatBufferBuilder builder, uint MAOAGDBDBIB) { builder.AddUint(4, MAOAGDBDBIB, 0); }
  public static Offset<GHKANHJNIJD> EndGHKANHJNIJD(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GHKANHJNIJD>(o);
  }
};

