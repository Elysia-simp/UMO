// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class DCKKAECHDNC : Table {
  public static DCKKAECHDNC GetRootAsDCKKAECHDNC(ByteBuffer _bb) { return GetRootAsDCKKAECHDNC(_bb, new DCKKAECHDNC()); }
  public static DCKKAECHDNC GetRootAsDCKKAECHDNC(ByteBuffer _bb, DCKKAECHDNC obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public DCKKAECHDNC __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DPFDOIIOICA { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GEAIPAEKLNF { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int JGILGOILJNK { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<DCKKAECHDNC> CreateDCKKAECHDNC(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int DPFDOIIOICA = 0,
      int GEAIPAEKLNF = 0,
      int JGILGOILJNK = 0) {
    builder.StartObject(4);
    DCKKAECHDNC.AddJGILGOILJNK(builder, JGILGOILJNK);
    DCKKAECHDNC.AddGEAIPAEKLNF(builder, GEAIPAEKLNF);
    DCKKAECHDNC.AddDPFDOIIOICA(builder, DPFDOIIOICA);
    DCKKAECHDNC.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return DCKKAECHDNC.EndDCKKAECHDNC(builder);
  }

  public static void StartDCKKAECHDNC(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddDPFDOIIOICA(FlatBufferBuilder builder, int DPFDOIIOICA) { builder.AddInt(1, DPFDOIIOICA, 0); }
  public static void AddGEAIPAEKLNF(FlatBufferBuilder builder, int GEAIPAEKLNF) { builder.AddInt(2, GEAIPAEKLNF, 0); }
  public static void AddJGILGOILJNK(FlatBufferBuilder builder, int JGILGOILJNK) { builder.AddInt(3, JGILGOILJNK, 0); }
  public static Offset<DCKKAECHDNC> EndDCKKAECHDNC(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<DCKKAECHDNC>(o);
  }
};

