// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class EDKHNDGHLDE : Table {
  public static EDKHNDGHLDE GetRootAsEDKHNDGHLDE(ByteBuffer _bb) { return GetRootAsEDKHNDGHLDE(_bb, new EDKHNDGHLDE()); }
  public static EDKHNDGHLDE GetRootAsEDKHNDGHLDE(ByteBuffer _bb, EDKHNDGHLDE obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public EDKHNDGHLDE __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int MCJNHPMBPIJ { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MGJKFKDICGC { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<EDKHNDGHLDE> CreateEDKHNDGHLDE(FlatBufferBuilder builder,
      int MCJNHPMBPIJ = 0,
      int MGJKFKDICGC = 0) {
    builder.StartObject(2);
    EDKHNDGHLDE.AddMGJKFKDICGC(builder, MGJKFKDICGC);
    EDKHNDGHLDE.AddMCJNHPMBPIJ(builder, MCJNHPMBPIJ);
    return EDKHNDGHLDE.EndEDKHNDGHLDE(builder);
  }

  public static void StartEDKHNDGHLDE(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddMCJNHPMBPIJ(FlatBufferBuilder builder, int MCJNHPMBPIJ) { builder.AddInt(0, MCJNHPMBPIJ, 0); }
  public static void AddMGJKFKDICGC(FlatBufferBuilder builder, int MGJKFKDICGC) { builder.AddInt(1, MGJKFKDICGC, 0); }
  public static Offset<EDKHNDGHLDE> EndEDKHNDGHLDE(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<EDKHNDGHLDE>(o);
  }
};

