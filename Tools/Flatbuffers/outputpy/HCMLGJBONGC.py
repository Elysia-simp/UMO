# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class HCMLGJBONGC(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsHCMLGJBONGC(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = HCMLGJBONGC()
        x.Init(buf, n + offset)
        return x

    # HCMLGJBONGC
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # HCMLGJBONGC
    def BBPHAPFBFHK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HCMLGJBONGC
    def GEAIPAEKLNF(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # HCMLGJBONGC
    def JGILGOILJNK(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(8))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def HCMLGJBONGCStart(builder): builder.StartObject(3)
def HCMLGJBONGCAddBBPHAPFBFHK(builder, BBPHAPFBFHK): builder.PrependInt32Slot(0, BBPHAPFBFHK, 0)
def HCMLGJBONGCAddGEAIPAEKLNF(builder, GEAIPAEKLNF): builder.PrependInt32Slot(1, GEAIPAEKLNF, 0)
def HCMLGJBONGCAddJGILGOILJNK(builder, JGILGOILJNK): builder.PrependInt32Slot(2, JGILGOILJNK, 0)
def HCMLGJBONGCEnd(builder): return builder.EndObject()