# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class CIGCHPCDJEH(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsCIGCHPCDJEH(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = CIGCHPCDJEH()
        x.Init(buf, n + offset)
        return x

    # CIGCHPCDJEH
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # CIGCHPCDJEH
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # CIGCHPCDJEH
    def OJDNBBILGJC(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # CIGCHPCDJEH
    def HDHGOLJEKBA(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # CIGCHPCDJEH
    def HDHGOLJEKBALength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

    # CIGCHPCDJEH
    def MBAHAELMJLM(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # CIGCHPCDJEH
    def MBAHAELMJLMLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(10))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def CIGCHPCDJEHStart(builder): builder.StartObject(4)
def CIGCHPCDJEHAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def CIGCHPCDJEHAddOJDNBBILGJC(builder, OJDNBBILGJC): builder.PrependInt32Slot(1, OJDNBBILGJC, 0)
def CIGCHPCDJEHAddHDHGOLJEKBA(builder, HDHGOLJEKBA): builder.PrependUOffsetTRelativeSlot(2, flatbuffers.number_types.UOffsetTFlags.py_type(HDHGOLJEKBA), 0)
def CIGCHPCDJEHStartHDHGOLJEKBAVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def CIGCHPCDJEHAddMBAHAELMJLM(builder, MBAHAELMJLM): builder.PrependUOffsetTRelativeSlot(3, flatbuffers.number_types.UOffsetTFlags.py_type(MBAHAELMJLM), 0)
def CIGCHPCDJEHStartMBAHAELMJLMVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def CIGCHPCDJEHEnd(builder): return builder.EndObject()