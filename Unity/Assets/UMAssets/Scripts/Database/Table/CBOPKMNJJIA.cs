// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class CBOPKMNJJIA : Table {
  public static CBOPKMNJJIA GetRootAsCBOPKMNJJIA(ByteBuffer _bb) { return GetRootAsCBOPKMNJJIA(_bb, new CBOPKMNJJIA()); }
  public static CBOPKMNJJIA GetRootAsCBOPKMNJJIA(ByteBuffer _bb, CBOPKMNJJIA obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public CBOPKMNJJIA __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public CECBEDHLMBM GetHBPDIEOICJP(int j) { return GetHBPDIEOICJP(new CECBEDHLMBM(), j); }
  public CECBEDHLMBM GetHBPDIEOICJP(CECBEDHLMBM obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int HBPDIEOICJPLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<CBOPKMNJJIA> CreateCBOPKMNJJIA(FlatBufferBuilder builder,
      VectorOffset HBPDIEOICJPOffset = default(VectorOffset)) {
    builder.StartObject(1);
    CBOPKMNJJIA.AddHBPDIEOICJP(builder, HBPDIEOICJPOffset);
    return CBOPKMNJJIA.EndCBOPKMNJJIA(builder);
  }

  public static void StartCBOPKMNJJIA(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddHBPDIEOICJP(FlatBufferBuilder builder, VectorOffset HBPDIEOICJPOffset) { builder.AddOffset(0, HBPDIEOICJPOffset.Value, 0); }
  public static VectorOffset CreateHBPDIEOICJPVector(FlatBufferBuilder builder, Offset<CECBEDHLMBM>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartHBPDIEOICJPVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<CBOPKMNJJIA> EndCBOPKMNJJIA(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<CBOPKMNJJIA>(o);
  }
};

