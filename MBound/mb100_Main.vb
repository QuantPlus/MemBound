
Option Strict Off
Option Explicit On

Imports System.IO

'-------------------------------------------------------------------------------------
'  This class uses longs (64 bits) instead of integers (32-bits) because JAVA
'  does not support unsigned integers, so the only way to store a 32 bit
'  unsigned number is inside a long. NOTE: All calculations are done assuming
'  only 32 bits in the long value
'-------------------------------------------------------------------------------------
Module MBound_Main

'Public NotInheritable Class SampleTableLoader
Public Const SIZE_BIG As Integer = &H400000     'size T = 2^22 i.e. 16 MBytes
Public Const SIZE_SMALL As Integer = 256        'size A = 256

'fixed-forever array... populated read-only
Public BigArray(SIZE_BIG - 1) As Uint32
Public SmallArray(SIZE_SMALL - 1) As Uint32


'-------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------
Public Sub LoadArrays

Const PathBig As String = "c:\VB2010\MBound\functionA.dat"
Const PathSmall As String = "c:\VB2010\MBound\functionB.dat"

Dim k As integer

   Using reader As BinaryReader = New BinaryReader(File.Open(PathBig, FileMode.Open))
      For k = 0 To SIZE_BIG - 1
         BigArray(k) = Reader.ReadUInt32
Console.WriteLine(BigArray(k).ToString.PadLeft(10))
      Next k
   end using

End Sub

End Module
