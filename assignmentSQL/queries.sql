USE FindPetOwner;

/*toti userii din beius sau Stei*/
SELECT FirstName, Phone, Address
FROM Users
WHERE Address LIKE '%Beius%' OR Address LIKE '%Stei%'

/*ultimele 3 postari cu available from mai mare decat 01.03*/
SELECT TOP 3 Available_from, Available_to, Address 
FROM FoundPetPosts
WHERE Available_from > ('2022-03-01')
ORDER BY Available_from DESC


/*cate postari au data mai mare decat 01-03, grupate pe data*/
SELECT COUNT(*), Available_from
FROM FoundPetPosts
GROUP BY Available_from
HAVING Available_from > ('2022-03-01')

/*doar assignmenturile cu status in progress*/
SELECT * FROM AssignedVolunteers
WHERE AssignedStatus != 'scheduled'

/*inregistrarea cu cel mai mic id, pentru care AssignedToId = 9*/
SELECT MIN(id) as 'lowest id'
FROM AssignedVolunteers
WHERE AssignedToId = 9

/*de cate ori apare acelasi prenume in lista*/
SELECT FirstName, COUNT(*) Useri_prenume_identic
FROM Users
GROUP BY FirstName

/*toti userii care au si postari*/
SELECT u.FirstName, u.LastName, p.Available_from, p.Available_to, p.PostStatus
FROM Users as u
INNER JOIN FoundPetPosts as p ON u.ID = p.UserId
ORDER BY u.LastName, u.FirstName

/*toti userii cu sau fara postari*/
SELECT u.FirstName, u.LastName, p.Available_from, p.Available_to, p.PostStatus
FROM Users as u
LEFT JOIN FoundPetPosts as p ON u.ID = p.UserId
ORDER BY u.LastName, u.FirstName

/*toti userii care au si postari la care s-a asignat cineva*/
SELECT u.FirstName, u.LastName, p.Available_from, p.Available_to, p.PostStatus, a.ScheduledTime, a.AssignedToId, a.PostId
FROM Users as u
INNER JOIN FoundPetPosts as p ON u.ID = p.UserId
INNER JOIN AssignedVolunteers as a ON P.ID = a.PostId
ORDER BY u.LastName, u.FirstName


/*cate assignmenturi per user*/
SELECT AssignedToId, COUNT(*) noOfAssignments
FROM AssignedVolunteers
GROUP BY AssignedToId
ORDER BY AssignedToId DESC


