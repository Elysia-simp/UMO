// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class MLCJDNPCFHI : Table {
  public static MLCJDNPCFHI GetRootAsMLCJDNPCFHI(ByteBuffer _bb) { return GetRootAsMLCJDNPCFHI(_bb, new MLCJDNPCFHI()); }
  public static MLCJDNPCFHI GetRootAsMLCJDNPCFHI(ByteBuffer _bb, MLCJDNPCFHI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public MLCJDNPCFHI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public LHFKAKHPGBF GetNHJGDCCCDBJ(int j) { return GetNHJGDCCCDBJ(new LHFKAKHPGBF(), j); }
  public LHFKAKHPGBF GetNHJGDCCCDBJ(LHFKAKHPGBF obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int NHJGDCCCDBJLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<MLCJDNPCFHI> CreateMLCJDNPCFHI(FlatBufferBuilder builder,
      VectorOffset NHJGDCCCDBJOffset = default(VectorOffset)) {
    builder.StartObject(1);
    MLCJDNPCFHI.AddNHJGDCCCDBJ(builder, NHJGDCCCDBJOffset);
    return MLCJDNPCFHI.EndMLCJDNPCFHI(builder);
  }

  public static void StartMLCJDNPCFHI(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddNHJGDCCCDBJ(FlatBufferBuilder builder, VectorOffset NHJGDCCCDBJOffset) { builder.AddOffset(0, NHJGDCCCDBJOffset.Value, 0); }
  public static VectorOffset CreateNHJGDCCCDBJVector(FlatBufferBuilder builder, Offset<LHFKAKHPGBF>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNHJGDCCCDBJVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<MLCJDNPCFHI> EndMLCJDNPCFHI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<MLCJDNPCFHI>(o);
  }
};
