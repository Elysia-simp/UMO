// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class KCMKJOCLIMD : Table {
  public static KCMKJOCLIMD GetRootAsKCMKJOCLIMD(ByteBuffer _bb) { return GetRootAsKCMKJOCLIMD(_bb, new KCMKJOCLIMD()); }
  public static KCMKJOCLIMD GetRootAsKCMKJOCLIMD(ByteBuffer _bb, KCMKJOCLIMD obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public KCMKJOCLIMD __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint KJFEBMBHKOC { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CFLMCGOJJJD { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public int OFMGALJGDAO { get { int o = __offset(10); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public uint ODBPKGJPLMD { get { int o = __offset(12); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<KCMKJOCLIMD> CreateKCMKJOCLIMD(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      uint KJFEBMBHKOC = 0,
      uint CFLMCGOJJJD = 0,
      int OFMGALJGDAO = 0,
      uint ODBPKGJPLMD = 0) {
    builder.StartObject(5);
    KCMKJOCLIMD.AddODBPKGJPLMD(builder, ODBPKGJPLMD);
    KCMKJOCLIMD.AddOFMGALJGDAO(builder, OFMGALJGDAO);
    KCMKJOCLIMD.AddCFLMCGOJJJD(builder, CFLMCGOJJJD);
    KCMKJOCLIMD.AddKJFEBMBHKOC(builder, KJFEBMBHKOC);
    KCMKJOCLIMD.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return KCMKJOCLIMD.EndKCMKJOCLIMD(builder);
  }

  public static void StartKCMKJOCLIMD(FlatBufferBuilder builder) { builder.StartObject(5); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, uint KJFEBMBHKOC) { builder.AddUint(1, KJFEBMBHKOC, 0); }
  public static void AddCFLMCGOJJJD(FlatBufferBuilder builder, uint CFLMCGOJJJD) { builder.AddUint(2, CFLMCGOJJJD, 0); }
  public static void AddOFMGALJGDAO(FlatBufferBuilder builder, int OFMGALJGDAO) { builder.AddInt(3, OFMGALJGDAO, 0); }
  public static void AddODBPKGJPLMD(FlatBufferBuilder builder, uint ODBPKGJPLMD) { builder.AddUint(4, ODBPKGJPLMD, 0); }
  public static Offset<KCMKJOCLIMD> EndKCMKJOCLIMD(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<KCMKJOCLIMD>(o);
  }
};

