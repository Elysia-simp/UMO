// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class CNLOCJHENHP : Table {
  public static CNLOCJHENHP GetRootAsCNLOCJHENHP(ByteBuffer _bb) { return GetRootAsCNLOCJHENHP(_bb, new CNLOCJHENHP()); }
  public static CNLOCJHENHP GetRootAsCNLOCJHENHP(ByteBuffer _bb, CNLOCJHENHP obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public CNLOCJHENHP __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint BBPHAPFBFHK { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public GHBCOHFGDMM GetKOEFBBACOMJ(int j) { return GetKOEFBBACOMJ(new GHBCOHFGDMM(), j); }
  public GHBCOHFGDMM GetKOEFBBACOMJ(GHBCOHFGDMM obj, int j) { int o = __offset(6); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int KOEFBBACOMJLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<CNLOCJHENHP> CreateCNLOCJHENHP(FlatBufferBuilder builder,
      uint BBPHAPFBFHK = 0,
      VectorOffset KOEFBBACOMJOffset = default(VectorOffset)) {
    builder.StartObject(2);
    CNLOCJHENHP.AddKOEFBBACOMJ(builder, KOEFBBACOMJOffset);
    CNLOCJHENHP.AddBBPHAPFBFHK(builder, BBPHAPFBFHK);
    return CNLOCJHENHP.EndCNLOCJHENHP(builder);
  }

  public static void StartCNLOCJHENHP(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddBBPHAPFBFHK(FlatBufferBuilder builder, uint BBPHAPFBFHK) { builder.AddUint(0, BBPHAPFBFHK, 0); }
  public static void AddKOEFBBACOMJ(FlatBufferBuilder builder, VectorOffset KOEFBBACOMJOffset) { builder.AddOffset(1, KOEFBBACOMJOffset.Value, 0); }
  public static VectorOffset CreateKOEFBBACOMJVector(FlatBufferBuilder builder, Offset<GHBCOHFGDMM>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartKOEFBBACOMJVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<CNLOCJHENHP> EndCNLOCJHENHP(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<CNLOCJHENHP>(o);
  }
};

