# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class JCFEECCNGIF(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsJCFEECCNGIF(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = JCFEECCNGIF()
        x.Init(buf, n + offset)
        return x

    # JCFEECCNGIF
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # JCFEECCNGIF
    def AMFPDKACLLL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JCFEECCNGIF
    def OFMGALJGDAO(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JCFEECCNGIF
    def CFLMCGOJJJD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JCFEECCNGIF
    def LACEJFCOFHG(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # JCFEECCNGIF
    def LACEJFCOFHGLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # JCFEECCNGIF
    def GHPIPMFBJHH(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

    # JCFEECCNGIF
    def EMFHICAOLOA(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(14))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Uint32Flags, o + self._tab.Pos)
        return 0

def JCFEECCNGIFStart(builder): builder.StartObject(6)
def JCFEECCNGIFAddAMFPDKACLLL(builder, AMFPDKACLLL): builder.PrependUint32Slot(0, AMFPDKACLLL, 0)
def JCFEECCNGIFAddOFMGALJGDAO(builder, OFMGALJGDAO): builder.PrependUint32Slot(1, OFMGALJGDAO, 0)
def JCFEECCNGIFAddCFLMCGOJJJD(builder, CFLMCGOJJJD): builder.PrependUint32Slot(2, CFLMCGOJJJD, 0)
def JCFEECCNGIFAddLACEJFCOFHG(builder, LACEJFCOFHG): builder.PrependUOffsetTRelativeSlot(3, flatbuffers.number_types.UOffsetTFlags.py_type(LACEJFCOFHG), 0)
def JCFEECCNGIFStartLACEJFCOFHGVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def JCFEECCNGIFAddGHPIPMFBJHH(builder, GHPIPMFBJHH): builder.PrependUint32Slot(4, GHPIPMFBJHH, 0)
def JCFEECCNGIFAddEMFHICAOLOA(builder, EMFHICAOLOA): builder.PrependUint32Slot(5, EMFHICAOLOA, 0)
def JCFEECCNGIFEnd(builder): return builder.EndObject()