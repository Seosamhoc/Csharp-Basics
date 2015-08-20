--Show the city that the IT department (Location_ID  = 2000) is in
SELECT City FROM Locations WHERE Location_ID=(SELECT Location_ID FROM Departments WHERE Department_Name='IT') 