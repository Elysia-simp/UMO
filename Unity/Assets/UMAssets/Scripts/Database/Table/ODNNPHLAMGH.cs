// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class ODNNPHLAMGH : Table {
  public static ODNNPHLAMGH GetRootAsODNNPHLAMGH(ByteBuffer _bb) { return GetRootAsODNNPHLAMGH(_bb, new ODNNPHLAMGH()); }
  public static ODNNPHLAMGH GetRootAsODNNPHLAMGH(ByteBuffer _bb, ODNNPHLAMGH obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public ODNNPHLAMGH __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FIMKNOFPMLA GetAMGOKLNCCPH(int j) { return GetAMGOKLNCCPH(new FIMKNOFPMLA(), j); }
  public FIMKNOFPMLA GetAMGOKLNCCPH(FIMKNOFPMLA obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int AMGOKLNCCPHLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<ODNNPHLAMGH> CreateODNNPHLAMGH(FlatBufferBuilder builder,
      VectorOffset AMGOKLNCCPHOffset = default(VectorOffset)) {
    builder.StartObject(1);
    ODNNPHLAMGH.AddAMGOKLNCCPH(builder, AMGOKLNCCPHOffset);
    return ODNNPHLAMGH.EndODNNPHLAMGH(builder);
  }

  public static void StartODNNPHLAMGH(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddAMGOKLNCCPH(FlatBufferBuilder builder, VectorOffset AMGOKLNCCPHOffset) { builder.AddOffset(0, AMGOKLNCCPHOffset.Value, 0); }
  public static VectorOffset CreateAMGOKLNCCPHVector(FlatBufferBuilder builder, Offset<FIMKNOFPMLA>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartAMGOKLNCCPHVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<ODNNPHLAMGH> EndODNNPHLAMGH(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ODNNPHLAMGH>(o);
  }
};

