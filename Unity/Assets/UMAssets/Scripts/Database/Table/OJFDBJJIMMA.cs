// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class OJFDBJJIMMA : Table {
  public static OJFDBJJIMMA GetRootAsOJFDBJJIMMA(ByteBuffer _bb) { return GetRootAsOJFDBJJIMMA(_bb, new OJFDBJJIMMA()); }
  public static OJFDBJJIMMA GetRootAsOJFDBJJIMMA(ByteBuffer _bb, OJFDBJJIMMA obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public OJFDBJJIMMA __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public string AGOIMGHMGOH { get { int o = __offset(4); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetAGOIMGHMGOHBytes() { return __vector_as_arraysegment(4); }
  public string KJFEBMBHKOC { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetKJFEBMBHKOCBytes() { return __vector_as_arraysegment(6); }

  public static Offset<OJFDBJJIMMA> CreateOJFDBJJIMMA(FlatBufferBuilder builder,
      StringOffset AGOIMGHMGOHOffset = default(StringOffset),
      StringOffset KJFEBMBHKOCOffset = default(StringOffset)) {
    builder.StartObject(2);
    OJFDBJJIMMA.AddKJFEBMBHKOC(builder, KJFEBMBHKOCOffset);
    OJFDBJJIMMA.AddAGOIMGHMGOH(builder, AGOIMGHMGOHOffset);
    return OJFDBJJIMMA.EndOJFDBJJIMMA(builder);
  }

  public static void StartOJFDBJJIMMA(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddAGOIMGHMGOH(FlatBufferBuilder builder, StringOffset AGOIMGHMGOHOffset) { builder.AddOffset(0, AGOIMGHMGOHOffset.Value, 0); }
  public static void AddKJFEBMBHKOC(FlatBufferBuilder builder, StringOffset KJFEBMBHKOCOffset) { builder.AddOffset(1, KJFEBMBHKOCOffset.Value, 0); }
  public static Offset<OJFDBJJIMMA> EndOJFDBJJIMMA(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<OJFDBJJIMMA>(o);
  }
};
