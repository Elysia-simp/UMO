// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class BECPINGJFLI : Table {
  public static BECPINGJFLI GetRootAsBECPINGJFLI(ByteBuffer _bb) { return GetRootAsBECPINGJFLI(_bb, new BECPINGJFLI()); }
  public static BECPINGJFLI GetRootAsBECPINGJFLI(ByteBuffer _bb, BECPINGJFLI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public BECPINGJFLI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public OALBFMECCIL GetFMCNJAKFCID(int j) { return GetFMCNJAKFCID(new OALBFMECCIL(), j); }
  public OALBFMECCIL GetFMCNJAKFCID(OALBFMECCIL obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int FMCNJAKFCIDLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }
  public IFOEEDHKMMF GetCOJCIOPMDIE(int j) { return GetCOJCIOPMDIE(new IFOEEDHKMMF(), j); }
  public IFOEEDHKMMF GetCOJCIOPMDIE(IFOEEDHKMMF obj, int j) { int o = __offset(6); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int COJCIOPMDIELength { get { int o = __offset(6); return o != 0 ? __vector_len(o) : 0; } }
  public KAKPINDJHMG GetBICLHKLAJLP(int j) { return GetBICLHKLAJLP(new KAKPINDJHMG(), j); }
  public KAKPINDJHMG GetBICLHKLAJLP(KAKPINDJHMG obj, int j) { int o = __offset(8); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int BICLHKLAJLPLength { get { int o = __offset(8); return o != 0 ? __vector_len(o) : 0; } }
  public EHCHNFGDMIN GetNCBNELGABFH(int j) { return GetNCBNELGABFH(new EHCHNFGDMIN(), j); }
  public EHCHNFGDMIN GetNCBNELGABFH(EHCHNFGDMIN obj, int j) { int o = __offset(10); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int NCBNELGABFHLength { get { int o = __offset(10); return o != 0 ? __vector_len(o) : 0; } }
  public int GetNGKPDABJNMK(int j) { int o = __offset(12); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int NGKPDABJNMKLength { get { int o = __offset(12); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetNGKPDABJNMKBytes() { return __vector_as_arraysegment(12); }
  public int GetAOKADHKMIFM(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AOKADHKMIFMLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetAOKADHKMIFMBytes() { return __vector_as_arraysegment(14); }
  public int GetAKMNCOGDAIM(int j) { int o = __offset(16); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int AKMNCOGDAIMLength { get { int o = __offset(16); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetAKMNCOGDAIMBytes() { return __vector_as_arraysegment(16); }
  public int GetLAHBHILKOHD(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int LAHBHILKOHDLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetLAHBHILKOHDBytes() { return __vector_as_arraysegment(18); }
  public int GetNIGBGMIANCE(int j) { int o = __offset(20); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int NIGBGMIANCELength { get { int o = __offset(20); return o != 0 ? __vector_len(o) : 0; } }
  public ArraySegment<byte>? GetNIGBGMIANCEBytes() { return __vector_as_arraysegment(20); }

  public static Offset<BECPINGJFLI> CreateBECPINGJFLI(FlatBufferBuilder builder,
      VectorOffset FMCNJAKFCIDOffset = default(VectorOffset),
      VectorOffset COJCIOPMDIEOffset = default(VectorOffset),
      VectorOffset BICLHKLAJLPOffset = default(VectorOffset),
      VectorOffset NCBNELGABFHOffset = default(VectorOffset),
      VectorOffset NGKPDABJNMKOffset = default(VectorOffset),
      VectorOffset AOKADHKMIFMOffset = default(VectorOffset),
      VectorOffset AKMNCOGDAIMOffset = default(VectorOffset),
      VectorOffset LAHBHILKOHDOffset = default(VectorOffset),
      VectorOffset NIGBGMIANCEOffset = default(VectorOffset)) {
    builder.StartObject(9);
    BECPINGJFLI.AddNIGBGMIANCE(builder, NIGBGMIANCEOffset);
    BECPINGJFLI.AddLAHBHILKOHD(builder, LAHBHILKOHDOffset);
    BECPINGJFLI.AddAKMNCOGDAIM(builder, AKMNCOGDAIMOffset);
    BECPINGJFLI.AddAOKADHKMIFM(builder, AOKADHKMIFMOffset);
    BECPINGJFLI.AddNGKPDABJNMK(builder, NGKPDABJNMKOffset);
    BECPINGJFLI.AddNCBNELGABFH(builder, NCBNELGABFHOffset);
    BECPINGJFLI.AddBICLHKLAJLP(builder, BICLHKLAJLPOffset);
    BECPINGJFLI.AddCOJCIOPMDIE(builder, COJCIOPMDIEOffset);
    BECPINGJFLI.AddFMCNJAKFCID(builder, FMCNJAKFCIDOffset);
    return BECPINGJFLI.EndBECPINGJFLI(builder);
  }

  public static void StartBECPINGJFLI(FlatBufferBuilder builder) { builder.StartObject(9); }
  public static void AddFMCNJAKFCID(FlatBufferBuilder builder, VectorOffset FMCNJAKFCIDOffset) { builder.AddOffset(0, FMCNJAKFCIDOffset.Value, 0); }
  public static VectorOffset CreateFMCNJAKFCIDVector(FlatBufferBuilder builder, Offset<OALBFMECCIL>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartFMCNJAKFCIDVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddCOJCIOPMDIE(FlatBufferBuilder builder, VectorOffset COJCIOPMDIEOffset) { builder.AddOffset(1, COJCIOPMDIEOffset.Value, 0); }
  public static VectorOffset CreateCOJCIOPMDIEVector(FlatBufferBuilder builder, Offset<IFOEEDHKMMF>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartCOJCIOPMDIEVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddBICLHKLAJLP(FlatBufferBuilder builder, VectorOffset BICLHKLAJLPOffset) { builder.AddOffset(2, BICLHKLAJLPOffset.Value, 0); }
  public static VectorOffset CreateBICLHKLAJLPVector(FlatBufferBuilder builder, Offset<KAKPINDJHMG>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartBICLHKLAJLPVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNCBNELGABFH(FlatBufferBuilder builder, VectorOffset NCBNELGABFHOffset) { builder.AddOffset(3, NCBNELGABFHOffset.Value, 0); }
  public static VectorOffset CreateNCBNELGABFHVector(FlatBufferBuilder builder, Offset<EHCHNFGDMIN>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartNCBNELGABFHVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNGKPDABJNMK(FlatBufferBuilder builder, VectorOffset NGKPDABJNMKOffset) { builder.AddOffset(4, NGKPDABJNMKOffset.Value, 0); }
  public static VectorOffset CreateNGKPDABJNMKVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartNGKPDABJNMKVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAOKADHKMIFM(FlatBufferBuilder builder, VectorOffset AOKADHKMIFMOffset) { builder.AddOffset(5, AOKADHKMIFMOffset.Value, 0); }
  public static VectorOffset CreateAOKADHKMIFMVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAOKADHKMIFMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddAKMNCOGDAIM(FlatBufferBuilder builder, VectorOffset AKMNCOGDAIMOffset) { builder.AddOffset(6, AKMNCOGDAIMOffset.Value, 0); }
  public static VectorOffset CreateAKMNCOGDAIMVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartAKMNCOGDAIMVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddLAHBHILKOHD(FlatBufferBuilder builder, VectorOffset LAHBHILKOHDOffset) { builder.AddOffset(7, LAHBHILKOHDOffset.Value, 0); }
  public static VectorOffset CreateLAHBHILKOHDVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartLAHBHILKOHDVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddNIGBGMIANCE(FlatBufferBuilder builder, VectorOffset NIGBGMIANCEOffset) { builder.AddOffset(8, NIGBGMIANCEOffset.Value, 0); }
  public static VectorOffset CreateNIGBGMIANCEVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartNIGBGMIANCEVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<BECPINGJFLI> EndBECPINGJFLI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<BECPINGJFLI>(o);
  }
};

