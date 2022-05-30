// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class EJMDBHGILEI : Table {
  public static EJMDBHGILEI GetRootAsEJMDBHGILEI(ByteBuffer _bb) { return GetRootAsEJMDBHGILEI(_bb, new EJMDBHGILEI()); }
  public static EJMDBHGILEI GetRootAsEJMDBHGILEI(ByteBuffer _bb, EJMDBHGILEI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public EJMDBHGILEI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int HLPHBGLMBIO { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BPMBFFDNMDD { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LPJPOOHJKAE { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CFLMCGOJJJD { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string AFJJKGBHFJP { get { int o = __offset(14); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetAFJJKGBHFJPBytes() { return __vector_as_arraysegment(14); }
  public string GetNKCBBELDHOI(int j) { int o = __offset(16); return o != 0 ? __string(__vector(o) + j * 4) : null; }
  public int NKCBBELDHOILength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public int PPGJPNONPDB { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int COBFEKPMGIB { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OFMGALJGDAO { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CCIHMCAPHCB { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GEJGMBBCFEE { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CNNEAFFOPAO { get { int o = __offset(28); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<EJMDBHGILEI> CreateEJMDBHGILEI(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int HLPHBGLMBIO = 0,
      int BPMBFFDNMDD = 0,
      int LPJPOOHJKAE = 0,
      int CFLMCGOJJJD = 0,
      StringOffset AFJJKGBHFJPOffset = default(StringOffset),
      VectorOffset NKCBBELDHOIOffset = default(VectorOffset),
      int PPGJPNONPDB = 0,
      int COBFEKPMGIB = 0,
      int OFMGALJGDAO = 0,
      int CCIHMCAPHCB = 0,
      int GEJGMBBCFEE = 0,
      int CNNEAFFOPAO = 0) {
    builder.StartObject(13);
    EJMDBHGILEI.AddCNNEAFFOPAO(builder, CNNEAFFOPAO);
    EJMDBHGILEI.AddGEJGMBBCFEE(builder, GEJGMBBCFEE);
    EJMDBHGILEI.AddCCIHMCAPHCB(builder, CCIHMCAPHCB);
    EJMDBHGILEI.AddOFMGALJGDAO(builder, OFMGALJGDAO);
    EJMDBHGILEI.AddCOBFEKPMGIB(builder, COBFEKPMGIB);
    EJMDBHGILEI.AddPPGJPNONPDB(builder, PPGJPNONPDB);
    EJMDBHGILEI.AddNKCBBELDHOI(builder, NKCBBELDHOIOffset);
    EJMDBHGILEI.AddAFJJKGBHFJP(builder, AFJJKGBHFJPOffset);
    EJMDBHGILEI.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    EJMDBHGILEI.AddLPJPOOHJKAE(builder, LPJPOOHJKAE);
    EJMDBHGILEI.AddBPMBFFDNMDD(builder, BPMBFFDNMDD);
    EJMDBHGILEI.AddHLPHBGLMBIO(builder, HLPHBGLMBIO);
    EJMDBHGILEI.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return EJMDBHGILEI.EndEJMDBHGILEI(builder);
  }

  public static void StartEJMDBHGILEI(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddHLPHBGLMBIO(FlatBufferBuilder builder, int HLPHBGLMBIO) { builder.AddInt(1, HLPHBGLMBIO, 0); }
  public static void AddBPMBFFDNMDD(FlatBufferBuilder builder, int BPMBFFDNMDD) { builder.AddInt(2, BPMBFFDNMDD, 0); }
  public static void AddLPJPOOHJKAE(FlatBufferBuilder builder, int LPJPOOHJKAE) { builder.AddInt(3, LPJPOOHJKAE, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, int CFLMCGOJJJD) { builder.AddInt(4, CFLMCGOJJJD, 0); }
  public static void AddAFJJKGBHFJP(FlatBufferBuilder builder, StringOffset AFJJKGBHFJPOffset) { builder.AddOffset(5, AFJJKGBHFJPOffset.Value, 0); }
  public static void AddNKCBBELDHOI(FlatBufferBuilder builder, VectorOffset NKCBBELDHOIOffset) { builder.AddOffset(6, NKCBBELDHOIOffset.Value, 0); }
  public static VectorOffset CreateNKCBBELDHOIVector(FlatBufferBuilder builder, StringOffset[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNKCBBELDHOIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPPGJPNONPDB(FlatBufferBuilder builder, int PPGJPNONPDB) { builder.AddInt(7, PPGJPNONPDB, 0); }
  public static void AddCOBFEKPMGIB(FlatBufferBuilder builder, int COBFEKPMGIB) { builder.AddInt(8, COBFEKPMGIB, 0); }
  public static void AddOFMGALJGDAO(FlatBufferBuilder builder, int OFMGALJGDAO) { builder.AddInt(9, OFMGALJGDAO, 0); }
  public static void AddCCIHMCAPHCB(FlatBufferBuilder builder, int CCIHMCAPHCB) { builder.AddInt(10, CCIHMCAPHCB, 0); }
  public static void AddGEJGMBBCFEE(FlatBufferBuilder builder, int GEJGMBBCFEE) { builder.AddInt(11, GEJGMBBCFEE, 0); }
  public static void AddCNNEAFFOPAO(FlatBufferBuilder builder, int CNNEAFFOPAO) { builder.AddInt(12, CNNEAFFOPAO, 0); }
  public static Offset<EJMDBHGILEI> EndEJMDBHGILEI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<EJMDBHGILEI>(o);
  }
};
