// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class KMMGHIGKELN : Table {
  public static KMMGHIGKELN GetRootAsKMMGHIGKELN(ByteBuffer _bb) { return GetRootAsKMMGHIGKELN(_bb, new KMMGHIGKELN()); }
  public static KMMGHIGKELN GetRootAsKMMGHIGKELN(ByteBuffer _bb, KMMGHIGKELN obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public KMMGHIGKELN __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint COPFAKAHEMN { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint NCIKNCJLFBI { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint EEEHIFGPKON { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint ANDMOLFOEDG { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<KMMGHIGKELN> CreateKMMGHIGKELN(FlatBufferBuilder builder,
      uint COPFAKAHEMN = 0,
      uint NCIKNCJLFBI = 0,
      uint EEEHIFGPKON = 0,
      uint ANDMOLFOEDG = 0) {
    builder.StartObject(4);
    KMMGHIGKELN.AddANDMOLFOEDG(builder, ANDMOLFOEDG);
    KMMGHIGKELN.AddEEEHIFGPKON(builder, EEEHIFGPKON);
    KMMGHIGKELN.AddNCIKNCJLFBI(builder, NCIKNCJLFBI);
    KMMGHIGKELN.AddCOPFAKAHEMN(builder, COPFAKAHEMN);
    return KMMGHIGKELN.EndKMMGHIGKELN(builder);
  }

  public static void StartKMMGHIGKELN(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddCOPFAKAHEMN(FlatBufferBuilder builder, uint COPFAKAHEMN) { builder.AddUint(0, COPFAKAHEMN, 0); }
  public static void AddNCIKNCJLFBI(FlatBufferBuilder builder, uint NCIKNCJLFBI) { builder.AddUint(1, NCIKNCJLFBI, 0); }
  public static void AddEEEHIFGPKON(FlatBufferBuilder builder, uint EEEHIFGPKON) { builder.AddUint(2, EEEHIFGPKON, 0); }
  public static void AddANDMOLFOEDG(FlatBufferBuilder builder, uint ANDMOLFOEDG) { builder.AddUint(3, ANDMOLFOEDG, 0); }
  public static Offset<KMMGHIGKELN> EndKMMGHIGKELN(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<KMMGHIGKELN>(o);
  }
};
