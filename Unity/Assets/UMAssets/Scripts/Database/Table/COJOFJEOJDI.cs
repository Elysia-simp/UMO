// automatically generated by the FlatBuffers compiler, do not modify

using System;
using FlatBuffers;

public sealed class COJOFJEOJDI : Table {
  public static COJOFJEOJDI GetRootAsCOJOFJEOJDI(ByteBuffer _bb) { return GetRootAsCOJOFJEOJDI(_bb, new COJOFJEOJDI()); }
  public static COJOFJEOJDI GetRootAsCOJOFJEOJDI(ByteBuffer _bb, COJOFJEOJDI obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public COJOFJEOJDI __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public uint CIFKCEFLDDL { get { int o = __offset(4); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint DILIHLCAPFG { get { int o = __offset(6); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint FJDKDEDMHNI { get { int o = __offset(8); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint DLPCOLDNAKE { get { int o = __offset(10); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint BJOOHLLPCFK { get { int o = __offset(12); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint GKLHNNBMGKH { get { int o = __offset(14); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint CNLOBDLMAAP { get { int o = __offset(16); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint NJHACADNBPI { get { int o = __offset(18); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint OHAOECLAPEG { get { int o = __offset(20); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint JNAIKKGAEEE { get { int o = __offset(22); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint HEBOLJILFOE { get { int o = __offset(24); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint JDKJPDKIEOA { get { int o = __offset(26); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }
  public uint EJHHKNOCLBN { get { int o = __offset(28); return o != 0 ? bb.GetUint(o + bb_pos) : (uint)0; } }

  public static Offset<COJOFJEOJDI> CreateCOJOFJEOJDI(FlatBufferBuilder builder,
      uint CIFKCEFLDDL = 0,
      uint DILIHLCAPFG = 0,
      uint FJDKDEDMHNI = 0,
      uint DLPCOLDNAKE = 0,
      uint BJOOHLLPCFK = 0,
      uint GKLHNNBMGKH = 0,
      uint CNLOBDLMAAP = 0,
      uint NJHACADNBPI = 0,
      uint OHAOECLAPEG = 0,
      uint JNAIKKGAEEE = 0,
      uint HEBOLJILFOE = 0,
      uint JDKJPDKIEOA = 0,
      uint EJHHKNOCLBN = 0) {
    builder.StartObject(13);
    COJOFJEOJDI.AddEJHHKNOCLBN(builder, EJHHKNOCLBN);
    COJOFJEOJDI.AddJDKJPDKIEOA(builder, JDKJPDKIEOA);
    COJOFJEOJDI.AddHEBOLJILFOE(builder, HEBOLJILFOE);
    COJOFJEOJDI.AddJNAIKKGAEEE(builder, JNAIKKGAEEE);
    COJOFJEOJDI.AddOHAOECLAPEG(builder, OHAOECLAPEG);
    COJOFJEOJDI.AddNJHACADNBPI(builder, NJHACADNBPI);
    COJOFJEOJDI.AddCNLOBDLMAAP(builder, CNLOBDLMAAP);
    COJOFJEOJDI.AddGKLHNNBMGKH(builder, GKLHNNBMGKH);
    COJOFJEOJDI.AddBJOOHLLPCFK(builder, BJOOHLLPCFK);
    COJOFJEOJDI.AddDLPCOLDNAKE(builder, DLPCOLDNAKE);
    COJOFJEOJDI.AddFJDKDEDMHNI(builder, FJDKDEDMHNI);
    COJOFJEOJDI.AddDILIHLCAPFG(builder, DILIHLCAPFG);
    COJOFJEOJDI.AddCIFKCEFLDDL(builder, CIFKCEFLDDL);
    return COJOFJEOJDI.EndCOJOFJEOJDI(builder);
  }

  public static void StartCOJOFJEOJDI(FlatBufferBuilder builder) { builder.StartObject(13); }
  public static void AddCIFKCEFLDDL(FlatBufferBuilder builder, uint CIFKCEFLDDL) { builder.AddUint(0, CIFKCEFLDDL, 0); }
  public static void AddDILIHLCAPFG(FlatBufferBuilder builder, uint DILIHLCAPFG) { builder.AddUint(1, DILIHLCAPFG, 0); }
  public static void AddFJDKDEDMHNI(FlatBufferBuilder builder, uint FJDKDEDMHNI) { builder.AddUint(2, FJDKDEDMHNI, 0); }
  public static void AddDLPCOLDNAKE(FlatBufferBuilder builder, uint DLPCOLDNAKE) { builder.AddUint(3, DLPCOLDNAKE, 0); }
  public static void AddBJOOHLLPCFK(FlatBufferBuilder builder, uint BJOOHLLPCFK) { builder.AddUint(4, BJOOHLLPCFK, 0); }
  public static void AddGKLHNNBMGKH(FlatBufferBuilder builder, uint GKLHNNBMGKH) { builder.AddUint(5, GKLHNNBMGKH, 0); }
  public static void AddCNLOBDLMAAP(FlatBufferBuilder builder, uint CNLOBDLMAAP) { builder.AddUint(6, CNLOBDLMAAP, 0); }
  public static void AddNJHACADNBPI(FlatBufferBuilder builder, uint NJHACADNBPI) { builder.AddUint(7, NJHACADNBPI, 0); }
  public static void AddOHAOECLAPEG(FlatBufferBuilder builder, uint OHAOECLAPEG) { builder.AddUint(8, OHAOECLAPEG, 0); }
  public static void AddJNAIKKGAEEE(FlatBufferBuilder builder, uint JNAIKKGAEEE) { builder.AddUint(9, JNAIKKGAEEE, 0); }
  public static void AddHEBOLJILFOE(FlatBufferBuilder builder, uint HEBOLJILFOE) { builder.AddUint(10, HEBOLJILFOE, 0); }
  public static void AddJDKJPDKIEOA(FlatBufferBuilder builder, uint JDKJPDKIEOA) { builder.AddUint(11, JDKJPDKIEOA, 0); }
  public static void AddEJHHKNOCLBN(FlatBufferBuilder builder, uint EJHHKNOCLBN) { builder.AddUint(12, EJHHKNOCLBN, 0); }
  public static Offset<COJOFJEOJDI> EndCOJOFJEOJDI(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<COJOFJEOJDI>(o);
  }
};

