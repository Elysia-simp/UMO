// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class OJHENJDBLNC : Table {
  public static OJHENJDBLNC GetRootAsOJHENJDBLNC(ByteBuffer _bb) { return GetRootAsOJHENJDBLNC(_bb, new OJHENJDBLNC()); }
  public static OJHENJDBLNC GetRootAsOJHENJDBLNC(ByteBuffer _bb, OJHENJDBLNC obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public OJHENJDBLNC __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint NJLJEKDBPCH { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint MAOAGDBDBIB { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public string NNKLANONDOM { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetNNKLANONDOMBytes() { return __vector_as_arraysegment(10); }

  public static Offset<OJHENJDBLNC> CreateOJHENJDBLNC(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint NJLJEKDBPCH = 0,
      uint MAOAGDBDBIB = 0,
      StringOffset NNKLANONDOMOffset = default(StringOffset)) {
    builder.StartObject(4);
    OJHENJDBLNC.AddNNKLANONDOM(builder, NNKLANONDOMOffset);
    OJHENJDBLNC.AddMAOAGDBDBIB(builder, MAOAGDBDBIB);
    OJHENJDBLNC.AddNJLJEKDBPCH(builder, NJLJEKDBPCH);
    OJHENJDBLNC.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return OJHENJDBLNC.EndOJHENJDBLNC(builder);
  }

  public static void StartOJHENJDBLNC(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddNJLJEKDBPCH(FlatBufferBuilder builder, uint NJLJEKDBPCH) { builder.AddUint(1, NJLJEKDBPCH, 0); }
  public static void AddMAOAGDBDBIB(FlatBufferBuilder builder, uint MAOAGDBDBIB) { builder.AddUint(2, MAOAGDBDBIB, 0); }
  public static void AddNNKLANONDOM(FlatBufferBuilder builder, StringOffset NNKLANONDOMOffset) { builder.AddOffset(3, NNKLANONDOMOffset.Value, 0); }
  public static Offset<OJHENJDBLNC> EndOJHENJDBLNC(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<OJHENJDBLNC>(o);
  }
};

