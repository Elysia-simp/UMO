// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class JDNHKBBPAOI : Table {
  public static JDNHKBBPAOI GetRootAsJDNHKBBPAOI(ByteBuffer _bb) { return GetRootAsJDNHKBBPAOI(_bb, new JDNHKBBPAOI()); }
  public static JDNHKBBPAOI GetRootAsJDNHKBBPAOI(ByteBuffer _bb, JDNHKBBPAOI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public JDNHKBBPAOI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint NAJHJIHCOON { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CBGDIIIBBAN { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<JDNHKBBPAOI> CreateJDNHKBBPAOI(FlatBufferBuilder builder,
      uint NAJHJIHCOON = 0,
      uint CBGDIIIBBAN = 0) {
    builder.StartObject(2);
    JDNHKBBPAOI.AddCBGDIIIBBAN(builder, CBGDIIIBBAN);
    JDNHKBBPAOI.AddNAJHJIHCOON(builder, NAJHJIHCOON);
    return JDNHKBBPAOI.EndJDNHKBBPAOI(builder);
  }

  public static void StartJDNHKBBPAOI(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddNAJHJIHCOON(FlatBufferBuilder builder, uint NAJHJIHCOON) { builder.AddUint(0, NAJHJIHCOON, 0); }
  public static void AddCBGDIIIBBAN(FlatBufferBuilder builder, uint CBGDIIIBBAN) { builder.AddUint(1, CBGDIIIBBAN, 0); }
  public static Offset<JDNHKBBPAOI> EndJDNHKBBPAOI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<JDNHKBBPAOI>(o);
  }
};

