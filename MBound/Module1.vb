
Module MBound_Main
 ''' <summary>
 ''' This class uses longs (64 bits) instead of integers (32-bits) because JAVA
 ''' does not support unsigned integers, so the only way to store a 32 bit
 ''' unsigned number is inside a long. NOTE: All calculations are done assuming
 ''' only 32 bits in the long value
 ''' </summary>
Public NotInheritable Class SampleTableLoader
	''' <summary>
	''' Size of T is 2^22 i.e. 16 MBytes
	''' </summary>
	Public Const m_iSizeOfArrayT As Integer = &H400000

	''' <summary>
	''' Size of A is 256
	''' </summary>
	Public Const m_iSizeOfArrayA As Integer = 256

	''' <summary>
	''' The fixed-forever array - will be populated by populateFixedArrays() This
	''' array requires 16 MB and dominates the space needs of our memory-bound
	''' function.
	''' 
	''' Keeping them static means there will be only one for all objects this is
	''' OK as once populated these are only to be read from and never written
	''' into.
	''' </summary>
	Public Shared m_fixedArrayT(m_iSizeOfArrayT - 1) As Long
	Public Shared m_fixedArrayA0(m_iSizeOfArrayA - 1) As Long

	''' <summary>
	''' Populates T(m_fixedArrayT) and A0(m_fixedArrayA0) from files
	''' </summary>
	Public Sub populateFixedArrays()
		SyncLock Me
			If m_bFixedArraysPopulated Then
				Return
			End If
    
			' both these are loaded from the jar or classpath and located
			' inside the "tab" folder within the jar or classpath
			Const fileNameT As String = "tab/functionT.dat"
			Const fileNameA As String = "tab/functionA.dat"
    
			Dim [in] As DataInputStream
			[in] = New DataInputStream(New BufferedInputStream(Me.GetType().ClassLoader.getResourceAsStream(fileNameT)))
    
			Try
				For i As Integer = 0 To m_iSizeOfArrayT - 1
					m_fixedArrayT(i) = [in].readInt() And &HFFFFFFFFL
				Next i
			Catch e As IOException
				Throw New System.ArgumentException(e)
			Finally
				Try
					[in].close()
				Catch e As IOException
				End Try
			End Try
    
			[in] = New DataInputStream(New BufferedInputStream(Me.GetType().ClassLoader.getResourceAsStream(fileNameA)))
    
			Try
				For i As Integer = 0 To m_iSizeOfArrayA - 1
					m_fixedArrayA0(i) = [in].readInt() And &HFFFFFFFFL
				Next i
			Catch e As IOException
				'TODO: Handle this exception as appropriate
			Finally
				Try
					[in].close()
				Catch e As IOException
				End Try
			End Try
		End SyncLock
	End Sub
End Class
End Module
