// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class OLIHMDDCGNO : Table {
  public static OLIHMDDCGNO GetRootAsOLIHMDDCGNO(ByteBuffer _bb) { return GetRootAsOLIHMDDCGNO(_bb, new OLIHMDDCGNO()); }
  public static OLIHMDDCGNO GetRootAsOLIHMDDCGNO(ByteBuffer _bb, OLIHMDDCGNO obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public OLIHMDDCGNO __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OFMGALJGDAO { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public int HOENDPOGFIO { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LPJPOOHJKAE { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public uint LMLNKHMPOIG { get { int o = __offset(14); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint ODBPKGJPLMD { get { int o = __offset(16); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public int JHAMBKOEJPL { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MJHPFNPCLBD { get { int o = __offset(20); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int JDKBBEIBJBD { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetONFIAKMPBCK(int j) { int o = __offset(24); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int ONFIAKMPBCKLength { get { int o = __offset(24); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetONFIAKMPBCKBytes() { return __vector_as_arraysegment(24); }

  public static Offset<OLIHMDDCGNO> CreateOLIHMDDCGNO(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int OFMGALJGDAO = 0,
      uint CFLMCGOJJJD = 0,
      int HOENDPOGFIO = 0,
      int LPJPOOHJKAE = 0,
      uint LMLNKHMPOIG = 0,
      uint ODBPKGJPLMD = 0,
      int JHAMBKOEJPL = 0,
      int MJHPFNPCLBD = 0,
      int JDKBBEIBJBD = 0,
      VectorOffset ONFIAKMPBCKOffset = default(VectorOffset)) {
    builder.StartObject(11);
    OLIHMDDCGNO.AddONFIAKMPBCK(builder, ONFIAKMPBCKOffset);
    OLIHMDDCGNO.AddJDKBBEIBJBD(builder, JDKBBEIBJBD);
    OLIHMDDCGNO.AddMJHPFNPCLBD(builder, MJHPFNPCLBD);
    OLIHMDDCGNO.AddJHAMBKOEJPL(builder, JHAMBKOEJPL);
    OLIHMDDCGNO.AddODBPKGJPLMD(builder, ODBPKGJPLMD);
    OLIHMDDCGNO.AddLMLNKHMPOIG(builder, LMLNKHMPOIG);
    OLIHMDDCGNO.AddLPJPOOHJKAE(builder, LPJPOOHJKAE);
    OLIHMDDCGNO.AddHOENDPOGFIO(builder, HOENDPOGFIO);
    OLIHMDDCGNO.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    OLIHMDDCGNO.AddOFMGALJGDAO(builder, OFMGALJGDAO);
    OLIHMDDCGNO.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return OLIHMDDCGNO.EndOLIHMDDCGNO(builder);
  }

  public static void StartOLIHMDDCGNO(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddOFMGALJGDAO(FlatBufferBuilder builder, int OFMGALJGDAO) { builder.AddInt(1, OFMGALJGDAO, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(2, CFLMCGOJJJD, 0); }
  public static void AddHOENDPOGFIO(FlatBufferBuilder builder, int HOENDPOGFIO) { builder.AddInt(3, HOENDPOGFIO, 0); }
  public static void AddLPJPOOHJKAE(FlatBufferBuilder builder, int LPJPOOHJKAE) { builder.AddInt(4, LPJPOOHJKAE, 0); }
  public static void AddLMLNKHMPOIG(FlatBufferBuilder builder, uint LMLNKHMPOIG) { builder.AddUint(5, LMLNKHMPOIG, 0); }
  public static void AddODBPKGJPLMD(FlatBufferBuilder builder, uint ODBPKGJPLMD) { builder.AddUint(6, ODBPKGJPLMD, 0); }
  public static void AddJHAMBKOEJPL(FlatBufferBuilder builder, int JHAMBKOEJPL) { builder.AddInt(7, JHAMBKOEJPL, 0); }
  public static void AddMJHPFNPCLBD(FlatBufferBuilder builder, int MJHPFNPCLBD) { builder.AddInt(8, MJHPFNPCLBD, 0); }
  public static void AddJDKBBEIBJBD(FlatBufferBuilder builder, int JDKBBEIBJBD) { builder.AddInt(9, JDKBBEIBJBD, 0); }
  public static void AddONFIAKMPBCK(FlatBufferBuilder builder, VectorOffset ONFIAKMPBCKOffset) { builder.AddOffset(10, ONFIAKMPBCKOffset.Value, 0); }
  public static VectorOffset CreateONFIAKMPBCKVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartONFIAKMPBCKVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<OLIHMDDCGNO> EndOLIHMDDCGNO(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<OLIHMDDCGNO>(o);
  }
};

