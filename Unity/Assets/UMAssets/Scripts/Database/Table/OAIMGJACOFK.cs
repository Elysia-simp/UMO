// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class OAIMGJACOFK : Table {
  public static OAIMGJACOFK GetRootAsOAIMGJACOFK(ByteBuffer _bb) { return GetRootAsOAIMGJACOFK(_bb, new OAIMGJACOFK()); }
  public static OAIMGJACOFK GetRootAsOAIMGJACOFK(ByteBuffer _bb, OAIMGJACOFK obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public OAIMGJACOFK __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public string AGOIMGHMGOH { get { int o = __offset(4); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetAGOIMGHMGOHBytes() { return __vector_as_arraysegment(4); }
  public int KJFEBMBHKOC { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }

  public static Offset<OAIMGJACOFK> CreateOAIMGJACOFK(FlatBufferBuilder builder,
      StringOffset AGOIMGHMGOHOffset = default(StringOffset),
      int KJFEBMBHKOC = 0) {
    builder.StartObject(2);
    OAIMGJACOFK.AddKJFEBMBHKOC(builder, KJFEBMBHKOC);
    OAIMGJACOFK.AddAGOIMGHMGOH(builder, AGOIMGHMGOHOffset);
    return OAIMGJACOFK.EndOAIMGJACOFK(builder);
  }

  public static void StartOAIMGJACOFK(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddAGOIMGHMGOH(FlatBufferBuilder builder, StringOffset AGOIMGHMGOHOffset) { builder.AddOffset(0, AGOIMGHMGOHOffset.Value, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, int KJFEBMBHKOC) { builder.AddInt(1, KJFEBMBHKOC, 0); }
  public static Offset<OAIMGJACOFK> EndOAIMGJACOFK(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<OAIMGJACOFK>(o);
  }
};

