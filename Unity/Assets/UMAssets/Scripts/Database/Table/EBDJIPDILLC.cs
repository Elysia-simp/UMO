// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class EBDJIPDILLC : Table {
  public static EBDJIPDILLC GetRootAsEBDJIPDILLC(ByteBuffer _bb) { return GetRootAsEBDJIPDILLC(_bb, new EBDJIPDILLC()); }
  public static EBDJIPDILLC GetRootAsEBDJIPDILLC(ByteBuffer _bb, EBDJIPDILLC obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public EBDJIPDILLC __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public EJMDBHGILEI GetBIDEEFOGFCG(int j) { return GetBIDEEFOGFCG(new EJMDBHGILEI(), j); }
  public EJMDBHGILEI GetBIDEEFOGFCG(EJMDBHGILEI obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int BIDEEFOGFCGLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<EBDJIPDILLC> CreateEBDJIPDILLC(FlatBufferBuilder builder,
      VectorOffset BIDEEFOGFCGOffset = default(VectorOffset)) {
    builder.StartObject(1);
    EBDJIPDILLC.AddBIDEEFOGFCG(builder, BIDEEFOGFCGOffset);
    return EBDJIPDILLC.EndEBDJIPDILLC(builder);
  }

  public static void StartEBDJIPDILLC(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddBIDEEFOGFCG(FlatBufferBuilder builder, VectorOffset BIDEEFOGFCGOffset) { builder.AddOffset(0, BIDEEFOGFCGOffset.Value, 0); }
  public static VectorOffset CreateBIDEEFOGFCGVector(FlatBufferBuilder builder, Offset<EJMDBHGILEI>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartBIDEEFOGFCGVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<EBDJIPDILLC> EndEBDJIPDILLC(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<EBDJIPDILLC>(o);
  }
};

