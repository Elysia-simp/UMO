# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class OHOIIACCJAH(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsOHOIIACCJAH(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = OHOIIACCJAH()
        x.Init(buf, n + offset)
        return x

    # OHOIIACCJAH
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # OHOIIACCJAH
    def CMNLDHJPMPH(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .DIFBGFBHPNC import DIFBGFBHPNC
            obj = DIFBGFBHPNC()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # OHOIIACCJAH
    def CMNLDHJPMPHLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # OHOIIACCJAH
    def NJAJCNKJFMN(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # OHOIIACCJAH
    def NJAJCNKJFMNLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # OHOIIACCJAH
    def CDHLDAKBHCI(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.String(a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return ""

    # OHOIIACCJAH
    def CDHLDAKBHCILength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # OHOIIACCJAH
    def JCKOPOCPOEC(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.String(a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return ""

    # OHOIIACCJAH
    def JCKOPOCPOECLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # OHOIIACCJAH
    def GBHCJIPEFDF(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            x = self._tab.Vector(o)
            x += flatbuffers.number_types.UOffsetTFlags.py_type(j) * 4
            x = self._tab.Indirect(x)
            from .AHCMKLEDILD import AHCMKLEDILD
            obj = AHCMKLEDILD()
            obj.Init(self._tab.Bytes, x)
            return obj
        return None

    # OHOIIACCJAH
    def GBHCJIPEFDFLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(12))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def OHOIIACCJAHStart(builder): builder.StartObject(5)
def OHOIIACCJAHAddCMNLDHJPMPH(builder, CMNLDHJPMPH): builder.PrependUOffsetTRelativeSlot(0, flatbuffers.number_types.UOffsetTFlags.py_type(CMNLDHJPMPH), 0)
def OHOIIACCJAHStartCMNLDHJPMPHVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def OHOIIACCJAHAddNJAJCNKJFMN(builder, NJAJCNKJFMN): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(NJAJCNKJFMN), 0)
def OHOIIACCJAHStartNJAJCNKJFMNVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def OHOIIACCJAHAddCDHLDAKBHCI(builder, CDHLDAKBHCI): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(CDHLDAKBHCI), 0)
def OHOIIACCJAHStartCDHLDAKBHCIVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def OHOIIACCJAHAddJCKOPOCPOEC(builder, JCKOPOCPOEC): builder.PrependUOffsetTRelativeSlot(3, flatbuffers.number_types.UOffsetTFlags.py_type(JCKOPOCPOEC), 0)
def OHOIIACCJAHStartJCKOPOCPOECVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def OHOIIACCJAHAddGBHCJIPEFDF(builder, GBHCJIPEFDF): builder.PrependUOffsetTRelativeSlot(4, flatbuffers.number_types.UOffsetTFlags.py_type(GBHCJIPEFDF), 0)
def OHOIIACCJAHStartGBHCJIPEFDFVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def OHOIIACCJAHEnd(builder): return builder.EndObject()