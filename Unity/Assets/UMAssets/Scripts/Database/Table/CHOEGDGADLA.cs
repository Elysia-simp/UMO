// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class CHOEGDGADLA : Table {
  public static CHOEGDGADLA GetRootAsCHOEGDGADLA(ByteBuffer _bb) { return GetRootAsCHOEGDGADLA(_bb, new CHOEGDGADLA()); }
  public static CHOEGDGADLA GetRootAsCHOEGDGADLA(ByteBuffer _bb, CHOEGDGADLA obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public CHOEGDGADLA __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int DPFDOIIOICA { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GEAIPAEKLNF { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int JGILGOILJNK { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<CHOEGDGADLA> CreateCHOEGDGADLA(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int DPFDOIIOICA = 0,
      int GEAIPAEKLNF = 0,
      int JGILGOILJNK = 0) {
    builder.StartObject(4);
    CHOEGDGADLA.AddJGILGOILJNK(builder, JGILGOILJNK);
    CHOEGDGADLA.AddGEAIPAEKLNF(builder, GEAIPAEKLNF);
    CHOEGDGADLA.AddDPFDOIIOICA(builder, DPFDOIIOICA);
    CHOEGDGADLA.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return CHOEGDGADLA.EndCHOEGDGADLA(builder);
  }

  public static void StartCHOEGDGADLA(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddDPFDOIIOICA(FlatBufferBuilder builder, int DPFDOIIOICA) { builder.AddInt(1, DPFDOIIOICA, 0); }
  public static void AddGEAIPAEKLNF(FlatBufferBuilder builder, int GEAIPAEKLNF) { builder.AddInt(2, GEAIPAEKLNF, 0); }
  public static void AddJGILGOILJNK(FlatBufferBuilder builder, int JGILGOILJNK) { builder.AddInt(3, JGILGOILJNK, 0); }
  public static Offset<CHOEGDGADLA> EndCHOEGDGADLA(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<CHOEGDGADLA>(o);
  }
};

