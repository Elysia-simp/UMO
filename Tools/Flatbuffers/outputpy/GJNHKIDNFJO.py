# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class GJNHKIDNFJO(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsGJNHKIDNFJO(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = GJNHKIDNFJO()
        x.Init(buf, n + offset)
        return x

    # GJNHKIDNFJO
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # GJNHKIDNFJO
    def LLJMKBDBIGN(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # GJNHKIDNFJO
    def CLFGGLFAJKH(self, j):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            a = self._tab.Vector(o)
            return self._tab.Get(flatbuffers.number_types.Int32Flags, a + flatbuffers.number_types.UOffsetTFlags.py_type(j * 4))
        return 0

    # GJNHKIDNFJO
    def CLFGGLFAJKHLength(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.VectorLen(o)
        return 0

def GJNHKIDNFJOStart(builder): builder.StartObject(2)
def GJNHKIDNFJOAddLLJMKBDBIGN(builder, LLJMKBDBIGN): builder.PrependInt32Slot(0, LLJMKBDBIGN, 0)
def GJNHKIDNFJOAddCLFGGLFAJKH(builder, CLFGGLFAJKH): builder.PrependUOffsetTRelativeSlot(1, flatbuffers.number_types.UOffsetTFlags.py_type(CLFGGLFAJKH), 0)
def GJNHKIDNFJOStartCLFGGLFAJKHVector(builder, numElems): return builder.StartVector(4, numElems, 4)
def GJNHKIDNFJOEnd(builder): return builder.EndObject()