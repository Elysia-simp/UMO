// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class CKGLLPFMEDH : Table {
  public static CKGLLPFMEDH GetRootAsCKGLLPFMEDH(ByteBuffer _bb) { return GetRootAsCKGLLPFMEDH(_bb, new CKGLLPFMEDH()); }
  public static CKGLLPFMEDH GetRootAsCKGLLPFMEDH(ByteBuffer _bb, CKGLLPFMEDH obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public CKGLLPFMEDH __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OFMGALJGDAO { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CFLMCGOJJJD { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int ODBPKGJPLMD { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int JHAMBKOEJPL { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MJHPFNPCLBD { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int JDKBBEIBJBD { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetCGHIJPPACBC(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int CGHIJPPACBCLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetCGHIJPPACBCBytes() { return __vector_as_arraysegment(18); }
  public int HMNFFFLCANH { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LMLNKHMPOIG { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<CKGLLPFMEDH> CreateCKGLLPFMEDH(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int OFMGALJGDAO = 0,
      int CFLMCGOJJJD = 0,
      int ODBPKGJPLMD = 0,
      int JHAMBKOEJPL = 0,
      int MJHPFNPCLBD = 0,
      int JDKBBEIBJBD = 0,
      VectorOffset CGHIJPPACBCOffset = default(VectorOffset),
      int HMNFFFLCANH = 0,
      int LMLNKHMPOIG = 0) {
    builder.StartObject(10);
    CKGLLPFMEDH.AddLMLNKHMPOIG(builder, LMLNKHMPOIG);
    CKGLLPFMEDH.AddHMNFFFLCANH(builder, HMNFFFLCANH);
    CKGLLPFMEDH.AddCGHIJPPACBC(builder, CGHIJPPACBCOffset);
    CKGLLPFMEDH.AddJDKBBEIBJBD(builder, JDKBBEIBJBD);
    CKGLLPFMEDH.AddMJHPFNPCLBD(builder, MJHPFNPCLBD);
    CKGLLPFMEDH.AddJHAMBKOEJPL(builder, JHAMBKOEJPL);
    CKGLLPFMEDH.AddODBPKGJPLMD(builder, ODBPKGJPLMD);
    CKGLLPFMEDH.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    CKGLLPFMEDH.AddOFMGALJGDAO(builder, OFMGALJGDAO);
    CKGLLPFMEDH.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return CKGLLPFMEDH.EndCKGLLPFMEDH(builder);
  }

  public static void StartCKGLLPFMEDH(FlatBufferBuilder builder) { builder.StartObject(10); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddOFMGALJGDAO(FlatBufferBuilder builder, int OFMGALJGDAO) { builder.AddInt(1, OFMGALJGDAO, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, int CFLMCGOJJJD) { builder.AddInt(2, CFLMCGOJJJD, 0); }
  public static void AddODBPKGJPLMD(FlatBufferBuilder builder, int ODBPKGJPLMD) { builder.AddInt(3, ODBPKGJPLMD, 0); }
  public static void AddJHAMBKOEJPL(FlatBufferBuilder builder, int JHAMBKOEJPL) { builder.AddInt(4, JHAMBKOEJPL, 0); }
  public static void AddMJHPFNPCLBD(FlatBufferBuilder builder, int MJHPFNPCLBD) { builder.AddInt(5, MJHPFNPCLBD, 0); }
  public static void AddJDKBBEIBJBD(FlatBufferBuilder builder, int JDKBBEIBJBD) { builder.AddInt(6, JDKBBEIBJBD, 0); }
  public static void AddCGHIJPPACBC(FlatBufferBuilder builder, VectorOffset CGHIJPPACBCOffset) { builder.AddOffset(7, CGHIJPPACBCOffset.Value, 0); }
  public static VectorOffset CreateCGHIJPPACBCVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartCGHIJPPACBCVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHMNFFFLCANH(FlatBufferBuilder builder, int HMNFFFLCANH) { builder.AddInt(8, HMNFFFLCANH, 0); }
  public static void AddLMLNKHMPOIG(FlatBufferBuilder builder, int LMLNKHMPOIG) { builder.AddInt(9, LMLNKHMPOIG, 0); }
  public static Offset<CKGLLPFMEDH> EndCKGLLPFMEDH(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<CKGLLPFMEDH>(o);
  }
};

