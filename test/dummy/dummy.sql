USE ProfileManagementDB;
INSERT INTO Trainees (UserProfileId, CurrentCareerId, Active, CreatedBy, CreatedOn, UpdatedBy, UpdatedOn) 
    values (1, null, 1, 1, getdate(), 1, getdate())