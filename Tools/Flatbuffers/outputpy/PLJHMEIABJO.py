# automatically generated by the FlatBuffers compiler, do not modify

# namespace: 

import flatbuffers

class PLJHMEIABJO(object):
    __slots__ = ['_tab']

    @classmethod
    def GetRootAsPLJHMEIABJO(cls, buf, offset):
        n = flatbuffers.encode.Get(flatbuffers.packer.uoffset, buf, offset)
        x = PLJHMEIABJO()
        x.Init(buf, n + offset)
        return x

    # PLJHMEIABJO
    def Init(self, buf, pos):
        self._tab = flatbuffers.table.Table(buf, pos)

    # PLJHMEIABJO
    def CLEEFGNMCEL(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(4))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

    # PLJHMEIABJO
    def JKDAMKCJMLD(self):
        o = flatbuffers.number_types.UOffsetTFlags.py_type(self._tab.Offset(6))
        if o != 0:
            return self._tab.Get(flatbuffers.number_types.Int32Flags, o + self._tab.Pos)
        return 0

def PLJHMEIABJOStart(builder): builder.StartObject(2)
def PLJHMEIABJOAddCLEEFGNMCEL(builder, CLEEFGNMCEL): builder.PrependInt32Slot(0, CLEEFGNMCEL, 0)
def PLJHMEIABJOAddJKDAMKCJMLD(builder, JKDAMKCJMLD): builder.PrependInt32Slot(1, JKDAMKCJMLD, 0)
def PLJHMEIABJOEnd(builder): return builder.EndObject()