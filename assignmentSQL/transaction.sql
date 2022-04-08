USE FindPetOwner;

BEGIN TRY

	BEGIN TRANSACTION

		UPDATE Users
		SET FirstName = 'Carmen', LastName = 'Lia'
		WHERE ID = 5
		UPDATE FoundPetPosts
		SET CipId = 'no cip'
		WHERE CipId LIKE '434%'
		UPDATE AssignedVolunteers
		SET ScheduledTime = 6
		WHERE PostId = 3

		DELETE FROM Users
		WHERE ID = 20
		DELETE FROM AssignedVolunteers
		WHERE ScheduledTime > ('2022-01-24')

	COMMIT TRANSACTION

END TRY

BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH