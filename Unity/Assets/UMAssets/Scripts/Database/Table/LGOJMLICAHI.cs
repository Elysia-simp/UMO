// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class LGOJMLICAHI : Table {
  public static LGOJMLICAHI GetRootAsLGOJMLICAHI(ByteBuffer _bb) { return GetRootAsLGOJMLICAHI(_bb, new LGOJMLICAHI()); }
  public static LGOJMLICAHI GetRootAsLGOJMLICAHI(ByteBuffer _bb, LGOJMLICAHI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public LGOJMLICAHI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public string AGOIMGHMGOH { get { int o = __offset(4); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetAGOIMGHMGOHBytes() { return __vector_as_arraysegment(4); }
  public string KJFEBMBHKOC { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetKJFEBMBHKOCBytes() { return __vector_as_arraysegment(6); }

  public static Offset<LGOJMLICAHI> CreateLGOJMLICAHI(FlatBufferBuilder builder,
      StringOffset AGOIMGHMGOHOffset = default(StringOffset),
      StringOffset KJFEBMBHKOCOffset = default(StringOffset)) {
    builder.StartObject(2);
    LGOJMLICAHI.AddKJFEBMBHKOC(builder, KJFEBMBHKOCOffset);
    LGOJMLICAHI.AddAGOIMGHMGOH(builder, AGOIMGHMGOHOffset);
    return LGOJMLICAHI.EndLGOJMLICAHI(builder);
  }

  public static void StartLGOJMLICAHI(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddAGOIMGHMGOH(FlatBufferBuilder builder, StringOffset AGOIMGHMGOHOffset) { builder.AddOffset(0, AGOIMGHMGOHOffset.Value, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, StringOffset KJFEBMBHKOCOffset) { builder.AddOffset(1, KJFEBMBHKOCOffset.Value, 0); }
  public static Offset<LGOJMLICAHI> EndLGOJMLICAHI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<LGOJMLICAHI>(o);
  }
};
