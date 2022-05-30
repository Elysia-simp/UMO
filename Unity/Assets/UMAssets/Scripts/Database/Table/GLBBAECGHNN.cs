// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class GLBBAECGHNN : Table {
  public static GLBBAECGHNN GetRootAsGLBBAECGHNN(ByteBuffer _bb) { return GetRootAsGLBBAECGHNN(_bb, new GLBBAECGHNN()); }
  public static GLBBAECGHNN GetRootAsGLBBAECGHNN(ByteBuffer _bb, GLBBAECGHNN obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public GLBBAECGHNN __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public IJHCOCLJICA GetEKEPMNOOFEF(int j) { return GetEKEPMNOOFEF(new IJHCOCLJICA(), j); }
  public IJHCOCLJICA GetEKEPMNOOFEF(IJHCOCLJICA obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int EKEPMNOOFEFLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }
  public ABHNDHFIFLB GetDIOINIDFAMF(int j) { return GetDIOINIDFAMF(new ABHNDHFIFLB(), j); }
  public ABHNDHFIFLB GetDIOINIDFAMF(ABHNDHFIFLB obj, int j) { int o = __offset(6); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int DIOINIDFAMFLength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public MJMHMHKFDNC GetNJJINHMIOHN(int j) { return GetNJJINHMIOHN(new MJMHMHKFDNC(), j); }
  public MJMHMHKFDNC GetNJJINHMIOHN(MJMHMHKFDNC obj, int j) { int o = __offset(8); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int NJJINHMIOHNLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public OIJDGALEEAI GetNPFBHGKLIOM(int j) { return GetNPFBHGKLIOM(new OIJDGALEEAI(), j); }
  public OIJDGALEEAI GetNPFBHGKLIOM(OIJDGALEEAI obj, int j) { int o = __offset(10); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int NPFBHGKLIOMLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<GLBBAECGHNN> CreateGLBBAECGHNN(FlatBufferBuilder builder,
      VectorOffset EKEPMNOOFEFOffset = default(VectorOffset),
      VectorOffset DIOINIDFAMFOffset = default(VectorOffset),
      VectorOffset NJJINHMIOHNOffset = default(VectorOffset),
      VectorOffset NPFBHGKLIOMOffset = default(VectorOffset)) {
    builder.StartObject(4);
    GLBBAECGHNN.AddNPFBHGKLIOM(builder, NPFBHGKLIOMOffset);
    GLBBAECGHNN.AddNJJINHMIOHN(builder, NJJINHMIOHNOffset);
    GLBBAECGHNN.AddDIOINIDFAMF(builder, DIOINIDFAMFOffset);
    GLBBAECGHNN.AddEKEPMNOOFEF(builder, EKEPMNOOFEFOffset);
    return GLBBAECGHNN.EndGLBBAECGHNN(builder);
  }

  public static void StartGLBBAECGHNN(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddEKEPMNOOFEF(FlatBufferBuilder builder, VectorOffset EKEPMNOOFEFOffset) { builder.AddOffset(0, EKEPMNOOFEFOffset.Value, 0); }
  public static VectorOffset CreateEKEPMNOOFEFVector(FlatBufferBuilder builder, Offset<IJHCOCLJICA>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartEKEPMNOOFEFVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddDIOINIDFAMF(FlatBufferBuilder builder, VectorOffset DIOINIDFAMFOffset) { builder.AddOffset(1, DIOINIDFAMFOffset.Value, 0); }
  public static VectorOffset CreateDIOINIDFAMFVector(FlatBufferBuilder builder, Offset<ABHNDHFIFLB>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartDIOINIDFAMFVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNJJINHMIOHN(FlatBufferBuilder builder, VectorOffset NJJINHMIOHNOffset) { builder.AddOffset(2, NJJINHMIOHNOffset.Value, 0); }
  public static VectorOffset CreateNJJINHMIOHNVector(FlatBufferBuilder builder, Offset<MJMHMHKFDNC>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNJJINHMIOHNVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNPFBHGKLIOM(FlatBufferBuilder builder, VectorOffset NPFBHGKLIOMOffset) { builder.AddOffset(3, NPFBHGKLIOMOffset.Value, 0); }
  public static VectorOffset CreateNPFBHGKLIOMVector(FlatBufferBuilder builder, Offset<OIJDGALEEAI>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNPFBHGKLIOMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<GLBBAECGHNN> EndGLBBAECGHNN(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<GLBBAECGHNN>(o);
  }
};

