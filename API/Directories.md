Everything is stored within a ‘Temp’ Directory marked as System and Hidden:

	.\Temp\
		# Every room is stored within its own directory (Even pm rooms)
		# The default room upon connection is ‘Public’
		Public\
			# The log is stored in a file, named “_[room name].exe”
			# Each user outputs System.DateTime to a file “[username].exe” every 100 ms
			_Public.exe
			UserOne.exe
			SecondUser.exe
			. . . Etc . . .
