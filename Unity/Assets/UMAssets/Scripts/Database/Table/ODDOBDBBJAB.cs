// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class ODDOBDBBJAB : Table {
  public static ODDOBDBBJAB GetRootAsODDOBDBBJAB(ByteBuffer _bb) { return GetRootAsODDOBDBBJAB(_bb, new ODDOBDBBJAB()); }
  public static ODDOBDBBJAB GetRootAsODDOBDBBJAB(ByteBuffer _bb, ODDOBDBBJAB obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public ODDOBDBBJAB __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GetFAOBJKICMBB(int j) { int o = __offset(8); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int FAOBJKICMBBLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetFAOBJKICMBBBytes() { return __vector_as_arraysegment(8); }
  public uint MJOCIHPPKNO { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint AEAKMMJLLDK { get { int o = __offset(12); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public int OFMGALJGDAO { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<ODDOBDBBJAB> CreateODDOBDBBJAB(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint CFLMCGOJJJD = 0,
      VectorOffset FAOBJKICMBBOffset = default(VectorOffset),
      uint MJOCIHPPKNO = 0,
      uint AEAKMMJLLDK = 0,
      int OFMGALJGDAO = 0) {
    builder.StartObject(6);
    ODDOBDBBJAB.AddOFMGALJGDAO(builder, OFMGALJGDAO);
    ODDOBDBBJAB.AddAEAKMMJLLDK(builder, AEAKMMJLLDK);
    ODDOBDBBJAB.AddMJOCIHPPKNO(builder, MJOCIHPPKNO);
    ODDOBDBBJAB.AddFAOBJKICMBB(builder, FAOBJKICMBBOffset);
    ODDOBDBBJAB.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    ODDOBDBBJAB.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return ODDOBDBBJAB.EndODDOBDBBJAB(builder);
  }

  public static void StartODDOBDBBJAB(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(1, CFLMCGOJJJD, 0); }
  public static void AddFAOBJKICMBB(FlatBufferBuilder builder, VectorOffset FAOBJKICMBBOffset) { builder.AddOffset(2, FAOBJKICMBBOffset.Value, 0); }
  public static VectorOffset CreateFAOBJKICMBBVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartFAOBJKICMBBVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddMJOCIHPPKNO(FlatBufferBuilder builder, uint MJOCIHPPKNO) { builder.AddUint(3, MJOCIHPPKNO, 0); }
  public static void AddAEAKMMJLLDK(FlatBufferBuilder builder, uint AEAKMMJLLDK) { builder.AddUint(4, AEAKMMJLLDK, 0); }
  public static void AddOFMGALJGDAO(FlatBufferBuilder builder, int OFMGALJGDAO) { builder.AddInt(5, OFMGALJGDAO, 0); }
  public static Offset<ODDOBDBBJAB> EndODDOBDBBJAB(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ODDOBDBBJAB>(o);
  }
};

