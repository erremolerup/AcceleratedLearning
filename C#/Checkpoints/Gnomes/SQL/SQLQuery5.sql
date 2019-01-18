SELECT Name, BeardYesOrNo, Intention, Temper, Type
FROM Gnome
Inner join Temper ON TemperId = Temper.Id
Left join Type ON TypeId = Type.Id
Left join Beard ON BeardId = Beard.Id
Left join Intention ON IntentionId = Intention.Id
