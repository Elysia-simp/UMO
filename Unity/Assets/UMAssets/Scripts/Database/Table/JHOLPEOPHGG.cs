// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class JHOLPEOPHGG : Table {
  public static JHOLPEOPHGG GetRootAsJHOLPEOPHGG(ByteBuffer _bb) { return GetRootAsJHOLPEOPHGG(_bb, new JHOLPEOPHGG()); }
  public static JHOLPEOPHGG GetRootAsJHOLPEOPHGG(ByteBuffer _bb, JHOLPEOPHGG obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public JHOLPEOPHGG __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public string NNKLANONDOM { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public ArraySegment<byte>? GetNNKLANONDOMBytes() { return __vector_as_arraysegment(6); }
  public uint JMPGJENBPGH { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<JHOLPEOPHGG> CreateJHOLPEOPHGG(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      StringOffset NNKLANONDOMOffset = default(StringOffset),
      uint JMPGJENBPGH = 0) {
    builder.StartObject(3);
    JHOLPEOPHGG.AddJMPGJENBPGH(builder, JMPGJENBPGH);
    JHOLPEOPHGG.AddNNKLANONDOM(builder, NNKLANONDOMOffset);
    JHOLPEOPHGG.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return JHOLPEOPHGG.EndJHOLPEOPHGG(builder);
  }

  public static void StartJHOLPEOPHGG(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddNNKLANONDOM(FlatBufferBuilder builder, StringOffset NNKLANONDOMOffset) { builder.AddOffset(1, NNKLANONDOMOffset.Value, 0); }
  public static void AddJMPGJENBPGH(FlatBufferBuilder builder, uint JMPGJENBPGH) { builder.AddUint(2, JMPGJENBPGH, 0); }
  public static Offset<JHOLPEOPHGG> EndJHOLPEOPHGG(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<JHOLPEOPHGG>(o);
  }
};

