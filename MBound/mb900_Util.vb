
Option Strict Off
Option Explicit On

Imports System

Module MBound_Utils

' * Date format string </summary>
Public Const DateFormat As String = "yyMMdd"
' * Gets the calendar at current time at GMT * @author Ali </summary>


'-------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------
Public function GMTCalendar As DateTime

   GMTCalendar = Now 

End function


'-------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------
Public Function BuildLong(ByVal b() As Byte) As long
' * Converts a 8 byte array of unsigned bytes to an lintong *  * <param name="b"> *            an array of 8 unsigned bytes * <returns> a lintong representing the bytes *  * @author Gregory Rubin </returns>
Dim lint As long = 0

   lint = lint Or b(0) And &HFF
   lint <<= 8
   lint = lint Or b(1) And &HFF
   lint <<= 8
   lint = lint Or b(2) And &HFF
   lint <<= 8
   lint = lint Or b(3) And &HFF
   lint <<= 8
   lint = lint Or b(4) And &HFF
   lint <<= 8
   lint = lint Or b(5) And &HFF
   lint <<= 8
   lint = lint Or b(6) And &HFF
   lint <<= 8
   lint = lint Or b(7) And &HFF

   Return lint

End Function

'-------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------
Public Function unsignedIntToLong(ByVal b() As SByte) As Long
' * Converts a 4 byte array of unsigned bytes to an long *  * <param name="b">*            an array of 4 unsigned bytes * <returns> a long representing the unsigned int *  * @author Gregory Rubin </returns>
		Dim l As Long = 0
		l = l Or b(0) And &HFF
		l <<= 8
		l = l Or b(1) And &HFF
		l <<= 8
		l = l Or b(2) And &HFF
		l <<= 8
		l = l Or b(3) And &HFF
		Return l
	End Function

' * Counts the number of leading zeros in a byte array. *  * @author Gregory Rubin </summary>
'-------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------
Public Function numberOfLeadingZeros(ByVal values() As SByte) As Integer
		Dim result As Integer = 0
		Dim temp As Integer = 0
		For i As Integer = 0 To values.Length - 1
			temp = numberOfLeadingZeros(values(i))
			result += temp
			If temp <> 8 Then
				Exit For
			End If
		Next i
		Return result
End Function

' * Returns the number of leading zeros in a bytes binary representation. *  * @author Gregory Rubin </summary>
'-------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------
Public Function numberOfLeadingZeros(ByVal value As SByte) As Integer

		If value < 0 Then
			Return 0
		End If
		If value < 1 Then
			Return 8
		ElseIf value < 2 Then
			Return 7
		ElseIf value < 4 Then
			Return 6
		ElseIf value < 8 Then
			Return 5
		ElseIf value < 16 Then
			Return 4
		ElseIf value < 32 Then
			Return 3
		ElseIf value < 64 Then
			Return 2
		ElseIf value < 128 Then
			Return 1
		Else
			Return 0
		End If

End Function

' * Converts a 32 bit value to an array of bytes. Reverse of * unsignedIntToLong *  * <param name="val">	 *            The 32-bit value to convert </param> </returns>
' <returns> an array containing 4 bytes extracted from the value	 *  * @author Ali	 * <seealso cref= #unsignedIntToLong(byte[])  </seealso>
'-------------------------------------------------------------------------------------
'-------------------------------------------------------------------------------------
Public function toBytes(ByVal val As Long) As SByte()

		Dim bytes(3) As SByte
		bytes(3) = CSByte(val And &HFF)
		bytes(2) = CSByte(CInt(CUInt((val And &HFF00)) >> 8))
		bytes(1) = CSByte(CInt(CUInt((val And &HFF0000)) >> 16))
		bytes(0) = CSByte(CInt(CUInt((val And &HFF000000L)) >> 32))

		Return bytes

End Function

'-----------------------------------------------------------------------------------
'-----------------------------------------------------------------------------------
Public Sub GlobalError(ByRef caller As String, ByRef ErrorNum As Integer, ByRef ErrorDescription As String)
		
   Console.Writeline(caller.PadRight(20) + CStr(ErrorNum).PadLeft(10) + "   " + ErrorDescription)
		
End Sub

End Module
