# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class AMFPOBCCLMN(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsAMFPOBCCLMN(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = AMFPOBCCLMN()
        x.Init(buf, n + offset)
        return x

    # AMFPOBCCLMN
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # AMFPOBCCLMN
    def HOENDPOGFIO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # AMFPOBCCLMN
    def PBOCIEKNBCI(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # AMFPOBCCLMN
    def IHLNKPCMGNE(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def AMFPOBCCLMNStart(builder): builder.StartObject(3)
def AMFPOBCCLMNAddHOENDPOGFIO(builder, HOENDPOGFIO): builder.PrependUint32Slot(0, HOENDPOGFIO, 0)
def AMFPOBCCLMNAddPBOCIEKNBCI(builder, PBOCIEKNBCI): builder.PrependUint32Slot(1, PBOCIEKNBCI, 0)
def AMFPOBCCLMNAddIHLNKPCMGNE(builder, IHLNKPCMGNE): builder.PrependUint32Slot(2, IHLNKPCMGNE, 0)
def AMFPOBCCLMNEnd(builder): return builder.EndObject()