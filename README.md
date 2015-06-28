# ManChat
A shared-folder based chat app using text files as logs

 ### API ###
 
 --- DIRECTORIES ---
 
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


 --- INTERACTION ---
 
	℘ Upon connection, user should append to server “[username] has joined the server”
	
	℘ Upon exiting the application, user should append to server “[username] has left the server”
	
	℘ While reading the collection of user files, if a user who has been in-active for over a minute it sound, their user file should be deleted.
	
	℘ Upon starting, you app should check the last time each room was written to, and if any room has been in-active for over ten minutes, it should be deleted.
	
