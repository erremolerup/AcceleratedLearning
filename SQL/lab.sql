use Chinook

--3
--SELECT Name AS ArtistName
--FROM Artist
--ORDER BY ArtistName
------------------------------------------------------------------------------------------
--4 EJ KLAR
--SELECT TOP 10 ArtistId
--from Artist ORDER BY Name;
------------------------------------------------------------------------------------------
--5
--SELECT * FROM Artist
--WHERE Name LIKE 'Academy%';
------------------------------------------------------------------------------------------
--6
--SELECT * FROM Album
--WHERE Title LIKE '_ar%';
------------------------------------------------------------------------------------------
--7
--SELECT * FROM Album
--WHERE Title LIKE '[aeiouy]%'
------------------------------------------------------------------------------------------
--8
--SELECT Artist.Name, Album.Title
--From Artist
--right join Album
--on Artist.ArtistId = Album.ArtistId;
------------------------------------------------------------------------------------------
--9
--inner join: endast dom med "fulla" värden (ej null) kommer med i den joinade listan
--left join: alla de vänstra värdena kommer med i nya tabellen
--right join: alla de högra värdena kommer med i den nya tabellen
--full join: alla värden kommer med i nya tabellen, även de som har null i sig
------------------------------------------------------------------------------------------
--10 De 10 artister som släppt flest album (NrOfAlbums, ArtistName)
--SELECT TOP 10 Name AS ArtistName, COUNT(Name) AS NrOfAlbums
--FROM Artist Join Album on Artist.ArtistId = Album.ArtistId
--Group by name
--Order by NrOfAlbums DESC
------------------------------------------------------------------------------------------
--11 Lista namn på alla album som är Jazz eller Blues
--SELECT DISTINCT Album.Title, Genre.Name
--FROM Album
--join Track
--on Album.AlbumId = Track.ALbumId
--join Genre
--on Track.GenreId = Genre.GenreID
--where Genre.Name = 'Jazz' OR Genre.Name = 'Blues'
------------------------------------------------------------------------------------------
--12 Numrera låtarna i 'Let There Be Rock' ACDC 1-8
--alter table Track
--add Number int

--update Track
--set Number = 1
--where TrackId = 15

--update Track
--set Number = 2
--where TrackId = 16

--update Track
--set Number = 3
--where TrackId = 17

--update Track
--set Number = 4
--where TrackId = 18

--update Track
--set Number = 5
--where TrackId = 19

--update Track
--set Number = 6
--where TrackId = 20

--update Track
--set Number = 7
--where TrackId = 21

--update Track
--set Number = 8
--where TrackId = 22

--SELECT Album.Title, Track.Name, Track.TrackId, Track.Number
--FROM Album
--join Track
--ON Album.AlbumId = Track.AlbumId
--Where Album.Title = 'Let There Be Rock'
------------------------------------------------------------------------------------------
--13
--SELECT Genre.Name GenreName,  Count(*) as NrOfTracks
--FROM Genre
--join Track ON Genre.GenreId = Track.GenreId
--GROUP BY Genre.Name
--HAVING COUNT(*) >100
--ORDER BY NrOfTracks DESC

----enklare variant av Oscar
--SELECT *
--FROM Genre
--join Track ON Genre.GenreId = Track.GenreId
------------------------------------------------------------------------------------------
--14
--Declare @MyCustomer int =
--(
--SELECT CustomerId
--FROM Customer
--WHERE FirstName = 'Leonie' AND LastName = 'Köhler'
--)

--SELECT CAST(InvoiceDate as date) AS InvoiceDate
--FROM Invoice
--WHERE CustomerId=@MyCustomer
------------------------------------------------------------------------------------------
--15
--Skapa temporär tabell CustomerWithSupport som innehåller förnamn och efternamn på en kund och dess supportpersonal
--(CustomerFirstName, CustomerLastName, SupportFirstName, SupportLastName)

--drop table #CustomerWithSupport
--SELECT  Customer.FirstName AS CustomerFirstName, Customer.LastName AS CustomerLastName, Employee.FirstName AS SupportFirstName, Employee.LastName AS SupportLastName
--INTO #CustomerWithSupport
--FROM Customer 
--Join Employee on Customer.SupportRepId = Employee.EmployeeId
------------------------------------------------------------------------------------------
--16
--Lista alla anställda som har en chef och deras chef
--resultatet ska vara två kolumner med anställd och chefs fullständiga namn
--EmployeeName, BossName

--Select e1.FirstName + ' ' + e1.LastName AS EmployeeFullName, e2.FirstName + ' ' + e2.LastName AS BossFullName
--FROM Employee e1
--Inner Join Employee e2 on e1.ReportsTo = e2.EmployeeId
------------------------------------------------------------------------------------------
--17
--Hur många tecken har den längsta epostadressen bland alla kunder(LongestMail)
--SELECT TOP 1 Email

--FROM Customer
--ORDER BY len(Email) DESC
------------------------------------------------------------------------------------------
--18
--Den eller de låtar som pågår längst tid
--En rad med låttitel och längd (Name, Minutes)

--SELECT TOP 1 floor(Milliseconds / (1000 * 60)) AS Minutes
--FROM Track
--ORDER BY Minutes DESC
------------------------------------------------------------------------------------------
--19 
--alter table Customer
--add unique(Email)

--Motivering, inte så troligt att två personer har samma email
--Set column as unique
------------------------------------------------------------------------------------------
--20
--Lista hur mycket som har fakturerat för varje år (2009-2013). Sortera så senaste åren visas först (2013) (Year, Sum)
--SELECT YEAR(InvoiceDate) AS Year, SUM(Total) AS Sum
--FROM Invoice
--GROUP BY Year(InvoiceDate)
--ORDER BY Year(InvoiceDate) DESC
------------------------------------------------------------------------------------------
--21
--Ta fram längsta spellistan. (Name, TotalLengthInHours)
--SELECT *
--FROM Playlist

--SELECT DISTINCT TOP 5 PlayList.Name, SUM(Milliseconds / (1000.0 * 60.0 * 60.0)) AS TotalLengthInHours
--FROM Track
--Join PlayListTrack
--ON Track.TrackId = PlayListTrack.TrackId
--Join PlayList
--ON PlaylistTrack.PlaylistId = Playlist.PlaylistId
--GROUP BY PlaylistTrack.PlaylistId, PlayList.Name
--ORDER BY TotalLengthInHours DESC
------------------------------------------------------------------------------------------
--22
--Lista alla anställda som har en chef och deras chefs chef. (EmployeeName, BossesBossName) (Skriver nu ut EmployeeName, BossesName, BossesBossName)

--Select e1.FirstName + ' ' + e1.LastName AS EmployeeName, e2.FirstName + ' ' + e2.LastName AS BossesName, e3.FirstName + ' ' + e3.LastName AS BossesBossName
--FROM Employee e1
--Inner Join Employee e2
--ON e1.ReportsTo = e2.EmployeeId
--Inner Join Employee e3
--ON e2.ReportsTo = e3.EmployeeId

--23 Skapa en ny tabell så varje album kan ha en recension. Lägg till en review på albumet "Black Sabbath"

--CREATE TABLE Review
--(
--	ReviewId int IDENTITY(1,1) PRIMARY KEY,
--	AlbumId int NOT NULL FOREIGN KEY REFERENCES Album(AlbumId),
--	ReviewText nvarchar(1000),
--)

--INSERT INTO Review (AlbumId, ReviewText)
--VALUES ((SELECT AlbumId FROM ALBUM WHERE TITLE LIKE 'Black Sabbath'), ' Kanske en av de bästa någonsin...')
 
