
Option Strict Off
Option Explicit On

Imports System.IO

'-------------------------------------------------------------------------------------
'  MBound - A memory intensive cash algorithm implementation
'  32 bit unsigned                                
'  fixed-forever array... populated read-only
'-------------------------------------------------------------------------------------
Module MBound_Main

Public Const PATH_BIG As String = "c:\VB2010\MBound\functionT.dat"
Public Const SIZE_BIG As Integer =   &H400000     'size T = 2^22 i.e. 16 MBytes
Public Const PATH_SMALL As String = "c:\VB2010\MBound\functionA.dat"
Public Const SIZE_SMALL As Integer = 256          'size A = 256

Public Const HASH_LENGTH As Integer = 160         'hash length bits SHA-1

Public BigArray(SIZE_BIG - 1) As Uint32
Public SmallArray(SIZE_SMALL - 1) As Uint32

Public Loaded As boolean


'-------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------
Public Sub Main

   Call LoadArrays

end sub

'-------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------
Public Sub LoadArrays

Dim k As integer

   Using reader As BinaryReader = New BinaryReader(File.Open(PATH_BIG, FileMode.Open))
      For k = 0 To SIZE_BIG - 1
         BigArray(k) = Reader.ReadUInt32
'Console.WriteLine(BigArray(k).ToString.PadLeft(10))
      Next k
   end using

   Using reader As BinaryReader = New BinaryReader(File.Open(PATH_SMALL, FileMode.Open))
      For k = 0 To SIZE_SMALL - 1
         SmallArray(k) = Reader.ReadUInt32
Console.WriteLine(k.ToString.PadLeft(3) + SmallArray(k).ToString.PadLeft(12))
      Next k
   end using

   Loaded = True
   
End Sub

End Module
