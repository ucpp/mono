'Author:
'   V. Sudharsan (vsudharsan@novell.com)
'
' (C) 2005 Novell, Inc.

Module ImpConversionDoubletoDecimalB
	Sub Main()
			Dim c as Boolean = False
			Dim a as Decimal
			Dim b as Double = Double.PositiveInfinity
			try	
				a = b
			Catch e as System.Exception
				c = true
			End try
			if c = False then
				System.Console.WriteLine("Double to Decimal Conversion is not working properly.")		
			End If
	End Sub
End Module

