CREATE TABLE Users(
			ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
			FirstName NVARCHAR(50) NOT NULL,
			LastName NVARCHAR(50) NOT NULL,
			Email NVARCHAR(50) NOT NULL,
			Phone NVARCHAR(50) NOT NULL,
			Address NVARCHAR(50) NOT NULL,
);


CREATE TABLE FoundPetPosts(
			ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
			UserId INT NOT NULL FOREIGN KEY REFERENCES Users(ID),
			Picture IMAGE NOT NULL,
			Phone NVARCHAR(40) NOT NULL,
			Available_from DATETIME NOT NULL,
			Available_to DATETIME NOT NULL,
			Comments NVARCHAR(150) NOT NULL,
			Address NVARCHAR(50) NOT NULL,
			GPSCoordinates NVARCHAR(50) NOT NULL,
			PostStatus NVARCHAR(10) NOT NULL,
			CipId NVARCHAR(15) NOT NULL,
);

CREATE TABLE AssignedVolunteers(
			ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
			AssignedToId INT NOT NULL FOREIGN KEY REFERENCES Users(ID),
			PostId INT NOT NULL FOREIGN KEY REFERENCES FoundPetPosts(ID),
			ScheduledTime DATETIME NOT NULL,
			AssignedStatus NVARCHAR(10) NOT NULL,
);