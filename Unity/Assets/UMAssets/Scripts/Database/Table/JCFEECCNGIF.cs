// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class JCFEECCNGIF : Table {
  public static JCFEECCNGIF GetRootAsJCFEECCNGIF(ByteBuffer _bb) { return GetRootAsJCFEECCNGIF(_bb, new JCFEECCNGIF()); }
  public static JCFEECCNGIF GetRootAsJCFEECCNGIF(ByteBuffer _bb, JCFEECCNGIF obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public JCFEECCNGIF __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint AMFPDKACLLL { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint OFMGALJGDAO { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GetLACEJFCOFHG(int j) { int o = __offset(10); return o != 0 ? bb.GetUint(__vector(o) + j * 4) : (uint)0; }
  public int LACEJFCOFHGLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetLACEJFCOFHGBytes() { return __vector_as_arraysegment(10); }
  public uint GHPIPMFBJHH { get { int o = __offset(12); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint EMFHICAOLOA { get { int o = __offset(14); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<JCFEECCNGIF> CreateJCFEECCNGIF(FlatBufferBuilder builder,
      uint AMFPDKACLLL = 0,
      uint OFMGALJGDAO = 0,
      uint CFLMCGOJJJD = 0,
      VectorOffset LACEJFCOFHGOffset = default(VectorOffset),
      uint GHPIPMFBJHH = 0,
      uint EMFHICAOLOA = 0) {
    builder.StartObject(6);
    JCFEECCNGIF.AddEMFHICAOLOA(builder, EMFHICAOLOA);
    JCFEECCNGIF.AddGHPIPMFBJHH(builder, GHPIPMFBJHH);
    JCFEECCNGIF.AddLACEJFCOFHG(builder, LACEJFCOFHGOffset);
    JCFEECCNGIF.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    JCFEECCNGIF.AddOFMGALJGDAO(builder, OFMGALJGDAO);
    JCFEECCNGIF.AddAMFPDKACLLL(builder, AMFPDKACLLL);
    return JCFEECCNGIF.EndJCFEECCNGIF(builder);
  }

  public static void StartJCFEECCNGIF(FlatBufferBuilder builder) { builder.StartObject(6); }
  public static void AddAMFPDKACLLL(FlatBufferBuilder builder, uint AMFPDKACLLL) { builder.AddUint(0, AMFPDKACLLL, 0); }
  public static void AddOFMGALJGDAO(FlatBufferBuilder builder, uint OFMGALJGDAO) { builder.AddUint(1, OFMGALJGDAO, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(2, CFLMCGOJJJD, 0); }
  public static void AddLACEJFCOFHG(FlatBufferBuilder builder, VectorOffset LACEJFCOFHGOffset) { builder.AddOffset(3, LACEJFCOFHGOffset.Value, 0); }
  public static VectorOffset CreateLACEJFCOFHGVector(FlatBufferBuilder builder, uint[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddUint(data[i]); return builder.EndVector(); }
  public static void StartLACEJFCOFHGVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddGHPIPMFBJHH(FlatBufferBuilder builder, uint GHPIPMFBJHH) { builder.AddUint(4, GHPIPMFBJHH, 0); }
  public static void AddEMFHICAOLOA(FlatBufferBuilder builder, uint EMFHICAOLOA) { builder.AddUint(5, EMFHICAOLOA, 0); }
  public static Offset<JCFEECCNGIF> EndJCFEECCNGIF(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<JCFEECCNGIF>(o);
  }
};

