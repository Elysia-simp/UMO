// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class POKOMFMBPID : Table {
  public static POKOMFMBPID GetRootAsPOKOMFMBPID(ByteBuffer _bb) { return GetRootAsPOKOMFMBPID(_bb, new POKOMFMBPID()); }
  public static POKOMFMBPID GetRootAsPOKOMFMBPID(ByteBuffer _bb, POKOMFMBPID obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public POKOMFMBPID __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int OFMGALJGDAO { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public int BJGOGMAOOOF { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public uint NJLJEKDBPCH { get { int o = __offset(12); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint MAOAGDBDBIB { get { int o = __offset(14); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public string HAEMDABJFJF { get { int o = __offset(16); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetHAEMDABJFJFBytes() { return __vector_as_arraysegment(16); }
  public int OAHOHJALFMC { get { int o = __offset(18); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<POKOMFMBPID> CreatePOKOMFMBPID(FlatBufferBuilder builder,
      int BBPHAPFBFHK = 0,
      int OFMGALJGDAO = 0,
      uint CFLMCGOJJJD = 0,
      int BJGOGMAOOOF = 0,
      uint NJLJEKDBPCH = 0,
      uint MAOAGDBDBIB = 0,
      StringOffset HAEMDABJFJFOffset = default(StringOffset),
      int OAHOHJALFMC = 0) {
    builder.StartObject(8);
    POKOMFMBPID.AddOAHOHJALFMC(builder, OAHOHJALFMC);
    POKOMFMBPID.AddHAEMDABJFJF(builder, HAEMDABJFJFOffset);
    POKOMFMBPID.AddMAOAGDBDBIB(builder, MAOAGDBDBIB);
    POKOMFMBPID.AddNJLJEKDBPCH(builder, NJLJEKDBPCH);
    POKOMFMBPID.AddBJGOGMAOOOF(builder, BJGOGMAOOOF);
    POKOMFMBPID.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    POKOMFMBPID.AddOFMGALJGDAO(builder, OFMGALJGDAO);
    POKOMFMBPID.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return POKOMFMBPID.EndPOKOMFMBPID(builder);
  }

  public static void StartPOKOMFMBPID(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, int BBPHAPFBFHK) { builder.AddInt(0, BBPHAPFBFHK, 0); }
  public static void AddOFMGALJGDAO(FlatBufferBuilder builder, int OFMGALJGDAO) { builder.AddInt(1, OFMGALJGDAO, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(2, CFLMCGOJJJD, 0); }
  public static void AddBJGOGMAOOOF(FlatBufferBuilder builder, int BJGOGMAOOOF) { builder.AddInt(3, BJGOGMAOOOF, 0); }
  public static void AddNJLJEKDBPCH(FlatBufferBuilder builder, uint NJLJEKDBPCH) { builder.AddUint(4, NJLJEKDBPCH, 0); }
  public static void AddMAOAGDBDBIB(FlatBufferBuilder builder, uint MAOAGDBDBIB) { builder.AddUint(5, MAOAGDBDBIB, 0); }
  public static void AddHAEMDABJFJF(FlatBufferBuilder builder, StringOffset HAEMDABJFJFOffset) { builder.AddOffset(6, HAEMDABJFJFOffset.Value, 0); }
  public static void AddOAHOHJALFMC(FlatBufferBuilder builder, int OAHOHJALFMC) { builder.AddInt(7, OAHOHJALFMC, 0); }
  public static Offset<POKOMFMBPID> EndPOKOMFMBPID(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<POKOMFMBPID>(o);
  }
};
