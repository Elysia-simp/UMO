// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class MIICCHHAGJF : Table {
  public static MIICCHHAGJF GetRootAsMIICCHHAGJF(ByteBuffer _bb) { return GetRootAsMIICCHHAGJF(_bb, new MIICCHHAGJF()); }
  public static MIICCHHAGJF GetRootAsMIICCHHAGJF(ByteBuffer _bb, MIICCHHAGJF obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public MIICCHHAGJF __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint MOMCBJDJDIA { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint PEGBGEGKCGA { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint NJLJEKDBPCH { get { int o = __offset(12); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint MAOAGDBDBIB { get { int o = __offset(14); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<MIICCHHAGJF> CreateMIICCHHAGJF(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint CFLMCGOJJJD = 0,
      uint MOMCBJDJDIA = 0,
      uint PEGBGEGKCGA = 0,
      uint NJLJEKDBPCH = 0,
      uint MAOAGDBDBIB = 0) {
    builder.StartObject(6);
    MIICCHHAGJF.AddMAOAGDBDBIB(builder, MAOAGDBDBIB);
    MIICCHHAGJF.AddNJLJEKDBPCH(builder, NJLJEKDBPCH);
    MIICCHHAGJF.AddPEGBGEGKCGA(builder, PEGBGEGKCGA);
    MIICCHHAGJF.AddMOMCBJDJDIA(builder, MOMCBJDJDIA);
    MIICCHHAGJF.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    MIICCHHAGJF.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return MIICCHHAGJF.EndMIICCHHAGJF(builder);
  }

  public static void StartMIICCHHAGJF(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(1, CFLMCGOJJJD, 0); }
  public static void AddMOMCBJDJDIA(FlatBufferBuilder builder, uint MOMCBJDJDIA) { builder.AddUint(2, MOMCBJDJDIA, 0); }
  public static void AddPEGBGEGKCGA(FlatBufferBuilder builder, uint PEGBGEGKCGA) { builder.AddUint(3, PEGBGEGKCGA, 0); }
  public static void AddNJLJEKDBPCH(FlatBufferBuilder builder, uint NJLJEKDBPCH) { builder.AddUint(4, NJLJEKDBPCH, 0); }
  public static void AddMAOAGDBDBIB(FlatBufferBuilder builder, uint MAOAGDBDBIB) { builder.AddUint(5, MAOAGDBDBIB, 0); }
  public static Offset<MIICCHHAGJF> EndMIICCHHAGJF(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<MIICCHHAGJF>(o);
  }
};
