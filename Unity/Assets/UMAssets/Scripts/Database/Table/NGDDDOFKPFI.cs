// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class NGDDDOFKPFI : Table {
  public static NGDDDOFKPFI GetRootAsNGDDDOFKPFI(ByteBuffer _bb) { return GetRootAsNGDDDOFKPFI(_bb, new NGDDDOFKPFI()); }
  public static NGDDDOFKPFI GetRootAsNGDDDOFKPFI(ByteBuffer _bb, NGDDDOFKPFI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public NGDDDOFKPFI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int OEBLGFLPMNE { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int BJELMJJFMBI { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetIHNCJBFCAAI(int j) { int o = __offset(8); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int IHNCJBFCAAILength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetIHNCJBFCAAIBytes() { return __vector_as_arraysegment(8); }

  public static Offset<NGDDDOFKPFI> CreateNGDDDOFKPFI(FlatBufferBuilder builder,
      int OEBLGFLPMNE = 0,
      int BJELMJJFMBI = 0,
      VectorOffset IHNCJBFCAAIOffset = default(VectorOffset)) {
    builder.StartObject(3);
    NGDDDOFKPFI.AddIHNCJBFCAAI(builder, IHNCJBFCAAIOffset);
    NGDDDOFKPFI.AddBJELMJJFMBI(builder, BJELMJJFMBI);
    NGDDDOFKPFI.AddOEBLGFLPMNE(builder, OEBLGFLPMNE);
    return NGDDDOFKPFI.EndNGDDDOFKPFI(builder);
  }

  public static void StartNGDDDOFKPFI(FlatBufferBuilder builder) { builder.StartObject(3); }
  public static void AddOEBLGFLPMNE(FlatBufferBuilder builder, int OEBLGFLPMNE) { builder.AddInt(0, OEBLGFLPMNE, 0); }
  public static void AddBJELMJJFMBI(FlatBufferBuilder builder, int BJELMJJFMBI) { builder.AddInt(1, BJELMJJFMBI, 0); }
  public static void AddIHNCJBFCAAI(FlatBufferBuilder builder, VectorOffset IHNCJBFCAAIOffset) { builder.AddOffset(2, IHNCJBFCAAIOffset.Value, 0); }
  public static VectorOffset CreateIHNCJBFCAAIVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartIHNCJBFCAAIVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<NGDDDOFKPFI> EndNGDDDOFKPFI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<NGDDDOFKPFI>(o);
  }
};

