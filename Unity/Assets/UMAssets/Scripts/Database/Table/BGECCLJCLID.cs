// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class BGECCLJCLID : Table {
  public static BGECCLJCLID GetRootAsBGECCLJCLID(ByteBuffer _bb) { return GetRootAsBGECCLJCLID(_bb, new BGECCLJCLID()); }
  public static BGECCLJCLID GetRootAsBGECCLJCLID(ByteBuffer _bb, BGECCLJCLID obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public BGECCLJCLID __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public HHBIKNLNLDF GetGLOAIMAJLCM(int j) { return GetGLOAIMAJLCM(new HHBIKNLNLDF(), j); }
  public HHBIKNLNLDF GetGLOAIMAJLCM(HHBIKNLNLDF obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int GLOAIMAJLCMLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<BGECCLJCLID> CreateBGECCLJCLID(FlatBufferBuilder builder,
      VectorOffset GLOAIMAJLCMOffset = default(VectorOffset)) {
    builder.StartObject(1);
    BGECCLJCLID.AddGLOAIMAJLCM(builder, GLOAIMAJLCMOffset);
    return BGECCLJCLID.EndBGECCLJCLID(builder);
  }

  public static void StartBGECCLJCLID(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddGLOAIMAJLCM(FlatBufferBuilder builder, VectorOffset GLOAIMAJLCMOffset) { builder.AddOffset(0, GLOAIMAJLCMOffset.Value, 0); }
  public static VectorOffset CreateGLOAIMAJLCMVector(FlatBufferBuilder builder, Offset<HHBIKNLNLDF>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartGLOAIMAJLCMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<BGECCLJCLID> EndBGECCLJCLID(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<BGECCLJCLID>(o);
  }
};
