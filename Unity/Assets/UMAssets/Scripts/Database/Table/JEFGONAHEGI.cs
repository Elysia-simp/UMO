// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class JEFGONAHEGI : Table {
  public static JEFGONAHEGI GetRootAsJEFGONAHEGI(ByteBuffer _bb) { return GetRootAsJEFGONAHEGI(_bb, new JEFGONAHEGI()); }
  public static JEFGONAHEGI GetRootAsJEFGONAHEGI(ByteBuffer _bb, JEFGONAHEGI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public JEFGONAHEGI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OFMGALJGDAO { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int CFLMCGOJJJD { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GONOGEBKNLE { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int LPJPOOHJKAE { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int EBLEOMJJDMC { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GKPLGGIHHBJ { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int NCADHENBLDB { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string DKAFKOABCJA { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetDKAFKOABCJABytes() { return __vector_as_arraysegment(20); }

  public static Offset<JEFGONAHEGI> CreateJEFGONAHEGI(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int OFMGALJGDAO = 0,
      int CFLMCGOJJJD = 0,
      int GONOGEBKNLE = 0,
      int LPJPOOHJKAE = 0,
      int EBLEOMJJDMC = 0,
      int GKPLGGIHHBJ = 0,
      int NCADHENBLDB = 0,
      StringOffset DKAFKOABCJAOffset = default(StringOffset)) {
    builder.StartObject(9);
    JEFGONAHEGI.AddDKAFKOABCJA(builder, DKAFKOABCJAOffset);
    JEFGONAHEGI.AddNCADHENBLDB(builder, NCADHENBLDB);
    JEFGONAHEGI.AddGKPLGGIHHBJ(builder, GKPLGGIHHBJ);
    JEFGONAHEGI.AddEBLEOMJJDMC(builder, EBLEOMJJDMC);
    JEFGONAHEGI.AddLPJPOOHJKAE(builder, LPJPOOHJKAE);
    JEFGONAHEGI.AddGONOGEBKNLE(builder, GONOGEBKNLE);
    JEFGONAHEGI.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    JEFGONAHEGI.AddOFMGALJGDAO(builder, OFMGALJGDAO);
    JEFGONAHEGI.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return JEFGONAHEGI.EndJEFGONAHEGI(builder);
  }

  public static void StartJEFGONAHEGI(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddOFMGALJGDAO(FlatBufferBuilder builder, int OFMGALJGDAO) { builder.AddInt(1, OFMGALJGDAO, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, int CFLMCGOJJJD) { builder.AddInt(2, CFLMCGOJJJD, 0); }
  public static void AddGONOGEBKNLE(FlatBufferBuilder builder, int GONOGEBKNLE) { builder.AddInt(3, GONOGEBKNLE, 0); }
  public static void AddLPJPOOHJKAE(FlatBufferBuilder builder, int LPJPOOHJKAE) { builder.AddInt(4, LPJPOOHJKAE, 0); }
  public static void AddEBLEOMJJDMC(FlatBufferBuilder builder, int EBLEOMJJDMC) { builder.AddInt(5, EBLEOMJJDMC, 0); }
  public static void AddGKPLGGIHHBJ(FlatBufferBuilder builder, int GKPLGGIHHBJ) { builder.AddInt(6, GKPLGGIHHBJ, 0); }
  public static void AddNCADHENBLDB(FlatBufferBuilder builder, int NCADHENBLDB) { builder.AddInt(7, NCADHENBLDB, 0); }
  public static void AddDKAFKOABCJA(FlatBufferBuilder builder, StringOffset DKAFKOABCJAOffset) { builder.AddOffset(8, DKAFKOABCJAOffset.Value, 0); }
  public static Offset<JEFGONAHEGI> EndJEFGONAHEGI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<JEFGONAHEGI>(o);
  }
};

